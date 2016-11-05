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
        private Cell[,] cellArray;

        /// <summary>
        /// Constructor for the grid. Enumerates each cell
        /// </summary>
        /// <param name="cellArray"></param>
        /// <param name="cellHeight"></param>
        /// <param name="cellWidth"></param>
        /// <param name="menuHeight"></param>
        /// <param name="e"></param>
        /// <param name="sbAlive"></param>
        /// <param name="sbDead"></param>
        public Grid(Cell [,] cellArray, float cellHeight, float cellWidth, float menuHeight, PaintEventArgs e, SolidBrush sbAlive, SolidBrush sbDead)
        {
            //Iteration to create a new cell in for every block in the grid
            for (int i = 0; i < cellArray.GetLength(0); i++)
                for (int j = 0; j < cellArray.GetLength(1); j++)
                {
                    double x1 = (i * cellWidth) + 0.5;
                    double x2 = cellWidth - 1;
                    double y1 = ((j*cellHeight) + menuHeight) + 0.5;
                    double y2 = cellHeight - 1;

                    //Conditional statements to check the state of the grid.
                    if (cellArray[i, j] == null || cellArray[i, j].IsAlive == false)
                        cellArray[i, j] = new Cell(x1, y1, x2, y2, false, e, sbDead);
                    else
                        cellArray[i, j] = new Cell(x1, y1, x2, y2, true, e, sbAlive);
                }
            this.cellArray = cellArray;
        }

        /// <summary>
        /// Returns a Grid that has randomly generated dead/alive cells.
        /// </summary>
        /// <param name="grid"></param>
        /// <param name="sbAlive"></param>
        /// <param name="sbDead"></param>
        /// <returns></returns>
        public Grid RandomGrid (Grid grid, SolidBrush sbAlive, SolidBrush sbDead)
        {
            Graphics g = CreateGraphics();
            Random rand = new Random();

            //Iterates through the grid and assigns that index block a random cell state.
            for (int i = 0; i < grid.cellArray.GetLength(0); i++)
                for (int j = 0; j < grid.cellArray.GetLength(1); j++)
                {
                    if (rand.Next(0, 2) == 0)
                        grid.cellArray[i, j].ToggleAlive(true, g, sbAlive);
                    else
                        grid.cellArray[i, j].ToggleAlive(false, g, sbDead);
                }
            return grid;
        }

        /// <summary>
        /// Gets the current Grid/Array of Cells.
        /// </summary>
        public Cell[,] GetCellArray
        {
            get { return cellArray; }
            set { cellArray = value; }
        }
    }
}
