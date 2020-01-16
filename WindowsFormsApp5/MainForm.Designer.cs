namespace Figures
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.PictureBoxField = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.PictureBoxColorField = new System.Windows.Forms.PictureBox();
            this.ButtonColorFiled = new System.Windows.Forms.Button();
            this.ButtonClearField = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ButtonAddFigure = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.NumericUpDownCompressedLevel = new System.Windows.Forms.NumericUpDown();
            this.NumericUpDownradiusCircle = new System.Windows.Forms.NumericUpDown();
            this.IsPolygonCircle = new System.Windows.Forms.RadioButton();
            this.IsPolygon5 = new System.Windows.Forms.RadioButton();
            this.IsPolygon4 = new System.Windows.Forms.RadioButton();
            this.IsPolygon3 = new System.Windows.Forms.RadioButton();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.TextBoxPointsFigure = new System.Windows.Forms.TextBox();
            this.ListBoxFigures = new System.Windows.Forms.ListBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.ButtonFigureColorBody = new System.Windows.Forms.Button();
            this.PictureBoxFigureColorBody = new System.Windows.Forms.PictureBox();
            this.IsInPolygon4 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxField)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxColorField)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownCompressedLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownradiusCircle)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxFigureColorBody)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBoxField
            // 
            this.PictureBoxField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBoxField.Location = new System.Drawing.Point(6, 77);
            this.PictureBoxField.Name = "PictureBoxField";
            this.PictureBoxField.Size = new System.Drawing.Size(909, 519);
            this.PictureBoxField.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxField.TabIndex = 0;
            this.PictureBoxField.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.PictureBoxField);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(921, 602);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поле";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.PictureBoxColorField);
            this.groupBox3.Controls.Add(this.ButtonColorFiled);
            this.groupBox3.Controls.Add(this.ButtonClearField);
            this.groupBox3.Location = new System.Drawing.Point(6, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(909, 52);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Настройки";
            // 
            // PictureBoxColorField
            // 
            this.PictureBoxColorField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBoxColorField.BackColor = System.Drawing.Color.GreenYellow;
            this.PictureBoxColorField.Location = new System.Drawing.Point(878, 19);
            this.PictureBoxColorField.Name = "PictureBoxColorField";
            this.PictureBoxColorField.Size = new System.Drawing.Size(20, 23);
            this.PictureBoxColorField.TabIndex = 2;
            this.PictureBoxColorField.TabStop = false;
            // 
            // ButtonColorFiled
            // 
            this.ButtonColorFiled.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonColorFiled.BackColor = System.Drawing.Color.DimGray;
            this.ButtonColorFiled.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonColorFiled.Location = new System.Drawing.Point(764, 19);
            this.ButtonColorFiled.Name = "ButtonColorFiled";
            this.ButtonColorFiled.Size = new System.Drawing.Size(108, 23);
            this.ButtonColorFiled.TabIndex = 1;
            this.ButtonColorFiled.Text = "Цвет поля";
            this.ButtonColorFiled.UseVisualStyleBackColor = false;
            this.ButtonColorFiled.Click += new System.EventHandler(this.ButtonColorFiled_Click);
            // 
            // ButtonClearField
            // 
            this.ButtonClearField.BackColor = System.Drawing.Color.DimGray;
            this.ButtonClearField.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonClearField.Location = new System.Drawing.Point(6, 19);
            this.ButtonClearField.Name = "ButtonClearField";
            this.ButtonClearField.Size = new System.Drawing.Size(134, 23);
            this.ButtonClearField.TabIndex = 0;
            this.ButtonClearField.Text = "Очистить поле";
            this.ButtonClearField.UseVisualStyleBackColor = false;
            this.ButtonClearField.Click += new System.EventHandler(this.ButtonClearField_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.ButtonAddFigure);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Location = new System.Drawing.Point(939, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(293, 602);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Конструктор фигуры";
            // 
            // ButtonAddFigure
            // 
            this.ButtonAddFigure.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonAddFigure.BackColor = System.Drawing.Color.DimGray;
            this.ButtonAddFigure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddFigure.Location = new System.Drawing.Point(6, 19);
            this.ButtonAddFigure.Name = "ButtonAddFigure";
            this.ButtonAddFigure.Size = new System.Drawing.Size(281, 23);
            this.ButtonAddFigure.TabIndex = 1;
            this.ButtonAddFigure.Text = "Переместить на поле";
            this.ButtonAddFigure.UseVisualStyleBackColor = false;
            this.ButtonAddFigure.Click += new System.EventHandler(this.ButtonAddFigure_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.groupBox8);
            this.groupBox4.Controls.Add(this.ListBoxFigures);
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Location = new System.Drawing.Point(6, 48);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(281, 548);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Настройки";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.NumericUpDownCompressedLevel);
            this.groupBox5.Controls.Add(this.NumericUpDownradiusCircle);
            this.groupBox5.Controls.Add(this.IsPolygonCircle);
            this.groupBox5.Controls.Add(this.IsInPolygon4);
            this.groupBox5.Controls.Add(this.IsPolygon5);
            this.groupBox5.Controls.Add(this.IsPolygon4);
            this.groupBox5.Controls.Add(this.IsPolygon3);
            this.groupBox5.Location = new System.Drawing.Point(6, 147);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(269, 148);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Шаблоны";
            // 
            // NumericUpDownCompressedLevel
            // 
            this.NumericUpDownCompressedLevel.Location = new System.Drawing.Point(216, 112);
            this.NumericUpDownCompressedLevel.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.NumericUpDownCompressedLevel.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumericUpDownCompressedLevel.Name = "NumericUpDownCompressedLevel";
            this.NumericUpDownCompressedLevel.Size = new System.Drawing.Size(46, 20);
            this.NumericUpDownCompressedLevel.TabIndex = 1;
            this.NumericUpDownCompressedLevel.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumericUpDownCompressedLevel.ValueChanged += new System.EventHandler(this.NumericUpDownCompressedLevel_ValueChanged);
            // 
            // NumericUpDownradiusCircle
            // 
            this.NumericUpDownradiusCircle.Location = new System.Drawing.Point(162, 112);
            this.NumericUpDownradiusCircle.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NumericUpDownradiusCircle.Name = "NumericUpDownradiusCircle";
            this.NumericUpDownradiusCircle.Size = new System.Drawing.Size(48, 20);
            this.NumericUpDownradiusCircle.TabIndex = 1;
            this.NumericUpDownradiusCircle.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NumericUpDownradiusCircle.ValueChanged += new System.EventHandler(this.NumericUpDownradiusCircle_ValueChanged);
            // 
            // IsPolygonCircle
            // 
            this.IsPolygonCircle.AutoSize = true;
            this.IsPolygonCircle.Location = new System.Drawing.Point(7, 112);
            this.IsPolygonCircle.Name = "IsPolygonCircle";
            this.IsPolygonCircle.Size = new System.Drawing.Size(156, 17);
            this.IsPolygonCircle.TabIndex = 0;
            this.IsPolygonCircle.TabStop = true;
            this.IsPolygonCircle.Text = "Круг (по радиусу/сжатию)";
            this.IsPolygonCircle.UseVisualStyleBackColor = true;
            this.IsPolygonCircle.CheckedChanged += new System.EventHandler(this.IsPolygonCircle_CheckedChanged);
            // 
            // IsPolygon5
            // 
            this.IsPolygon5.AutoSize = true;
            this.IsPolygon5.Location = new System.Drawing.Point(7, 66);
            this.IsPolygon5.Name = "IsPolygon5";
            this.IsPolygon5.Size = new System.Drawing.Size(96, 17);
            this.IsPolygon5.TabIndex = 0;
            this.IsPolygon5.TabStop = true;
            this.IsPolygon5.Text = "Пятиугольник";
            this.IsPolygon5.UseVisualStyleBackColor = true;
            this.IsPolygon5.CheckedChanged += new System.EventHandler(this.IsPolygon5_CheckedChanged);
            // 
            // IsPolygon4
            // 
            this.IsPolygon4.AutoSize = true;
            this.IsPolygon4.Location = new System.Drawing.Point(7, 43);
            this.IsPolygon4.Name = "IsPolygon4";
            this.IsPolygon4.Size = new System.Drawing.Size(115, 17);
            this.IsPolygon4.TabIndex = 0;
            this.IsPolygon4.TabStop = true;
            this.IsPolygon4.Text = "Четырехугольник";
            this.IsPolygon4.UseVisualStyleBackColor = true;
            this.IsPolygon4.CheckedChanged += new System.EventHandler(this.IsPolygon4_CheckedChanged);
            // 
            // IsPolygon3
            // 
            this.IsPolygon3.AutoSize = true;
            this.IsPolygon3.Location = new System.Drawing.Point(7, 20);
            this.IsPolygon3.Name = "IsPolygon3";
            this.IsPolygon3.Size = new System.Drawing.Size(90, 17);
            this.IsPolygon3.TabIndex = 0;
            this.IsPolygon3.TabStop = true;
            this.IsPolygon3.Text = "Треугольник";
            this.IsPolygon3.UseVisualStyleBackColor = true;
            this.IsPolygon3.CheckedChanged += new System.EventHandler(this.IsPolygon3_CheckedChanged);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.TextBoxPointsFigure);
            this.groupBox8.Location = new System.Drawing.Point(6, 301);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(269, 52);
            this.groupBox8.TabIndex = 8;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Точки (x,y)...";
            // 
            // TextBoxPointsFigure
            // 
            this.TextBoxPointsFigure.Location = new System.Drawing.Point(6, 19);
            this.TextBoxPointsFigure.Name = "TextBoxPointsFigure";
            this.TextBoxPointsFigure.Size = new System.Drawing.Size(257, 20);
            this.TextBoxPointsFigure.TabIndex = 0;
            this.TextBoxPointsFigure.Text = "100,0;150,50;100,150;0,100";
            // 
            // ListBoxFigures
            // 
            this.ListBoxFigures.FormattingEnabled = true;
            this.ListBoxFigures.Location = new System.Drawing.Point(6, 24);
            this.ListBoxFigures.Name = "ListBoxFigures";
            this.ListBoxFigures.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.ListBoxFigures.Size = new System.Drawing.Size(269, 56);
            this.ListBoxFigures.TabIndex = 7;
            this.ListBoxFigures.SelectedIndexChanged += new System.EventHandler(this.ListBoxFigures_SelectedIndexChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.ButtonFigureColorBody);
            this.groupBox6.Controls.Add(this.PictureBoxFigureColorBody);
            this.groupBox6.Location = new System.Drawing.Point(6, 85);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(269, 56);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Тело";
            // 
            // ButtonFigureColorBody
            // 
            this.ButtonFigureColorBody.BackColor = System.Drawing.Color.DimGray;
            this.ButtonFigureColorBody.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonFigureColorBody.Location = new System.Drawing.Point(6, 19);
            this.ButtonFigureColorBody.Name = "ButtonFigureColorBody";
            this.ButtonFigureColorBody.Size = new System.Drawing.Size(108, 23);
            this.ButtonFigureColorBody.TabIndex = 1;
            this.ButtonFigureColorBody.Text = "Цвет тела";
            this.ButtonFigureColorBody.UseVisualStyleBackColor = false;
            this.ButtonFigureColorBody.Click += new System.EventHandler(this.ButtonFigureColorBody_Click);
            // 
            // PictureBoxFigureColorBody
            // 
            this.PictureBoxFigureColorBody.BackColor = System.Drawing.Color.DarkGreen;
            this.PictureBoxFigureColorBody.Location = new System.Drawing.Point(120, 19);
            this.PictureBoxFigureColorBody.Name = "PictureBoxFigureColorBody";
            this.PictureBoxFigureColorBody.Size = new System.Drawing.Size(143, 23);
            this.PictureBoxFigureColorBody.TabIndex = 2;
            this.PictureBoxFigureColorBody.TabStop = false;
            // 
            // IsInPolygon4
            // 
            this.IsInPolygon4.AutoSize = true;
            this.IsInPolygon4.Location = new System.Drawing.Point(7, 89);
            this.IsInPolygon4.Name = "IsInPolygon4";
            this.IsInPolygon4.Size = new System.Drawing.Size(159, 17);
            this.IsInPolygon4.TabIndex = 0;
            this.IsInPolygon4.TabStop = true;
            this.IsInPolygon4.Text = "Впуклый четырехугольник";
            this.IsInPolygon4.UseVisualStyleBackColor = true;
            this.IsInPolygon4.CheckedChanged += new System.EventHandler(this.IsInPolygon4_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(1244, 641);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(1260, 680);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Фигуры";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxField)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxColorField)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownCompressedLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownradiusCircle)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxFigureColorBody)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBoxField;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ButtonAddFigure;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.NumericUpDown NumericUpDownCompressedLevel;
        private System.Windows.Forms.NumericUpDown NumericUpDownradiusCircle;
        private System.Windows.Forms.RadioButton IsPolygonCircle;
        private System.Windows.Forms.RadioButton IsPolygon5;
        private System.Windows.Forms.RadioButton IsPolygon4;
        private System.Windows.Forms.RadioButton IsPolygon3;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox TextBoxPointsFigure;
        private System.Windows.Forms.ListBox ListBoxFigures;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button ButtonFigureColorBody;
        private System.Windows.Forms.PictureBox PictureBoxFigureColorBody;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox PictureBoxColorField;
        private System.Windows.Forms.Button ButtonColorFiled;
        private System.Windows.Forms.Button ButtonClearField;
        private System.Windows.Forms.RadioButton IsInPolygon4;
    }
}

