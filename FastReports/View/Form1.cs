
using System;
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
        private TriangleShape _triangle;
        private int x = 0;
        private int y = 0;
        public FormFastReports()
        {
            InitializeComponent();

            _rectangle = new RectangleShape();
            _circle = new CircleShape();
            _triangle = new TriangleShape();

            comboBoxShapeType.Items.Add(_rectangle);
            comboBoxShapeType.Items.Add(_circle);
            comboBoxShapeType.Items.Add(_triangle);

            comboBoxBorderColor.Items.Add(Color.Red);
            comboBoxBorderColor.Items.Add(Color.Green);
            comboBoxBorderColor.Items.Add(Color.Blue);

            comboBoxFillColor.Items.Add(Color.Red);
            comboBoxFillColor.Items.Add(Color.Green);
            comboBoxFillColor.Items.Add(Color.Blue);

            groupBoxCircle.Location = new Point(12, 59);
            groupBoxTriangle.Location = new Point(12, 59);

        }


        private void comboBoxShapeType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBoxShapeType.SelectedItem != null)
            {
                groupBoxColors.Visible = true;
                groupBoxPoint.Visible = true;
                buttonDraw.Visible = true;

                switch (comboBoxShapeType.SelectedIndex)
                {
                    case 0:
                        groupBoxCircle.Visible = false;
                        groupBoxRectangle.Visible = true;
                        groupBoxTriangle.Visible = false;
                        break;
                    case 1:
                        groupBoxRectangle.Visible = false;
                        groupBoxTriangle.Visible = false;
                        groupBoxCircle.Visible = true;
                        break;
                    case 2:
                        groupBoxRectangle.Visible = false;
                        groupBoxTriangle.Visible = true;
                        groupBoxCircle.Visible = false;
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
