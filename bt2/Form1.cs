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
        private Point _aPoint;
        private Point _sPoint;
        private bool _moving;
        private SolidBrush _brush;
        private LinkedList<MyRectangle> _rectangles;
        private LinkedList<MyColorRectangle> _rectanglesfill;
        private LinkedList<MyCircle> _circles;
        private LinkedList<MyColorCircle> _circlesfill;
        private LinkedList<MyPatternRectangle> _rectanglespattern;
        private LinkedList<MyPatternCircle> _circlespattern;

        public Form1()
        {
            InitializeComponent();
            _graphic = mainPanel.CreateGraphics();
            _aPoint = new Point(-1, -1);
            _sPoint = new Point(-1, -1);
            _moving = false;
            _rectangles = new LinkedList<MyRectangle>();
            _rectanglesfill = new LinkedList<MyColorRectangle>();
            _circles = new LinkedList<MyCircle>();
            _circlesfill = new LinkedList<MyColorCircle>();
            _rectanglespattern = new LinkedList<MyPatternRectangle>();
            _circlespattern = new LinkedList<MyPatternCircle>();
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
            Color penColor = cdPenColor.Color;
            _brush = new SolidBrush(cdFillColor.Color);

            if (rbFillColor.Checked)
            {
                if (rdbRectangle.Checked)
                {
                    MyColorRectangle rectCR = new MyColorRectangle(_sPoint, e.Location, penWidth, penColor, _brush);
                    _rectanglesfill.AddLast(rectCR);
                    _moving = false;
                }
                else if (rdbCircle.Checked)
                {
                    MyColorCircle rectCC = new MyColorCircle(_sPoint, e.Location, penWidth, penColor, _brush);
                    _circlesfill.AddLast(rectCC);
                    _moving = false;
                }
            }
            else if (rbNoColor.Checked)
            {
                if (rdbRectangle.Checked)
                {
                    MyRectangle rectR = new MyRectangle(_sPoint, e.Location, penWidth, penColor);
                    _rectangles.AddLast(rectR);

                }
                else if (rdbCircle.Checked)
                {
                    MyCircle rectC = new MyCircle(_sPoint, e.Location, penWidth, penColor);
                    _circles.AddLast(rectC);
                }
                _sPoint.X = -1;
                _sPoint.Y = -1;
                _moving = false;
            }
            else if (rbPatternColor.Checked)
            {
                if (rdbRectangle.Checked)
                {
                    MyPatternRectangle rectPR = new MyPatternRectangle(_sPoint, e.Location, penWidth, penColor, _brush);
                    _rectanglespattern.AddLast(rectPR);
                }
                else if (rdbCircle.Checked)
                {
                    MyPatternCircle rectPC = new MyPatternCircle(_sPoint, e.Location, penWidth, penColor, _brush);
                    _circlespattern.AddLast(rectPC);
                }
                _sPoint.X = -1;
                _sPoint.Y = -1;
                _moving = false;
            }
        }

        private void mainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_moving || (_sPoint == _aPoint)) { return; }
            RefreshPanel();
            int penWidth = (int)inpPenWidth.Value;
            Color penColor = cdPenColor.Color;
            _brush = new SolidBrush(cdFillColor.Color);

            if (rbFillColor.Checked)
            {
                if (rdbRectangle.Checked)
                {
                    MyColorRectangle rectCR = new MyColorRectangle(_sPoint, e.Location, penWidth, penColor, _brush);
                    rectCR.Draw(_graphic);
                }
                else if (rdbCircle.Checked)
                {
                    MyColorCircle rectCC = new MyColorCircle(_sPoint, e.Location, penWidth, penColor, _brush);
                    rectCC.Draw(_graphic);
                }
            }
            else if (rbNoColor.Checked)
            {
                if (rdbRectangle.Checked)
                {
                    MyRectangle rectR = new MyRectangle(_sPoint, e.Location, penWidth, penColor);
                    rectR.Draw(_graphic);
                }
                else if (rdbCircle.Checked)
                {
                    MyCircle rectC = new MyCircle(_sPoint, e.Location, penWidth, penColor);
                    rectC.Draw(_graphic);
                }
            }
            else if (rbPatternColor.Checked)
            {
                if (rdbRectangle.Checked)
                {
                    MyPatternRectangle rectPR = new MyPatternRectangle(_sPoint, e.Location, penWidth, penColor, _brush);
                    rectPR.Draw(_graphic);
                }
                else if (rdbCircle.Checked)
                {
                    MyPatternCircle recPC = new MyPatternCircle(_sPoint, e.Location, penWidth, penColor, _brush);
                    recPC.Draw(_graphic);
                }
            }
        }
        private void RefreshPanel()
        {
            _graphic.Clear(Color.White);

            foreach (MyRectangle rect in _rectangles)
            {
                rect.Draw(_graphic);
            }
            foreach (MyColorRectangle rect in _rectanglesfill)
            {
                rect.Draw(_graphic);
            }
            foreach (MyCircle rectc in _circles)
            {
                rectc.Draw(_graphic);
            }
            foreach (MyColorCircle rectc in _circlesfill)
            {
                rectc.Draw(_graphic);
            }
            foreach (MyPatternRectangle rectpr in _rectanglespattern)
            {
                rectpr.Draw(_graphic);
            }
            foreach (MyPatternCircle rectpc in _circlespattern)
            {
                rectpc.Draw(_graphic);
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
            _rectanglespattern.Clear();
            _rectanglesfill.Clear();
            _circles.Clear();
            _circlesfill.Clear();
            _circlespattern.Clear();
            _rectangles.Clear();
            RefreshPanel();
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
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
