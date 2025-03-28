using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using FastReports.Shapes;

namespace FastReports.Model
{
    class CircleShape : BaseShape
    {
        public int Radius { get; set; }
        private Rectangle circle;
        public CircleShape()
        {
            Name = "Круг";
        }


        public override void Draw(Graphics graphics, Color fillColor, Color borderColor, int borderWidth, int pointWidth, int pointHeight)
        {
            Pen pen = new Pen(borderColor, borderWidth);
            SolidBrush brush = new SolidBrush(fillColor);
            circle = new Rectangle(pointWidth/2, pointHeight/2, this.Radius, this.Radius);
            graphics.DrawEllipse(pen, circle);
            graphics.FillEllipse(brush, circle);
        }

        public override bool IsPointInShape(Point point)
        {
            Point centerPoint = new Point(circle.X - circle.Width / 2, circle.Height / 2 - circle.Y);
            float dx = point.X - centerPoint.X;
            float dy = point.Y - centerPoint.Y;
            float distanceSquared = dx * dx + dy * dy;

            return distanceSquared <= this.Radius * this.Radius;
        }
    }
}
