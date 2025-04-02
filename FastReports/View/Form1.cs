using FastReports.Model;
using FastReports.Shapes;

namespace FastReports
{
    public partial class FormFastReports : Form
    {
        private BaseShape _shape;
        private RectangleShape _rectangle;
        private CircleShape _circle;
        private TriangleShape _triangle;
        private int x = 0;
        private int y = 0;
        private Color[] colors;
        private GroupBox[] groupBoxes;
        private BaseShape[] _shapes;
        public FormFastReports()
        {
            InitializeComponent();

            _rectangle = new RectangleShape();
            _circle = new CircleShape();
            _triangle = new TriangleShape();

            colors = [Color.Red, Color.Blue, Color.Green];
            groupBoxes = [groupBoxRectangle, groupBoxCircle, groupBoxTriangle];
            _shapes = [_rectangle, _circle, _triangle];

            ComboBoxAdd(comboBoxShapeType, _shapes);

            ComboBoxAdd(comboBoxBorderColor, colors);

            ComboBoxAdd(comboBoxFillColor, colors);

            groupBoxCircle.Location = new Point(12, 59);
            groupBoxTriangle.Location = new Point(12, 59);

        }


        private void ComboBoxAdd<T>(ComboBox comboBox, T[] array)
        {
            foreach (var item in array) { comboBox.Items.Add(item); }
        }


        private void comboBoxShapeType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBoxShapeType.SelectedItem != null)
            {
                groupBoxColors.Visible = true;
                groupBoxPoint.Visible = true;
                buttonDraw.Visible = true;

                GroupBoxVisibility();

                labelLog.Text = comboBoxShapeType.SelectedItem.ToString();
            }
            else labelLog.Text = "Фигура не была выбрана.";
        }

        private void GroupBoxVisibility()
        {
            int selectedIndex = comboBoxShapeType.SelectedIndex;

            foreach (var box in groupBoxes)
            {
                box.Visible = false;
            }

            if (selectedIndex >= 0 && selectedIndex < groupBoxes.Length)
            {
                groupBoxes[selectedIndex].Visible = true;
            }
        }



        private void buttonDraw_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            pictureBox1.Update();

            _shape = (BaseShape)comboBoxShapeType.SelectedItem;

            if (comboBoxShapeType.SelectedItem != null)
            {
                switch (comboBoxShapeType.SelectedIndex)
                {
                    case 0:
                        _rectangle.Height = Convert.ToInt32(textBoxHeight.Text);
                        _rectangle.Width = Convert.ToInt32(textBoxWidth.Text);
                        break;
                    case 1:
                        _circle.Radius = Convert.ToInt32(textBoxRadius.Text);
                        break;
                    case 2:
                        _triangle.Position = new PointF(pictureBox1.Width/2,pictureBox1.Height/2);
                        _triangle.SideLength = Convert.ToInt32(textBoxSideLength.Text);
                        break;
                    default:
                        break;
                }

                _shape.Draw(pictureBox1.CreateGraphics(),
                    (Color)comboBoxFillColor.SelectedItem,
                    (Color)comboBoxBorderColor.SelectedItem,
                    Convert.ToInt32(textBoxBorderWidth.Text), pictureBox1.Width, pictureBox1.Height);
            }
        }


        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point pos = new Point(Cursor.Position.X - x, Cursor.Position.Y - y);
                pictureBox1.Location = PointToClient(pos);
            }
        }

        private void buttonIsPointInShape_Click(object sender, EventArgs e)
        {
            labelYesNo.Text = Convert.ToString(_shape.IsPointInShape(new Point(int.Parse(textBoxPointX.Text), int.Parse(textBoxPointY.Text))));
        }
    }
}
