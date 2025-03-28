using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FastReports.Shapes;

namespace FastReports.Model
{
    class TriangleShape : BaseShape
    {
        public PointF pointA;
        public PointF pointB;
        public PointF pointC;

        private Rectangle _rectangle;
        public Rectangle Rectangle
        {
            get { return _rectangle; }
            set { _rectangle = value; }
        }

        private int _sideLength;
        public int SideLength
        {
            get { return _sideLength; }
            set { _sideLength = value; }
        }

        private double _angleInDegrees;
        public double AngleInDegrees
        {
            get { return _angleInDegrees; }
            set { _angleInDegrees = value; }
        }

        private PointF[] _points;
        public PointF[] Points 
        { 
            get { return _points; }
            set { _points = value; }
        }

        public TriangleShape() 
        {
            _points = [pointA, pointB, pointC];
            Name = "Треугольник";
        }

        public override void Draw(Graphics graphics, Color fillColor, Color borderColor, int borderWidth, int pointWidth, int pointHeight)
        {
            Pen pen = new Pen(borderColor, borderWidth);
            SolidBrush brush = new SolidBrush(fillColor);

            _sideLength = Math.Min(_rectangle.Width, _rectangle.Height);

            Point centerPoint = new Point(_rectangle.X + _rectangle.Width / 2, _rectangle.Y + _rectangle.Height / 2);

            double _angleInRadians = Math.PI * _angleInDegrees / 180;

            pointA = CalculateVertex(centerPoint, _sideLength, _angleInRadians + Math.PI / 2);
            pointB = CalculateVertex(centerPoint, _sideLength, _angleInRadians - Math.PI / 6);
            pointC = CalculateVertex(centerPoint, _sideLength, _angleInRadians + 5 * Math.PI / 6);

            graphics.DrawPolygon(pen, _points);
            graphics.FillPolygon(brush, _points);
        }

        private PointF CalculateVertex(Point center, int radius, double angle)
        {
            return new PointF(
                (float)(center.X + radius * Math.Cos(angle)),
                (float)(center.Y + radius * Math.Sin(angle))
                );
        }

        public override bool IsPointInShape(Point point)
        {
            bool b1, b2, b3;

            b1 = Sign(point, pointA, pointB) < 0.0f;
            b2 = Sign(point, pointB, pointC) < 0.0f;
            b3 = Sign(point, pointC, pointA) < 0.0f;

            return ((b1 == b2) && (b2 == b3));
        }

        private float Sign(PointF p1, PointF p2, PointF p3)
        {
            return (p1.X - p3.X) * (p2.Y - p3.Y) - (p2.X - p3.X) * (p1.Y - p3.Y);
        }
    }
}
