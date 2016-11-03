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
        private Cell c;
        private float cellHeight, CellWidth;
        private Cell[,] cellArray;

        public Grid(float cellHeight, float CellWidth)
        {
            this.cellHeight = cellHeight;
            this.CellWidth = CellWidth;
        }

        public Grid(Cell [,] cellArray, float cellHeight, float CellWidth, PaintEventArgs e)
        {

            this.cellHeight = cellHeight;
            this.CellWidth = CellWidth;
            for (int i = 0; i < cellArray.GetLength(0); i++)
            {
                for (int j = 0; j < cellArray.GetLength(1); j++)
                {
                    cellArray[i,j] = new Cell(new Point((int)Math.Round(i * this.CellWidth), (int)Math.Round(j * this.cellHeight)), this.cellHeight, this.CellWidth, false, e);           
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
    }
}
