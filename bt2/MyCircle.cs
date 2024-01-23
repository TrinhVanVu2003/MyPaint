﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt2
{
    internal class MyCircle : Shape
    {
        protected Point location;
        protected int borderWidth;
        protected Color borderColor;
        protected int width;
        protected int height;
        protected int a;

        public MyCircle()
        {

        }

        public MyCircle(Point sPoint, Point ePoint, int borderWidth, Color borderColor)
        {
            this.borderWidth = borderWidth;
            this.borderColor = borderColor;
            int x = sPoint.X < ePoint.X ? sPoint.X : ePoint.X;
            int y = sPoint.Y < ePoint.Y ? sPoint.Y : ePoint.Y;
            location = new Point(x, y);
            width = Math.Abs(sPoint.X - ePoint.X);
            height = Math.Abs(sPoint.Y - ePoint.Y);
            a = Math.Min(width, height);
        }

        public void Draw(Graphics g)
        {
            Pen pen = new Pen(borderColor, borderWidth);
            g.DrawEllipse(pen, location.X, location.Y, a, a);
        }
    }
}
