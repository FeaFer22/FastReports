using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastReports.Shapes
{
    class RectangleShape : BaseShape
    {

        public int Height { get; set; }
        public int Width { get; set; }
        Rectangle rectangle;

        public RectangleShape() 
        {
            Name = "Прямоугольник";
        }


        public override void Draw(Graphics graphics, Color fillColor, Color borderColor, int borderWidth, int pointWidth, int pointHeight)
        {
            Pen pen = new Pen(borderColor, borderWidth);
            SolidBrush brush = new SolidBrush(fillColor);
            rectangle = new Rectangle(pointWidth/2, pointHeight/2, this.Width, this.Height);
            graphics.DrawRectangle(pen, rectangle);
            graphics.FillRectangle(brush, rectangle);
        }

        public override bool IsPointInShape(Point point)
        {
            return point.X >= rectangle.Left && point.X <= rectangle.Right &&
           point.Y >= rectangle.Top && point.Y <= rectangle.Bottom;
        }
    }
}
