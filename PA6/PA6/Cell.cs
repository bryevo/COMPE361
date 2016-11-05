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

        public int ElementX { get; set; }
        public int ElementY { get; set; }

        public bool IsAlive
        {
            get { return isAlive; }
            set {isAlive = value; }
        }
       
        public Cell(double startX, double startY, double cellWidth, double cellHeight, bool isAlive, PaintEventArgs e, SolidBrush sb)
        {
            this.startX = (float)startX;
            this.startY = (float)startY;
            this.cellHeight = (float)cellHeight;
            this.cellWidth = (float)cellWidth;
            this.isAlive = isAlive;
            g = e.Graphics;
            this.sbAlive = sb;
            ToggleAlive(isAlive, g, sbAlive);
        }
        public Cell(double startX, double startY, double cellWidth, double cellHeight, PaintEventArgs e, bool isAlive,  SolidBrush sb)
        {
            this.startX = (float)startX;
            this.startY = (float)startY;
            this.cellHeight = (float)cellHeight;
            this.cellWidth = (float)cellWidth;
            this.isAlive = isAlive;
            g = e.Graphics;
            this.sbDead = sb;
            ToggleAlive(isAlive, g, sbDead);
        }

        public void ToggleAlive(bool check, Graphics x, SolidBrush sb)
        {
            g = x;
            IsAlive = check;
            if (IsAlive)
            {
                g.FillRectangle(sb, startX, startY, this.cellWidth, this.cellHeight);
                isAlive = true;
            }
            else
            {
                g.FillRectangle(sb, startX, startY, this.cellWidth, this.cellHeight);
                isAlive = false;
            }
        }
    }
}
