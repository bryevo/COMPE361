using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PA6
{
    public class Grid
    {
        private int row, col;
        private float cellHeight, CellWidth;
        private Cell[,] cellArray;

        public Grid(float cellHeight, float CellWidth)
        {
            this.cellHeight = cellHeight;
            this.CellWidth = CellWidth;
        }

        public Grid(Cell [,] cellArray, float cellHeight, float CellWidth, float menuHeight, PaintEventArgs e)
        {
            this.cellHeight = cellHeight;
            this.CellWidth = CellWidth;
            for (int i = 0; i < cellArray.GetLength(0); i++)
            {
                for (int j = 0; j < cellArray.GetLength(1); j++)
                {
                    if (cellArray[i, j] == null || cellArray[i, j].IsAlive == false)
                        cellArray[i, j] = new Cell(i * this.CellWidth, (j * this.cellHeight) + menuHeight, this.cellHeight, this.CellWidth, false, e);
                    else
                        cellArray[i,j] = new Cell(i * this.CellWidth, (j * this.cellHeight) + menuHeight, this.cellHeight, this.CellWidth, true, e);
                }
            }
            this.cellArray = cellArray;
        }

        public Cell[,] getCellArray
        {
            get { return this.cellArray; }
        }

        public void ResizeGrid(int row, int col)
        {
            this.row = row;
            this.col = col;
        }

        public void LoadCell(Cell[,] cellArray)
        {
            this.cellArray = cellArray;
        }

    }
}
