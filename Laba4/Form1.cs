﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Laba4.Primitives;
using System.Globalization;

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
            float x = line.A.Y - line.B.Y;
            float y = line.B.X - line.A.X;
            float z = line.A.X * line.B.Y - line.B.X * line.A.Y;
            return (x, y, z);
        }
        private PointApp FindTwoPoint(float X1, float X2, float Y1, float Y2, float Z1, float Z2)
        {
            float x, y;
            var denom = X1 * Y2 - Y1 * X2;
            x = -1 * (Z1 * Y2 - Z2 * Y1) / denom;
            y = -1 * (X1 * Z2 - X2 * Z1) / denom;
            return (new PointApp(x, y));
        }
        private void FindCrossingTwoLines(Line l1, Line l2)
        {
           float A1, B1, C1, A2, B2, C2;
           (A1,B1,C1) = GetCoefficentOfLine((Line)l1);
           (A2,B2,C2) = GetCoefficentOfLine((Line)l2);
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


















        private void afin_submit_Click(object sender, EventArgs e){
            if (this.SelectedPrim == null){
                MessageBox.Show("Выберите фигуру!");
                return;
            }

            Transform t = new Transform(SelectedPrim);

            t.Move(int.Parse(move_x_input.Text), int.Parse(move_y_input.Text));
            t.Scale(float.Parse(scale_x_input.Text, CultureInfo.InvariantCulture), float.Parse(scale_y_input.Text, CultureInfo.InvariantCulture));
            t.Rotate(float.Parse(rotate_input.Text, CultureInfo.InvariantCulture));

            if (SelectedPrim is PointApp){
                points.Remove((PointApp)SelectedPrim);
                PointApp p = t.points[0];
                points.Add(p);
                SelectedPrim = p;
            }

            if (SelectedPrim is Line){
                lines.Remove((Line)SelectedPrim);
                Line l = new Line(t.points[0], t.points[1]);
                lines.Add(l);
                SelectedPrim = l;
            }

            if (SelectedPrim is Polygon){
                polygons.Remove((Polygon)SelectedPrim);
                Polygon poly = new Polygon(t.points);
                polygons.Add(poly);
                SelectedPrim = poly;
            }
            Redraw();
        }





        class Transform{
            public List<PointApp> points;

            public Transform(IPrimitive p){
                points = new List<PointApp>();

                if (p is Line){
                    Line l = (Line)p;
                    points.Add(l.A);
                    points.Add(l.B);
                }
                else if (p is PointApp)
                {
                    PointApp pa = (PointApp)p;
                    points.Add(pa);
                }
                else if (p is Polygon)
                {
                    Polygon pl = (Polygon)p;
                    foreach (PointApp point in pl.Points){
                        points.Add(point);
                    }
                }
            }

            public void Move(int dx, int dy){
                List<PointApp> MoveList = new List<PointApp>();
                int[] MoveMatrix = new int[9] { 1, 0, 0, 
                                                0, 1, 0, 
                                                dx, dy, 1 };
                
                foreach(PointApp point in points){
                    float[] point_matrix = new float[3] { point.X, point.Y, 1 };
                    float[] res_point = new float[2];

                    for(int i = 0; i < 2; i += 1){
                        for (int j = 0; j < 3; j += 1){
                            res_point[i] += point_matrix[j] * MoveMatrix[i + j * 3];
                        }
                    }

                    MoveList.Add(new PointApp(res_point[0], res_point[1]));
                }

                points = MoveList;
            }


            public void Rotate(float alpha){
                alpha = (float)((Math.PI * alpha) / 180);
                float[] center = new float[3];
                List<PointApp> RotateList = new List<PointApp>();

                foreach (PointApp point in points){
                    center[0] += point.X;
                    center[1] += point.Y;
                }
                center[0] /= points.Count();
                center[1] /= points.Count();
                center[2] = 0;

                float[] RotateMatrix = new float[9] { (float)Math.Cos(alpha),         (float)Math.Sin(alpha),    0,
                                                      (float)Math.Sin(alpha) * -1,    (float)Math.Cos(alpha),    0,
                                                      center[0],                      center[1],                 1 };



                foreach (PointApp point in points)
                {
                    float[] point_matrix = new float[3] { point.X, point.Y, 1 };
                    float[] res_point = new float[2];

                    for (int i = 0; i < 2; i += 1){
                        for (int j = 0; j < 3; j += 1){
                            res_point[i] += (point_matrix[j] - center[j]) * RotateMatrix[i + j * 3];
                        }
                    }

                    RotateList.Add(new PointApp(res_point[0], res_point[1]));
                }

                points = RotateList;
            }

            public void Scale(float sx, float sy){
                List<PointApp> ScaleList = new List<PointApp>();
                float[] center = new float[3];
                foreach (PointApp point in points)
                {
                    center[0] += point.X;
                    center[1] += point.Y;
                }
                center[0] /= points.Count();
                center[1] /= points.Count();
                center[2] = 0;

                float[] ScaleMatrix = new float[9] { sx,         0,          0,
                                                     0,          sy,         0,
                                                     center[0],  center[1],  1 };

                foreach (PointApp point in points){
                    float[] point_matrix = new float[3] { point.X, point.Y, 1 };
                    float[] res_point = new float[2];

                    for (int i = 0; i < 2; i += 1){
                        for (int j = 0; j < 3; j += 1){
                            res_point[i] += (point_matrix[j] - center[j]) * ScaleMatrix[i + j * 3];
                        }
                    }

                    ScaleList.Add(new PointApp(res_point[0], res_point[1]));
                }

                points = ScaleList;
            }
        }
    }    
}


