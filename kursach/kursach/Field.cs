using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static kursach.consts;
using System.Windows.Forms;
using System.Drawing;

namespace kursach
{
    class Field
    {
        //behavior

        //ctor
        public Field(DataGridView parentGrid)
        {
            cells = new CellType[FIELD_WIDTH, FIELD_HEIGHT];
            cellsValue = new int[FIELD_WIDTH, FIELD_HEIGHT];

            for (int i = 0; i < FIELD_HEIGHT; ++i)
            {
                for (int j = 0; j < FIELD_WIDTH; ++j)
                {
                    cells[j, i] = CellType.EmptyCell;
                    cellsValue[j, i] = 0;
                }
            }

            fieldDataGridView = parentGrid;
            drawChanges = true;

            setGridPrefs();

            // clear selection from (0,0)
            fieldDataGridView.CurrentCell = fieldDataGridView[1, 1];
        }

        public void DoDraw()
        {
            drawChanges = true;
        }

        public void DontDraw()
        {
            drawChanges = false;
        }


        // shared func ////////////////////////////////////////////////////////////////////////////////////
        public void PrepareFieldForGeneration()
        {
            if (ENABLE_WALLS)
            {
                PutRandWall(WALL_ON_FIELD, LEN_OF_WALL);
            }
            PutRandFood(FOOD_ON_FIELD);
            PutRandPois(POIS_ON_FIELD);
        }

        public CellType GetCellType(Coord dest)
        {
            return (isValid(dest.x, dest.y)) ? cells[dest.x, dest.y] : CellType.WallCell;
        }

        public void PutRandFood(int volume)
        {
            for (int i = 0; i < volume; ++i)
            {
                Coord temp = GetFreeCell();
                cells[temp.x, temp.y] = CellType.FoodCell;
                // drow on the grid
                drawFoodCell(temp);
            }
        }

        public void PutRandPois(int volume)
        {
            for (int i = 0; i < volume; ++i)
            {
                Coord temp = GetFreeCell();
                cells[temp.x, temp.y] = CellType.PoisonCell;
                // draw on the grid
                drawPoisonCell(temp);
            }
        }

        public void PutRandWall(int volume, int len)
        {
            for (int i = 0; i < volume; ++i)
            {
                Coord curWallCell = GetFreeCell();
                drawWallCell(curWallCell);
                cells[curWallCell.x, curWallCell.y] = CellType.WallCell;

                for (int j = 1; j < len; j++)
                {
                    int startd = TheRnd.Next() % 8;
                    for (int k = 0; k < 8; ++k)
                    {
                        int d = (startd + k) % 8;
                        curWallCell = new Coord(curWallCell.x + DIRECT[d, 0], curWallCell.y + DIRECT[d, 1]);
                        if (isValid(curWallCell.x, curWallCell.y))
                        {
                            if (cells[curWallCell.x, curWallCell.y] == CellType.EmptyCell)
                            {
                                cells[curWallCell.x, curWallCell.y] = CellType.WallCell;
                                drawWallCell(curWallCell);
                                break;
                            }
                        }
                    }
                }
            }
        }

        public void PutBot(Coord dest, int health)
        {
            cells[dest.x, dest.y] = CellType.BotCell;
            cellsValue[dest.x, dest.y] = health;
            // draw on the grid
            drawBotCell(dest, health);
        }

        public void RemoveBot(Coord dest)
        {
            cells[dest.x, dest.y] = CellType.EmptyCell;
            // draw
            clearCell(dest);
        }

        public void ResetField()
        {
            for (int i = 0; i < FIELD_HEIGHT; ++i)
            {
                for (int j = 0; j < FIELD_WIDTH; ++j)
                {
                    cells[j, i] = CellType.EmptyCell;
                    cellsValue[j, i] = 0;
                    // draw
                    clearCell(new Coord(j,i));

                }
            }
        }

        public Coord GetFreeCell()
        {
            bool isComplete = false;

            while (!isComplete)
            {
                int newX = TheRnd.Next(FIELD_WIDTH);
                int newY = TheRnd.Next(FIELD_HEIGHT);
                if (cells[newX,newY] == CellType.EmptyCell)
                {
                    return new Coord(newX, newY);
                }
            }

            return new Coord(0, 0);
        }

