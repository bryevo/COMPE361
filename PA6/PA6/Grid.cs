using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PA6
{
    public class Grid : Form 
    {
        private float cellHeight, cellWidth;
        private Cell[,] cellArray;

        public Grid(Cell [,] cellArray, float cellHeight, float cellWidth, float menuHeight, PaintEventArgs e, SolidBrush sbAlive, SolidBrush sbDead)
        {
            this.cellHeight = cellHeight;
            this.cellWidth = cellWidth;

            for (int i = 0; i < cellArray.GetLength(0); i++)
            {
                for (int j = 0; j < cellArray.GetLength(1); j++)
                {
                    double x1 = (i * this.cellWidth) + 0.5;
                    double x2 = this.cellWidth - 1;
                    double y1 = ((j*this.cellHeight) + menuHeight) + 0.5;
                    double y2 = this.cellHeight-1;
                    if (cellArray[i, j] == null || cellArray[i, j].IsAlive == false)
                        cellArray[i, j] = new Cell(x1, y1, x2, y2, false, e, sbDead);
                    else
                        cellArray[i, j] = new Cell(x1, y1, x2, y2, true, e, sbAlive);
                }
            }
            this.cellArray = cellArray;
        }

        public Grid randomGrid (Grid grid, SolidBrush sbAlive, SolidBrush sbDead)
        {
            Graphics g = CreateGraphics();
            Random rand = new Random();
            for (int i = 0; i < grid.cellArray.GetLength(0); i++)
            {
                for (int j = 0; j < grid.cellArray.GetLength(1); j++)
                {
                    if (rand.Next(0, 2) == 0)
                    {
                        grid.cellArray[i, j].ToggleAlive(true, g, sbAlive);
                    }
                    else
                        grid.cellArray[i, j].ToggleAlive(false, g, sbDead);
                }
            }
            return grid;
        }

        public Cell[,] getCellArray
        {
            get { return cellArray; }
            set { cellArray = value; }
        }

    }
}
