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

        public Grid randomGrid (Grid grid)
        {
            Random rand = new Random();
            for (int i = 0; i < grid.cellArray.GetLength(0); i++)
            {
                for (int j = 0; j < grid.cellArray.GetLength(1); j++)
                {

                    if (rand.Next(0, 2) == 0) {
                        grid.cellArray[i, j].IsAlive = false;
                        Console.WriteLine("Element {0}, {1} is {2}", i, j, cellArray[i, j].IsAlive);
                    }

                    else
                        grid.cellArray[i, j].IsAlive = true;
                        Console.WriteLine("Element {0}, {1} is {2}", i, j, cellArray[i, j].IsAlive);
                }
            }
            return grid;
        }


        public Cell[,] getCellArray
        {
            get { return this.cellArray; }
        }

    }
}
