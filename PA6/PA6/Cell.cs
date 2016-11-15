using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace PA6
{
    public class Cell : Form
    {
        private bool isAlive;
        private float startX, startY, cellHeight, cellWidth;
        private Graphics g;
        SolidBrush sbDead = new SolidBrush(Color.DarkGray);
        SolidBrush sbAlive = new SolidBrush(Color.Green);

        /// <summary>
        /// Returns or sets the current state of the Cell
        /// </summary>
        public bool IsAlive
        {
            get { return isAlive; }
            set {isAlive = value; }
        }
       
        /// <summary>
        /// Constructor for the Alive Cells
        /// </summary>
        /// <param name="startX"></param>
        /// <param name="startY"></param>
        /// <param name="cellWidth"></param>
        /// <param name="cellHeight"></param>
        /// <param name="isAlive"></param>
        /// <param name="e"></param>
        /// <param name="sb"></param>
        public Cell(double startX, double startY, double cellWidth, double cellHeight, bool isAlive, PaintEventArgs e, SolidBrush sb)
        {
            this.startX = (float)startX;
            this.startY = (float)startY;
            this.cellHeight = (float)cellHeight;
            this.cellWidth = (float)cellWidth;
            this.isAlive = isAlive;
            g = e.Graphics;
            sbAlive = sb;
            ToggleAlive(isAlive, g, sbAlive);
        }

        /// <summary>
        /// Constructor for Dead Cells
        /// </summary>
        /// <param name="startX"></param>
        /// <param name="startY"></param>
        /// <param name="cellWidth"></param>
        /// <param name="cellHeight"></param>
        /// <param name="e"></param>
        /// <param name="isAlive"></param>
        /// <param name="sb"></param>
        public Cell(double startX, double startY, double cellWidth, double cellHeight, PaintEventArgs e, bool isAlive,  SolidBrush sb)
        {
            this.startX = (float)startX;
            this.startY = (float)startY;
            this.cellHeight = (float)cellHeight;
            this.cellWidth = (float)cellWidth;
            this.isAlive = isAlive;
            g = e.Graphics;
            sbDead = sb;
            ToggleAlive(isAlive, g, sbDead);
        }

        /// <summary>
        /// Repaints the cell based on its current State.
        /// </summary>
        /// <param name="checkAlive"></param>
        /// <param name="x"></param>
        /// <param name="sb"></param>
        public void ToggleAlive(bool checkAlive, Graphics x, SolidBrush sb)
        {
            g = x;
            isAlive = checkAlive;
            if (isAlive)
                g.FillRectangle(sb, startX, startY, cellWidth, cellHeight);
            else
                g.FillRectangle(sb, startX, startY, cellWidth, cellHeight);
        }
    }
}
