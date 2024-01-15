using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bt2
{
    internal class MyRectangle
    {
        public int width { get; set; }
        public int height { get; set; }
        public Point location { get; set; }
        public int BorderWidth{ get; set; }
        public Color BorderColor{ get; set; }
        public Color FillColor { get; set; }

        public MyRectangle(Point startPoint, Point endPoint, int borderWidth, Color borderColor, Color fillColor)
        {
            location = startPoint;
            width = endPoint.X - startPoint.X;
            height = endPoint.Y - startPoint.Y;
            BorderWidth = borderWidth;
            BorderColor = borderColor;
            FillColor = fillColor;
        }
        public MyRectangle() { }
        public void Draw(Graphics g)
        {
            Pen pen = new Pen(BorderColor, BorderWidth);
            
            g.DrawRectangle(pen, location.X, location.Y, width, height);
        }
        public void ToMau(Color color, Graphics g)
        {
            SolidBrush brush = new SolidBrush(color);
            g.FillRectangle(brush, location.X, location.Y, width, height);
        }
    }
}
