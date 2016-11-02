﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PA6
{
    public partial class Form1 : Form
    {
        int row = 42;   //Put 2 more than actual length to fix offset in the grid (1-40)
        int col = 50;
        float cellWidth, cellHeight;
        Pen pen = new Pen(Color.Black, 1);

        public Form1()
        {
            InitializeComponent();
            SetCell();
        }

        private void SetCell()
        {
            cellHeight = ClientSize.Height/ (float)row;
            cellWidth = ClientSize.Width / (float)col;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            for (int i = 1; i < row; i++)
                //Offset Drawing row lines to start at the base of the menuStrip
                g.DrawLine(pen, 0, menuStrip1.Height + cellHeight*i, ClientSize.Width, menuStrip1.Height + cellHeight*i);
            for (int i = 1; i < col; i++)
                g.DrawLine(pen, cellWidth * i, 0, cellWidth * i, ClientSize.Height);
        }

        /// <summary>
        /// Mouse event that gets the coordinate of the mouse click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y - menuStrip1.Height;
            int r = (int)Math.Ceiling((double) y/cellHeight);
            int c = (int)Math.Ceiling((double)x/cellWidth);
            textBox1.Text = String.Format("{0}, {1}", c, r);

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            SetCell();
            Invalidate();
        }
    }
}
