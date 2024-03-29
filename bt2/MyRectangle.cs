﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bt2
{
    internal class MyRectangle : Shape
    {
        protected int width;
        protected int height;

        public MyRectangle()
        {

        }

        public MyRectangle(Point sPoint, Point ePoint, int borderWidth, Color borderColor)
        {
            this.borderWidth = borderWidth;
            this.borderColor = borderColor;
            int x = sPoint.X < ePoint.X ? sPoint.X : ePoint.X;
            int y = sPoint.Y < ePoint.Y ? sPoint.Y : ePoint.Y;
            location = new Point(x, y);
            width = Math.Abs(sPoint.X - ePoint.X);
            height = Math.Abs(sPoint.Y - ePoint.Y);
        }

        public void Draw(Graphics g)
        {
            Pen pen = new Pen(borderColor, borderWidth);
            g.DrawRectangle(pen, location.X, location.Y, width, height);
        }
        public void ToMau(Color color, Graphics g)
        {
            SolidBrush brush = new SolidBrush(color);
            g.FillRectangle(brush, location.X, location.Y, width, height);
            brush.Dispose();

        }
    }
}
