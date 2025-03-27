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

        public CircleShape()
        {
            Name = "Круг";
        }


        public override void Draw(Graphics graphics, Color fillColor, Color borderColor, int borderWidth)
        {
            Pen pen = new Pen(borderColor, borderWidth);
            SolidBrush brush = new SolidBrush(fillColor);
            Rectangle circle = new Rectangle(250, 250, this.Radius, this.Radius);
            graphics.DrawEllipse(pen, circle);
            graphics.FillEllipse(brush, circle);
        }

        public override void IsPointInShape()
        {
            throw new NotImplementedException();
        }
    }
}
