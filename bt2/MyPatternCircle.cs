using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt2
{
    internal class MyPatternCircle : MyCircle
    {
        HatchBrush b;
        private SolidBrush brush;

        public MyPatternCircle()
        {

        }

        public MyPatternCircle(Point sPoint, Point ePoint, int borderWidth, Color borderColor, SolidBrush solidBrush)
        {
            this.borderWidth = borderWidth;
            this.borderColor = borderColor;
            int x = sPoint.X < ePoint.X ? sPoint.X : ePoint.X;
            int y = sPoint.Y < ePoint.Y ? sPoint.Y : ePoint.Y;
            location = new Point(x, y);
            width = Math.Abs(sPoint.X - ePoint.X);
            height = Math.Abs(sPoint.Y - ePoint.Y);
            a = Math.Min(width, height);
            this.brush = solidBrush;
        }

        public void Draw(Graphics g)
        {
            Pen pen = new Pen(borderColor, borderWidth);
            b = new HatchBrush(HatchStyle.DottedGrid, brush.Color, Color.White);
            g.FillEllipse(b, location.X + a / 4, location.Y, a / 2, a);
            g.FillEllipse(b, location.X, location.Y + a / 4, a, a / 2);

            g.DrawEllipse(pen, location.X, location.Y, a, a);
            g.DrawEllipse(pen, location.X + a / 4, location.Y, a / 2, a);
            g.DrawEllipse(pen, location.X, location.Y + a / 4, a, a / 2);


        }
    }
}
