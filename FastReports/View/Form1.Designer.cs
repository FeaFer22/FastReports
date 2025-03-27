
namespace FastReports
{
    partial class FormFastReports
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxCircle = new GroupBox();
            textBoxRadius = new TextBox();
            labelRadius = new Label();
            pictureBox1 = new PictureBox();
            buttonDraw = new Button();
            labelShapeSelector = new Label();
            comboBoxShapeType = new ComboBox();
            labelLog = new Label();
            labelHeight = new Label();
            textBoxWidth = new TextBox();
            labelWidth = new Label();
            textBoxHeight = new TextBox();
            groupBoxRectangle = new GroupBox();
            label2 = new Label();
            groupBoxColors = new GroupBox();
            textBoxBorderWidth = new TextBox();
            labelBorderWidth = new Label();
            labelFillColor = new Label();
            comboBoxFillColor = new ComboBox();
            labelBorderColor = new Label();
            comboBoxBorderColor = new ComboBox();
            groupBoxCircle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBoxRectangle.SuspendLayout();
            groupBoxColors.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxCircle
            // 
            groupBoxCircle.Controls.Add(textBoxRadius);
            groupBoxCircle.Controls.Add(labelRadius);
            groupBoxCircle.Location = new Point(194, 251);
            groupBoxCircle.Name = "groupBoxCircle";
            groupBoxCircle.Size = new Size(226, 83);
            groupBoxCircle.TabIndex = 16;
            groupBoxCircle.TabStop = false;
            groupBoxCircle.Text = "Выберите радиус круга:";
            groupBoxCircle.Visible = false;
            // 
            // textBoxRadius
            // 
            textBoxRadius.Location = new Point(9, 49);
            textBoxRadius.Name = "textBoxRadius";
            textBoxRadius.Size = new Size(131, 23);
            textBoxRadius.TabIndex = 5;
            // 
            // labelRadius
            // 
            labelRadius.AutoSize = true;
            labelRadius.Location = new Point(9, 31);
            labelRadius.Name = "labelRadius";
            labelRadius.Size = new Size(48, 15);
            labelRadius.TabIndex = 11;
            labelRadius.Text = "Радиус:";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(259, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(736, 408);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            // 
            // buttonDraw
            // 
            buttonDraw.Location = new Point(12, 415);
            buttonDraw.Name = "buttonDraw";
            buttonDraw.Size = new Size(159, 23);
            buttonDraw.TabIndex = 1;
            buttonDraw.Text = "Нарисовать";
            buttonDraw.UseVisualStyleBackColor = true;
            buttonDraw.Click += buttonDraw_Click;
            // 
            // labelShapeSelector
            // 
            labelShapeSelector.AutoSize = true;
            labelShapeSelector.Location = new Point(12, 12);
            labelShapeSelector.Name = "labelShapeSelector";
            labelShapeSelector.Size = new Size(132, 15);
            labelShapeSelector.TabIndex = 3;
            labelShapeSelector.Text = "Выберите тип фигуры:";
            // 
            // comboBoxShapeType
            // 
            comboBoxShapeType.FormattingEnabled = true;
            comboBoxShapeType.Location = new Point(12, 30);
            comboBoxShapeType.Name = "comboBoxShapeType";
            comboBoxShapeType.Size = new Size(135, 23);
            comboBoxShapeType.TabIndex = 4;
            comboBoxShapeType.SelectionChangeCommitted += comboBoxShapeType_SelectionChangeCommitted;
            // 
            // labelLog
            // 
            labelLog.AutoSize = true;
            labelLog.Location = new Point(259, 12);
            labelLog.Name = "labelLog";
            labelLog.Size = new Size(16, 15);
            labelLog.TabIndex = 9;
            labelLog.Text = "...";
            // 
            // labelHeight
            // 
            labelHeight.AutoSize = true;
            labelHeight.Location = new Point(9, 31);
            labelHeight.Name = "labelHeight";
            labelHeight.Size = new Size(50, 15);
            labelHeight.TabIndex = 11;
            labelHeight.Text = "Высота:";
            // 
            // textBoxWidth
            // 
            textBoxWidth.Location = new Point(9, 93);
            textBoxWidth.Name = "textBoxWidth";
            textBoxWidth.Size = new Size(131, 23);
            textBoxWidth.TabIndex = 6;
            // 
            // labelWidth
            // 
            labelWidth.AutoSize = true;
            labelWidth.Location = new Point(9, 75);
            labelWidth.Name = "labelWidth";
            labelWidth.Size = new Size(55, 15);
            labelWidth.TabIndex = 12;
            labelWidth.Text = "Ширина:";
            // 
            // textBoxHeight
            // 
            textBoxHeight.Location = new Point(9, 49);
            textBoxHeight.Name = "textBoxHeight";
            textBoxHeight.Size = new Size(131, 23);
            textBoxHeight.TabIndex = 5;
            // 
            // groupBoxRectangle
            // 
            groupBoxRectangle.Controls.Add(textBoxWidth);
            groupBoxRectangle.Controls.Add(labelWidth);
            groupBoxRectangle.Controls.Add(textBoxHeight);
            groupBoxRectangle.Controls.Add(labelHeight);
            groupBoxRectangle.Location = new Point(12, 59);
            groupBoxRectangle.Name = "groupBoxRectangle";
            groupBoxRectangle.Size = new Size(227, 127);
            groupBoxRectangle.TabIndex = 14;
            groupBoxRectangle.TabStop = false;
            groupBoxRectangle.Text = "Выберите размеры прямоугольника:";
            groupBoxRectangle.Visible = false;
            // 
            // label2
            // 
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 0;
            // 
            // groupBoxColors
            // 
            groupBoxColors.Controls.Add(textBoxBorderWidth);
            groupBoxColors.Controls.Add(labelBorderWidth);
            groupBoxColors.Controls.Add(labelFillColor);
            groupBoxColors.Controls.Add(comboBoxFillColor);
            groupBoxColors.Controls.Add(labelBorderColor);
            groupBoxColors.Controls.Add(comboBoxBorderColor);
            groupBoxColors.Location = new Point(12, 192);
            groupBoxColors.Name = "groupBoxColors";
            groupBoxColors.Size = new Size(159, 185);
            groupBoxColors.TabIndex = 15;
            groupBoxColors.TabStop = false;
            groupBoxColors.Text = "Выберите цвета и ширину контура:";
            // 
            // textBoxBorderWidth
            // 
            textBoxBorderWidth.Location = new Point(6, 147);
            textBoxBorderWidth.Name = "textBoxBorderWidth";
            textBoxBorderWidth.Size = new Size(121, 23);
            textBoxBorderWidth.TabIndex = 6;
            // 
            // labelBorderWidth
            // 
            labelBorderWidth.AutoSize = true;
            labelBorderWidth.Location = new Point(6, 129);
            labelBorderWidth.Name = "labelBorderWidth";
            labelBorderWidth.Size = new Size(99, 15);
            labelBorderWidth.TabIndex = 5;
            labelBorderWidth.Text = "Ширина контура";
            // 
            // labelFillColor
            // 
            labelFillColor.AutoSize = true;
            labelFillColor.Location = new Point(6, 85);
            labelFillColor.Name = "labelFillColor";
            labelFillColor.Size = new Size(74, 15);
            labelFillColor.TabIndex = 3;
            labelFillColor.Text = "Заполнение";
            // 
            // comboBoxFillColor
            // 
            comboBoxFillColor.FormattingEnabled = true;
            comboBoxFillColor.Location = new Point(6, 103);
            comboBoxFillColor.Name = "comboBoxFillColor";
            comboBoxFillColor.Size = new Size(121, 23);
            comboBoxFillColor.TabIndex = 2;
            // 
            // labelBorderColor
            // 
            labelBorderColor.AutoSize = true;
            labelBorderColor.Location = new Point(6, 41);
            labelBorderColor.Name = "labelBorderColor";
            labelBorderColor.Size = new Size(46, 15);
            labelBorderColor.TabIndex = 1;
            labelBorderColor.Text = "Контур";
            // 
            // comboBoxBorderColor
            // 
            comboBoxBorderColor.FormattingEnabled = true;
            comboBoxBorderColor.Location = new Point(6, 59);
            comboBoxBorderColor.Name = "comboBoxBorderColor";
            comboBoxBorderColor.Size = new Size(121, 23);
            comboBoxBorderColor.TabIndex = 0;
            // 
            // FormFastReports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1007, 450);
            Controls.Add(groupBoxRectangle);
            Controls.Add(groupBoxColors);
            Controls.Add(labelLog);
            Controls.Add(comboBoxShapeType);
            Controls.Add(groupBoxCircle);
            Controls.Add(labelShapeSelector);
            Controls.Add(buttonDraw);
            Controls.Add(pictureBox1);
            Name = "FormFastReports";
            Text = "Fast Reports";
            groupBoxCircle.ResumeLayout(false);
            groupBoxCircle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBoxRectangle.ResumeLayout(false);
            groupBoxRectangle.PerformLayout();
            groupBoxColors.ResumeLayout(false);
            groupBoxColors.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private PictureBox pictureBox1;
        private Button buttonDraw;
        private Label labelShapeSelector;
        private ComboBox comboBoxShapeType;
        private Label labelLog;
        private Label labelHeight;
        private TextBox textBoxWidth;
        private Label labelWidth;
        private TextBox textBoxHeight;
        private GroupBox groupBoxRectangle;
        private Label label2;
        private GroupBox groupBoxColors;
        private Label labelBorderWidth;
        private Label labelFillColor;
        private ComboBox comboBoxFillColor;
        private Label labelBorderColor;
        private ComboBox comboBoxBorderColor;
        private TextBox textBoxBorderWidth;
        private GroupBox groupBoxCircle;
        private TextBox textBoxRadius;
        private Label labelRadius;
    }
}
