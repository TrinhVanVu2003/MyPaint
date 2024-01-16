using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bt2
{
    public partial class Form1 : Form
    {
        private Graphics _graphic;
        private Pen _pen;
        private Point _aPoint;
        private Point _sPoint;
        private bool _moving;
        private LinkedList<MyRectangle> _rectangles;

        public Form1()
        {
            InitializeComponent();
            _graphic = mainPanel.CreateGraphics();
            _pen = new Pen(Color.Black, 1);
            _aPoint = new Point(-1, -1);
            _sPoint = new Point(-1, -1);
            _moving = false;
            _rectangles = new LinkedList<MyRectangle>();

        }

        private void mainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            _sPoint.X = e.X;
            _sPoint.Y = e.Y;
            _moving = true;

        }

        private void mainPanel_MouseUp(object sender, MouseEventArgs e)
        {
            int penWidth = (int)inpPenWidth.Value;
            Color fillColor = cdFillColor.Color;  
            Color penColor = cdPenColor.Color;


            if (rbFillColor.Checked)
            {
                MyRectangle rect = new MyRectangle(_sPoint, e.Location, penWidth, penColor, fillColor);
                _rectangles.AddLast(rect);
            }
            else if (rbNoColor.Checked)
            {
                MyRectangle rect = new MyRectangle(_sPoint, e.Location, penWidth, penColor);
                _rectangles.AddLast(rect);
            }
            else if (rbPatternColor.Checked)
            {

            }
            _sPoint.X = -1;
            _sPoint.Y = -1;
            _moving = false;
        }

        private void mainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_moving || (_sPoint == _aPoint)) { return; }
            RefreshPanel();
            int penWidth = (int)inpPenWidth.Value;
            Color fillColor = cdFillColor.Color;
            Color penColor = cdPenColor.Color;
            MyRectangle rect = new MyRectangle(_sPoint, e.Location, penWidth, penColor,fillColor);
            rect.Draw(_graphic);
            rect.ToMau(fillColor,_graphic);
        }
        private void RefreshPanel()
        {
            _graphic.Clear(Color.White);
            foreach (MyRectangle rect in _rectangles)
            {
                rect.Draw(_graphic);
                rect.ToMau(rect.FillColor, _graphic);
            }
        }
        private Rectangle GetRectangle(Point sPoint, Point ePoint)
        {
            int x = sPoint.X < ePoint.X ? sPoint.X : ePoint.X;
            int y = sPoint.Y < ePoint.Y ? sPoint.Y : ePoint.Y;
            int w = Math.Abs(sPoint.X - ePoint.X);
            int h = Math.Abs(sPoint.Y - ePoint.Y);
            return new Rectangle(x, y, w, h);
        }

        private void btnColor_Click(object sender, EventArgs e)
        {

            if (cdPenColor.ShowDialog() == DialogResult.OK)
            {
                lblPenColor.ForeColor = cdPenColor.Color;
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void btnChoseColor_Click(object sender, EventArgs e)
        {
            if (cdFillColor.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void RefreshForm()
        {
            _rectangles.Clear();
            RefreshPanel();
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Xử lý sự kiện khi RadioButton thay đổi
            RefreshPanel();
        }
        private void txtNetVe_Click(object sender, EventArgs e)
        {

        }

        private void lblChoseColor_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshForm();
        }
    }
}
