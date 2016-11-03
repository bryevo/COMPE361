using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA6
{
    public class Grid
    {
        private int row, col;
        private Cell c;
        private float cellHeight, CellWidth;

        public Grid(float cellHeight, float CellWidth)
        {
            this.cellHeight = cellHeight;
            this.CellWidth = CellWidth;
        }

        public Grid(int row, int col, float cellHeight, float CellWidth)
        {
            this.row = row;
            this.col = col;
            this.cellHeight = cellHeight;
            this.CellWidth = CellWidth;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    c = new Cell(new Point((int)(i * this.CellWidth), (int)(j * this.cellHeight)), this.cellHeight, this.CellWidth, false);
                }
            }
        }
        public void ResizeGrid(int row, int col)
        {
            this.row = row;
            this.col = col;
        }
    }
}
