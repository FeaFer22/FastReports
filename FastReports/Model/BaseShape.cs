namespace FastReports.Shapes
{
    abstract class BaseShape
    {
        public string Name { get; protected set; }
        public Color FillColor { get; protected set; }
        public Color BorderColor { get; protected set; }
        public int BorderWidth { get; protected set; }

        public override string ToString()
        {
            return Name;
        }

        public abstract void Draw(Graphics graphics, Color fillColor, Color borderColor, int borderWidth);
        public abstract void IsPointInShape();
    }
}
