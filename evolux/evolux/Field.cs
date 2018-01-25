using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
//using static kursach.Preferences;



namespace kursach
{
    class Field
    {
        //behavior

        //ctor
        public Field(DataGridView parentGrid)
        {
            cells = new Preferences.CellType[Preferences.FIELD_WIDTH_prop, Preferences.FIELD_HEIGHT_prop];
            cellsValue = new int[Preferences.FIELD_WIDTH_prop, Preferences.FIELD_HEIGHT_prop];

            for (int i = 0; i < Preferences.FIELD_HEIGHT_prop; ++i)
            {
                for (int j = 0; j < Preferences.FIELD_WIDTH_prop; ++j)
                {
                    cells[j, i] = Preferences.CellType.EmptyCell;
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
            if (Preferences.ENABLE_WALLS_prop)
            {
                PutRandWall(Preferences.WALL_ON_FIELD_prop, Preferences.LEN_OF_WALL_prop);
            }
            PutRandFood(Preferences.FOOD_ON_FIELD_prop);
            PutRandPois(Preferences.POIS_ON_FIELD_prop);
        }

        public Preferences.CellType GetCellType(Coord dest)
        {
            return (isValid(dest.x, dest.y)) ? cells[dest.x, dest.y] : Preferences.CellType.WallCell;
        }

        public void PutRandFood(int volume)
        {
            for (int i = 0; i < volume; ++i)
            {
                Coord temp = GetFreeCell();
                cells[temp.x, temp.y] = Preferences.CellType.FoodCell;
                // drow on the grid
                drawFoodCell(temp);
            }
        }

        public void PutRandPois(int volume)
        {
            for (int i = 0; i < volume; ++i)
            {
                Coord temp = GetFreeCell();
                cells[temp.x, temp.y] = Preferences.CellType.PoisonCell;
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
                cells[curWallCell.x, curWallCell.y] = Preferences.CellType.WallCell;

                for (int j = 1; j < len; j++)
                {
                    int startd = TheRnd.Next() % 8;
                    for (int k = 0; k < 8; ++k)
                    {
                        int d = (startd + k) % 8;
                        curWallCell = new Coord(curWallCell.x + Preferences.DIRECT[d, 0], curWallCell.y + Preferences.DIRECT[d, 1]);
                        if (isValid(curWallCell.x, curWallCell.y))
                        {
                            if (cells[curWallCell.x, curWallCell.y] == Preferences.CellType.EmptyCell)
                            {
                                cells[curWallCell.x, curWallCell.y] = Preferences.CellType.WallCell;
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
            cells[dest.x, dest.y] = Preferences.CellType.BotCell;
            cellsValue[dest.x, dest.y] = health;
            // draw on the grid
            drawBotCell(dest, health);
        }

        public void RemoveBot(Coord dest)
        {
            cells[dest.x, dest.y] = Preferences.CellType.EmptyCell;
            // draw
            clearCell(dest);
        }

        public void ResetField()
        {
            for (int i = 0; i < Preferences.FIELD_HEIGHT_prop; ++i)
            {
                for (int j = 0; j < Preferences.FIELD_WIDTH_prop; ++j)
                {
                    cells[j, i] = Preferences.CellType.EmptyCell;
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
                int newX = TheRnd.Next(Preferences.FIELD_WIDTH_prop);
                int newY = TheRnd.Next(Preferences.FIELD_HEIGHT_prop);
                if (cells[newX,newY] == Preferences.CellType.EmptyCell)
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
            cells[dest.x, dest.y] = Preferences.CellType.FoodCell;
            // drow on the grid
            drawFoodCell(dest);
        }

        public void KillBot(Coord dest)
        {
            cells[dest.x, dest.y] = Preferences.CellType.PoisonCell;
            //draw
            drawPoisonCell(dest);
        }

        public void RemoveFood(Coord dest)
        {
            cells[dest.x, dest.y] = Preferences.CellType.EmptyCell;
            // draw
            clearCell(dest);

            // create new food or poison cell
            Coord randCell = GetFreeCell();
            int x = randCell.x;
            int y = randCell.y;

            if (TheRnd.Next() % 2 == 0)
            {
                cells[x, y] = Preferences.CellType.FoodCell;
                drawFoodCell(randCell);
            }
            else
            {
                cells[x, y] = Preferences.CellType.PoisonCell;
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

                fieldDataGridView.Rows[y].Cells[x].Style.BackColor = Preferences.Get_BOT_COLOR;
                fieldDataGridView.Rows[y].Cells[x].Value = health;
            }
        }

        private void drawFoodCell(Coord dest)
        {
            if (drawChanges)
            {
                fieldDataGridView.Rows[dest.y].Cells[dest.x].Style.BackColor = Preferences.Get_FOOD_COLOR;
            }
        }

        private void drawPoisonCell(Coord dest)
        {
            if (drawChanges)
            {
                fieldDataGridView.Rows[dest.y].Cells[dest.x].Style.BackColor = Preferences.Get_POIS_COLOR;
                fieldDataGridView.Rows[dest.y].Cells[dest.x].Value = "";
            }
        }

        private void drawWallCell(Coord dest)
        {
            if (drawChanges)
            {
                fieldDataGridView.Rows[dest.y].Cells[dest.x].Style.BackColor = Preferences.Get_WALL_COLOR;
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
            if (x < 0 || x >= Preferences.FIELD_WIDTH_prop || y < 0 || y >= Preferences.FIELD_HEIGHT_prop)
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
            fieldDataGridView.ColumnCount = Preferences.FIELD_WIDTH_prop;
            fieldDataGridView.RowCount = Preferences.FIELD_HEIGHT_prop;

            int fieldHeight = fieldDataGridView.Height;
            int fieldWidth = fieldDataGridView.Width;
            int rowHeight = fieldHeight / Preferences.FIELD_HEIGHT_prop;
            int colWidth = fieldWidth / Preferences.FIELD_WIDTH_prop;

            foreach (DataGridViewRow row in fieldDataGridView.Rows)
            {
                row.Height = rowHeight;
                // little correct
                fieldDataGridView.Height = rowHeight * Preferences.FIELD_HEIGHT_prop + 3;
            }

            foreach (DataGridViewColumn col in fieldDataGridView.Columns)
            {
                col.Width = colWidth;
                // little correct
                fieldDataGridView.Width = colWidth * Preferences.FIELD_WIDTH_prop + 3;
            }
            // make font
            fieldDataGridView.DefaultCellStyle.Font = new Font("Tahoma", rowHeight / 3);
        }

        //state
        Preferences.CellType[,] cells;
        int[,] cellsValue;

        DataGridView fieldDataGridView;

        bool drawChanges;
        Random TheRnd = new Random();
    }
}
