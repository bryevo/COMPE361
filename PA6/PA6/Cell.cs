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
        SolidBrush sb;

        public bool IsAlive
        {
            get { return isAlive; }
            set {isAlive = value; }
        }

        public Color AliveColor
        {
            get { return this.sb.Color; }
            set { this.sb.Color = value; }
        }
       
        public Cell(float startX, float startY, float cellHeight, float CellWidth, bool isAlive, PaintEventArgs e)
        {
            this.startX = startX;
            this.startY = startY;
            this.cellHeight = cellHeight;
            this.CellWidth = CellWidth;
            this.isAlive = isAlive;
            g = e.Graphics;
            ToggleAlive(isAlive, g);
        }

        public void ToggleAlive(bool check, Graphics x)
        {
            g = x;
            IsAlive = check;
            if (IsAlive)
            {
                g.FillRectangle(new SolidBrush(Color.Green), startX, startY, this.CellWidth, this.cellHeight);
                isAlive = true;
            }
            else
            {
                g.FillRectangle(new SolidBrush(Color.DarkGray), startX, startY, this.CellWidth, this.cellHeight);
                isAlive = false;
            }
        }
    }
}
