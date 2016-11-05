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
        private float startX, startY, cellHeight, CellWidth;
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
       
        public Cell(float startX, float startY, float cellHeight, float CellWidth, bool isAlive, PaintEventArgs e, SolidBrush sb)
        {
            this.startX = startX;
            this.startY = startY;
            this.cellHeight = cellHeight;
            this.CellWidth = CellWidth;
            this.isAlive = isAlive;
            g = e.Graphics;
            if (isAlive)
            {
                this.sbAlive = sb;
                ToggleAlive(isAlive, g, sbAlive);
            }
            else
            {
                this.sbDead = sb;
                ToggleAlive(isAlive, g, sbDead);
            }
        }

        public void ToggleAlive(bool check, Graphics x, SolidBrush sb)
        {
            g = x;
            IsAlive = check;
            if (IsAlive)
            {
                g.FillRectangle(sb, startX, startY, this.CellWidth, this.cellHeight);
                isAlive = true;
            }
            else
            {
                g.FillRectangle(sb, startX, startY, this.CellWidth, this.cellHeight);
                isAlive = false;
            }
        }
    }
}
