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
            PutRandFood(FOOD_ON_FIELD);
            PutRandPois();
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

        public void PutRandPois()
        {
            for (int i = 0; i < POIS_ON_FIELD; ++i)
            {
                Coord temp = GetFreeCell();
                cells[temp.x, temp.y] = CellType.PoisonCell;
                // draw on the grid
                drawPoisonCell(temp);
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
            Random rnd = new Random();
            bool isComplete = false;

            while (!isComplete)
            {
                int newX = rnd.Next(FIELD_WIDTH);
                int newY = rnd.Next(FIELD_HEIGHT);
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
    }
}
