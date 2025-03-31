using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using FastReports.Shapes;

namespace FastReports.Model
{
    class TriangleShape : BaseShape
    {
        private PointF _position;
        public PointF Position
        {
            get { return _position; }
            set { _position = value; }
        }

        private int _sideLength;
        public int SideLength
        {
            get { return _sideLength; }
            set { _sideLength = value; }
        }

        private double _angleInDegrees = 60;

        private PointF[] _points;
        public PointF[] Points 
        { 
            get { return _points; }
            set { _points = value; }
        }

        public TriangleShape() 
        {
            _points = new PointF[3];
            Position = _position;
            Name = "Треугольник";
        }

        public override void Draw(Graphics graphics, Color fillColor, Color borderColor, int borderWidth, int pointWidth, int pointHeight)
        {
            Pen pen = new Pen(borderColor, borderWidth);
            SolidBrush brush = new SolidBrush(fillColor);



            _points[0] = new PointF(_position.X, _position.Y);
            _points[1] = new PointF(_position.X + _sideLength, _position.Y);
            _points[2] = new PointF(_position.X + _sideLength / 2, _position.Y - (int)(_sideLength * Math.Sqrt(3) / 2));

            graphics.DrawPolygon(pen, _points);
            graphics.FillPolygon(brush, _points);
        }

        public override bool IsPointInShape(Point point)
        {
            bool b1, b2, b3;

            b1 = Sign(point, _points[0], _points[1]) < 0.0f;
            b2 = Sign(point, _points[1], _points[2]) < 0.0f;
            b3 = Sign(point, _points[2], _points[0]) < 0.0f;

            return ((b1 == b2) && (b2 == b3));
        }

        private float Sign(PointF p1, PointF p2, PointF p3)
        {
            return (p1.X - p3.X) * (p2.Y - p3.Y) - (p2.X - p3.X) * (p1.Y - p3.Y);
        }
    }
}
