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
        private Point p;
        private bool isAlive = false;
        private float cellHeight, CellWidth;
        Brush brush = new SolidBrush(Color.Green);


        public Graphics Paint { get; set; }
        public Cell(Point p, float cellHeight, float CellWidth, bool isAlive)
        {
            this.p = p;
            this.cellHeight = cellHeight;
            this.CellWidth = CellWidth;
            this.isAlive = isAlive;
        }

    }
}
