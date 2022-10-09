using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Laba4.Primitives;

namespace Laba4
{
    
    public partial class Form1 : Form
    {
        private Graphics g;
        private List<PointApp> points = new List<PointApp>();
        private List<Line> lines = new List<Line>();
        private List<Polygon> polygons = new List<Polygon>();

        private bool shouldStartNewLine = true;
        private bool shouldStartNewPolygon = true;

        private Line lastLine;
        private Line priviosLine;
        private PointApp LineFirstPoint;
        private Polygon lastPolygon;
        private PointApp lastPoint;
        private IPrimitive SelectedPrim;
        private Line previoslySelectedLine;

        private MouseEventArgs locate;
        public Form1()
        {
            InitializeComponent();
            this.rbLine.Checked = false;
            this.rbPoint.Checked = false;
            this.rbPolygon.Checked = false;
            this.selectedPrm.Checked = false;
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(pictureBox1.Image);
            g.Clear(Color.White);
            
        }
        private IPrimitive SelectedPrimitive
        {
            get
            {
                if(SelectedPrim == null)
                {
                    return null;
                }
                var point = SelectedPrim;
                if(point is Line)
                {
                    this.previoslySelectedLine = (Line)point;
                }
                return point;
            }
            set
            {
                Redraw();
            }
        }

        private void button_clear_canvas_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            pictureBox1.Invalidate();
            points.Clear(); // удалить точки
            lines.Clear(); // удалить отрезки
            polygons.Clear(); // удалить полигоны
            shouldStartNewPolygon = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            locate = (MouseEventArgs)e;
            PointApp p = PointApp.FromPoint(locate.Location);
            if(this.selectedPrm.Checked)
            {
                foreach(var item in points)
                {
                    if(item.X - p.X > -5 && item.X - p.X < 5)
                    {
                        this.SelectedPrim = (IPrimitive)item;
                    }
                }
                foreach(var item in lines)
                {
                    if(item.Distance(p) > -5 && item.Distance(p) < 5)
                    {
                        this.SelectedPrim = (IPrimitive)item;
                    }
                }
                foreach(var item in polygons)
                {
                    for(int i =0;i<item.Points.Count -1;++i)
                    {
                        Line l;
                        if(i == item.Points.Count - 1) // если 1 элемент
                        {
                            l = new Line(item.Points[i], item.Points[0]);
                        }
                        else
                        {
                            l = new Line(item.Points[i], item.Points[i + 1]);                           
                        }
                        if (l.Distance(p) > -5 && l.Distance(p) < 5)
                        {
                            this.SelectedPrim = (IPrimitive)item;
                        }                       
                    }
                }
                if (SelectedPrimitive is PointApp)
                {
                    lastPoint = (PointApp)SelectedPrimitive;
                }
                if (SelectedPrimitive is Line)
                {
                    priviosLine = lastLine;
                    lastLine = (Line)SelectedPrimitive;
                }
                if (SelectedPrimitive is Polygon)
                {
                    lastPolygon = (Polygon)SelectedPrimitive;
                }

            }
            if(this.rbPoint.Checked)
            {
                this.SelectedPrim = (IPrimitive)p;
                this.points.Add(p);
            }
            else if(this.rbLine.Checked)
            {
                if(this.shouldStartNewLine)
                {
                    LineFirstPoint = p;
                    this.shouldStartNewLine = false;
                }
                else
                {
                    Line line = new Line(LineFirstPoint, p);
                    SelectedPrim = (IPrimitive)line;
                    lines.Add(line);
                    shouldStartNewLine = true;
                }
            }
            else if(this.rbPolygon.Checked)
            {
                if(shouldStartNewPolygon)
                {
                    Polygon poly = new Polygon();
                    SelectedPrim = (IPrimitive)poly;
                    polygons.Add(poly);
                    shouldStartNewPolygon = false;
                }
                polygons[polygons.Count - 1].Points.Add(p); // добавить точку
            }
            Redraw();
        }
        private void Redraw()
        {
            g.Clear(Color.White);
            if(!shouldStartNewLine)
            {
                LineFirstPoint.Draw(g, false);
            }
            this.points.ForEach((p) => p.Draw(g, p == SelectedPrimitive));
            this.lines.ForEach((p) => p.Draw(g, p == SelectedPrimitive));
            this.polygons.ForEach((p) => p.Draw(g, p == SelectedPrimitive));
            pictureBox1.Invalidate();
        }

        private void button_create_new_polygon_Click(object sender, EventArgs e)
        {
            this.shouldStartNewPolygon = true;
        }

        private void button_find_crossing_lines_Click(object sender, EventArgs e)
        {
            if(this.lines.Count < 2)
            {
                MessageBox.Show("Добавьте 2 отрезка!");
            }
            else
            {
                Line line1 = this.priviosLine;
                Line line2 = this.lastLine; // последняя линия
                if(line1 == null && line2== null)
                {
                    MessageBox.Show("Выберите 2 отрезка!");
                }
                else
                {
                    FindCrossingTwoLines(line1, line2);
                }

            }

        }
        private (float,float,float) GetCoefficentOfLine(Line line)
        {
            float X = line.A.Y - line.B.Y;
            float Y = line.B.X = line.A.X;
            float Z = line.A.X * line.B.Y - line.B.X * line.A.Y;
            var result = ( X, Y, Z );
            return result;
        }
        private PointApp FindTwoPoint(float X1, float Y1, float X2, float Y2, float Z1, float Z2)
        {
            float x, y;
            var denom = X1 * Y2 - Y1 * X2;
            x = -1 * (Z1 * Y2 - Z2 * Y1) / denom;
            y = -1 * (X1 * Z2 - X2 * Z1) / denom;
            return new PointApp(x, y);
        }
        private void FindCrossingTwoLines(Line l1, Line l2)
        {
           float A1, B1, C1, A2, B2, C2;
           var res_coef_1 = GetCoefficentOfLine(l1);
           A1 = res_coef_1.Item1;
           B1 = res_coef_1.Item2;
           C1 = res_coef_1.Item3;
           var res_coef_2 = GetCoefficentOfLine(l2);
            A2 = res_coef_2.Item1;
            B2 = res_coef_2.Item2;
            C2 = res_coef_2.Item3;
            var p = FindTwoPoint(A1, A2, B1, B2, C1, C2);
            if ((p.X >= Math.Min(l1.A.X, l1.B.X)) && (p.X <= Math.Max(l1.A.X, l1.B.X)) &&
                 (p.X >= Math.Min(l2.A.X, l2.B.X)) && (p.X <= Math.Max(l2.A.X, l2.B.X)) &&
                 (p.Y >= Math.Min(l1.A.Y, l1.B.Y)) && (p.Y <= Math.Max(l1.A.Y, l1.B.Y)) &&
                 (p.Y >= Math.Min(l2.A.Y, l2.B.Y)) && (p.Y <= Math.Max(l2.A.Y, l2.B.Y)))
            {
                g.FillEllipse(new SolidBrush(Color.Yellow), p.X - 3, p.Y - 3, 6, 6);
                pictureBox1.Refresh();
            }
            else
            {
                MessageBox.Show("Нет общей точки");
            }
        }



        //TODO tasks//
    }
}
