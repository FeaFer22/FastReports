using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastReports.Shapes
{
    class RectangleShape : BaseShape
    {

        public int Height { get; set; }
        public int Width { get; set; }

        public RectangleShape() 
        {
            Name = "Прямоугольник";
        }


        public override void Draw(Graphics graphics, Color fillColor, Color borderColor, int borderWidth)
        {
            Pen pen = new Pen(borderColor, borderWidth);
            SolidBrush brush = new SolidBrush(fillColor);
            Rectangle rectangle = new Rectangle(250,250, this.Width, this.Height);
            graphics.DrawRectangle(pen, rectangle);
            graphics.FillRectangle(brush, rectangle);
        }

        public override void IsPointInShape()
        {
            throw new NotImplementedException();
        }
    }
}
