
using System.Drawing;
using System.Reflection.Metadata.Ecma335;
using FastReports.Model;
using FastReports.Shapes;

namespace FastReports
{
    public partial class FormFastReports : Form
    {
        private BaseShape _shape;
        private RectangleShape _rectangle;
        private CircleShape _circle;
        private int x = 0;
        private int y = 0;
        public FormFastReports()
        {
            InitializeComponent();

            _rectangle = new RectangleShape();
            _circle = new CircleShape();

            comboBoxShapeType.Items.Add(_rectangle);
            comboBoxShapeType.Items.Add(_circle);

            comboBoxBorderColor.Items.Add(Color.Red);
            comboBoxBorderColor.Items.Add(Color.Green);
            comboBoxBorderColor.Items.Add(Color.Blue);

            comboBoxFillColor.Items.Add(Color.Red);
            comboBoxFillColor.Items.Add(Color.Green);
            comboBoxFillColor.Items.Add(Color.Blue);

            groupBoxCircle.Location = new Point(12, 59);

        }


        private void comboBoxShapeType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBoxShapeType.SelectedItem != null)
            {
                groupBoxColors.Visible = true;

                switch (comboBoxShapeType.SelectedItem.ToString())
                {
                    case "Прямоугольник":
                        groupBoxCircle.Visible = true;
                        groupBoxRectangle.Visible = true;
                        break;
                    case "Круг":
                        groupBoxRectangle.Visible = false;
                        groupBoxCircle.Visible = true;
                        break;
                    default:
                        break;
                }

                labelLog.Text = comboBoxShapeType.SelectedItem.ToString();
            }
            else labelLog.Text = "Фигура не была выбрана.";
        }



        private void buttonDraw_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            pictureBox1.Update();

            _shape = (BaseShape)comboBoxShapeType.SelectedItem;

            if (comboBoxShapeType.SelectedItem != null)
            {
                switch (comboBoxShapeType.SelectedItem.ToString())
                {
                    case "Прямоугольник":
                        _rectangle.Height = Convert.ToInt32(textBoxHeight.Text);
                        _rectangle.Width = Convert.ToInt32(textBoxWidth.Text);
                        break;
                    case "Круг":
                        _circle.Radius = Convert.ToInt32(textBoxRadius.Text);
                        break;
                    case "Треугольник":
                        break;
                    default:
                        break;
                }
                _shape.Draw(pictureBox1.CreateGraphics(),
                    (Color)comboBoxFillColor.SelectedItem,
                    (Color)comboBoxBorderColor.SelectedItem,
                    Convert.ToInt32(textBoxBorderWidth.Text));
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

    }
}
