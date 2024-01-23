using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt2
{
    internal class MyPatternRectangle : MyRectangle
    {

        Point[] point = new Point[8];
        Rectangle A;
        Rectangle B;
        HatchBrush b;
        private SolidBrush brush;

        public MyPatternRectangle(int x)
        {

        }

        public MyPatternRectangle(Point sPoint, Point ePoint, int borderWidth, Color borderColor, SolidBrush solidBrush)
        {
            this.borderWidth = borderWidth;
            this.borderColor = borderColor;
            int x = sPoint.X < ePoint.X ? sPoint.X : ePoint.X;
            int y = sPoint.Y < ePoint.Y ? sPoint.Y : ePoint.Y;
            location = new Point(x, y);
            width = Math.Abs(sPoint.X - ePoint.X);
            height = Math.Abs(sPoint.Y - ePoint.Y);
            this.brush = solidBrush;

            Rectangle A = new Rectangle(location.X, location.Y, width, height);
            Rectangle B = new Rectangle(location.X - 50, location.Y - 50, width, height);

            point[0] = new Point(A.Left, A.Top);
            point[1] = new Point(B.Left, B.Top);

            point[2] = new Point(A.Right, A.Top);
            point[3] = new Point(B.Right, B.Top);

            point[4] = new Point(A.Left, A.Bottom);
            point[5] = new Point(B.Left, B.Bottom);

            point[6] = new Point(A.Right, A.Bottom);
            point[7] = new Point(B.Right, B.Bottom);

        }

        public void Draw(Graphics g)
        {
            //HatchBrush b = new HatchBrush(...);         
            b = new HatchBrush(HatchStyle.DottedGrid, brush.Color, Color.White);
            Pen pen = new Pen(borderColor, borderWidth);
            g.FillRectangle(b, location.X - 50, location.Y - 50, width, height);

            g.DrawRectangle(pen, location.X, location.Y, width, height);
            g.DrawRectangle(pen, location.X - 50, location.Y - 50, width, height);

            g.DrawLine(pen, point[0], point[1]);
            g.DrawLine(pen, point[2], point[3]);
            g.DrawLine(pen, point[4], point[5]);
            g.DrawLine(pen, point[6], point[7]);
        }
    }
}