        public void MoveBot(Coord from, Coord dest, int health)
        {
            RemoveBot(from);
            PutBot(dest, health);
        }

        public void PoisonToFood(Coord dest)
        {
            cells[dest.x, dest.y] = CellType.FoodCell;
            // drow on the grid
            drawFoodCell(dest);
        }

        public void KillBot(Coord dest)
        {
            cells[dest.x, dest.y] = CellType.PoisonCell;
            //draw
            drawPoisonCell(dest);
        }

        public void RemoveFood(Coord dest)
        {
            cells[dest.x, dest.y] = CellType.EmptyCell;
            // draw
            clearCell(dest);

            // create new food or poison cell
            Coord randCell = GetFreeCell();
            int x = randCell.x;
            int y = randCell.y;

            if (TheRnd.Next() % 2 == 0)
            {
                cells[x, y] = CellType.FoodCell;
                drawFoodCell(randCell);
            }
            else
            {
                cells[x, y] = CellType.PoisonCell;
                drawPoisonCell(randCell);
            }
        }

        // end shared func /////////////////////////////////////////////////////////////////////////////////////


        // private

        // draw interface
        private void drawBotCell(Coord dest, int health)
        {
            if (drawChanges)
            {
                int x = dest.x;
                int y = dest.y;

                fieldDataGridView.Rows[y].Cells[x].Style.BackColor = BOT_COLOR;
                fieldDataGridView.Rows[y].Cells[x].Value = health;
            }
        }

        private void drawFoodCell(Coord dest)
        {
            if (drawChanges)
            {
                fieldDataGridView.Rows[dest.y].Cells[dest.x].Style.BackColor = FOOD_COLOR;
            }
        }

        private void drawPoisonCell(Coord dest)
        {
            if (drawChanges)
            {
                fieldDataGridView.Rows[dest.y].Cells[dest.x].Style.BackColor = POIS_COLOR;
                fieldDataGridView.Rows[dest.y].Cells[dest.x].Value = "";
            }
        }

        private void drawWallCell(Coord dest)
        {
            if (drawChanges)
            {
                fieldDataGridView.Rows[dest.y].Cells[dest.x].Style.BackColor = WALL_COLOR;
            }
        }

        private void clearCell(Coord dest)
        {
            if (drawChanges)
            {
                int x = dest.x;
                int y = dest.y;

                fieldDataGridView.Rows[y].Cells[x].Style.BackColor = Color.White;
                fieldDataGridView.Rows[y].Cells[x].Value = "";
            }
        }
        // end draw interface

        private bool isValid(int x, int y)
        {
            if (x < 0 || x >= FIELD_WIDTH || y < 0 || y >= FIELD_HEIGHT)
            {
                return false;
            }
            return true;
        }

        public void Resize()
        {
            setGridPrefs();
        }

        private void setGridPrefs()
        {
            // set number of cells
            fieldDataGridView.ColumnCount = FIELD_WIDTH;
            fieldDataGridView.RowCount = FIELD_HEIGHT;

            int fieldHeight = fieldDataGridView.Height;
            int fieldWidth = fieldDataGridView.Width;
            int rowHeight = fieldHeight / FIELD_HEIGHT;
            int colWidth = fieldWidth / FIELD_WIDTH;

            foreach (DataGridViewRow row in fieldDataGridView.Rows)
            {
                row.Height = rowHeight;
                // little correct
                fieldDataGridView.Height = rowHeight * FIELD_HEIGHT + 3;
            }

            foreach (DataGridViewColumn col in fieldDataGridView.Columns)
            {
                col.Width = colWidth;
                // little correct
                fieldDataGridView.Width = colWidth * FIELD_WIDTH + 3;
            }
            // make font
            fieldDataGridView.DefaultCellStyle.Font = new Font("Tahoma", rowHeight / 3);
        }

        //state
        CellType[,] cells;
        int[,] cellsValue;

        DataGridView fieldDataGridView;

        bool drawChanges;
        Random TheRnd = new Random();
    }
}
