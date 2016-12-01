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
            setGridPrefs();

            PutRandFood();
            PutRandPois();

            // clear selection from (0,0)
            fieldDataGridView.CurrentCell = fieldDataGridView[1, 1];
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
            fieldDataGridView.DefaultCellStyle.Font = new Font("Tahoma", rowHeight / 2 - 1);
        }

        public CellType GetCellType(Coord dest)
        {
            return (isValid(dest.x, dest.y)) ? cells[dest.x, dest.y] : CellType.WallCell;
        }

        private bool isValid(int x, int y)
        {
            if (x < 0 || x >= FIELD_WIDTH || y < 0 || y >= FIELD_HEIGHT)
            {
                return false;
            }
            return true;
        }

        public void PutRandFood()
        {
            for (int i = 0; i < FOOD_ON_FIELD; ++i)
            {
                Coord temp = GetFreeCell();
                cells[temp.x, temp.y] = CellType.FoodCell;
                // drow on the grid
                fieldDataGridView.Rows[temp.y].Cells[temp.x].Style.BackColor = FOOD_COLOR;
            }
        }

        public void PutRandPois()
        {
            for (int i = 0; i < FOOD_ON_FIELD; ++i)
            {
                Coord temp = GetFreeCell();
                cells[temp.x, temp.y] = CellType.PoisonCell;
                // drow on the grid
                fieldDataGridView.Rows[temp.y].Cells[temp.x].Style.BackColor = POIS_COLOR;
            }
        }

        public void PutBot(Coord place, int health)
        {
            cells[place.x, place.y] = CellType.BotCell;
            cellsValue[place.x, place.y] = health;
            // drow on the grid
            fieldDataGridView.Rows[place.y].Cells[place.x].Style.BackColor = BOT_COLOR;
            fieldDataGridView.Rows[place.y].Cells[place.x].Value = cellsValue[place.x, place.y];
        }

        public void RemoveBot(Coord place)
        {
            clearCell(place);
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
            fieldDataGridView.Rows[dest.y].Cells[dest.x].Style.BackColor = FOOD_COLOR;
        }

        public void KillBot(Coord dest)
        {
            cells[dest.x, dest.y] = CellType.PoisonCell;
            // drow on the grid
            fieldDataGridView.Rows[dest.y].Cells[dest.x].Style.BackColor = POIS_COLOR;
            fieldDataGridView.Rows[dest.y].Cells[dest.x].Value = "";
        }

        public void RemoveFood(Coord dest)
        {
            clearCell(dest);
        }

        private void clearCell(Coord dest)
        {
            int x = dest.x;
            int y = dest.y;
            cells[x, y] = CellType.EmptyCell;

            fieldDataGridView.Rows[y].Cells[x].Style.BackColor = Color.White;
            fieldDataGridView.Rows[y].Cells[x].Value = "";
        }

        //state
        CellType[,] cells;
        int[,] cellsValue;

        DataGridView fieldDataGridView;
    }
}
