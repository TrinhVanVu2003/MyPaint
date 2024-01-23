using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt2
{
    internal class MyColorRectangle : MyRectangle
    {
        private SolidBrush brush;

        public MyColorRectangle()
        {

        }

        public MyColorRectangle(Point sPoint, Point ePoint, int borderWidth, Color borderColor, SolidBrush solidBrush)
        {
            this.borderWidth = borderWidth;
            this.borderColor = borderColor;
            int x = sPoint.X < ePoint.X ? sPoint.X : ePoint.X;
            int y = sPoint.Y < ePoint.Y ? sPoint.Y : ePoint.Y;
            location = new Point(x, y);
            width = Math.Abs(sPoint.X - ePoint.X);
            height = Math.Abs(sPoint.Y - ePoint.Y);
            this.brush = solidBrush;
        }

        public void Draw(Graphics g)
        {
            Pen pen = new Pen(borderColor, borderWidth);

            g.FillRectangle(brush, location.X, location.Y, width, height);
            g.DrawRectangle(pen, location.X, location.Y, width, height);
        }
    }
}
