using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace PA6
{
    public class Cell
    {
        private bool isAlive;
        private float startX, startY, cellHeight, CellWidth;
        private Graphics g;

        public bool IsAlive
        {
            get { return isAlive; }
            set {isAlive = value; }
        }

        public Graphics Paint
        {
            get { return g; }
            set { g = value; }
        }

        public Cell(float startX, float startY, float cellHeight, float CellWidth, bool isAlive, PaintEventArgs e)
        {
            this.startX = startX;
            this.startY = startY;
            this.cellHeight = cellHeight;
            this.CellWidth = CellWidth;
            this.isAlive = isAlive;
            g = e.Graphics;
            if (this.isAlive)
                g.FillRectangle(new SolidBrush(Color.Green), startX, startY, this.CellWidth, this.cellHeight);
            else
                g.FillRectangle(new SolidBrush(Color.DarkGray), startX, startY, this.CellWidth, this.cellHeight);
        }
    }
}
