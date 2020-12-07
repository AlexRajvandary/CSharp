
namespace Fractal
{
    partial class Form1
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Draw = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AngleTextBox = new System.Windows.Forms.TextBox();
            this.LengthTextBox = new System.Windows.Forms.TextBox();
            this.Angle_label = new System.Windows.Forms.Label();
            this.Length_label = new System.Windows.Forms.Label();
            this.Angle_1textBox = new System.Windows.Forms.TextBox();
            this.Angle_2textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.WidthLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1. Обдуваемое ветром фрактальное дерево",
            "2. Кривая Коха",
            "3. Ковер Серпинского",
            "4. Треугольник Серпинского",
            "5. Множество Кантора"});
            this.comboBox1.Location = new System.Drawing.Point(12, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.MaximumSize = new System.Drawing.Size(360, 40);
            this.label1.MinimumSize = new System.Drawing.Size(170, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose the type of fractal";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(201, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(789, 640);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Draw
            // 
            this.Draw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Draw.Location = new System.Drawing.Point(82, 632);
            this.Draw.Name = "Draw";
            this.Draw.Size = new System.Drawing.Size(94, 29);
            this.Draw.TabIndex = 3;
            this.Draw.Text = "Draw";
            this.Draw.UseVisualStyleBackColor = true;
            this.Draw.Click += new System.EventHandler(this.Draw_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 118);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.MaximumSize = new System.Drawing.Size(360, 40);
            this.label2.MinimumSize = new System.Drawing.Size(170, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Количесвто шагов рекурсии";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AngleTextBox
            // 
            this.AngleTextBox.Location = new System.Drawing.Point(12, 286);
            this.AngleTextBox.Name = "AngleTextBox";
            this.AngleTextBox.Size = new System.Drawing.Size(125, 27);
            this.AngleTextBox.TabIndex = 6;
            this.AngleTextBox.Visible = false;
            this.AngleTextBox.TextChanged += new System.EventHandler(this.AngleTextBox_TextChanged);
            // 
            // LengthTextBox
            // 
            this.LengthTextBox.Location = new System.Drawing.Point(12, 215);
            this.LengthTextBox.Name = "LengthTextBox";
            this.LengthTextBox.Size = new System.Drawing.Size(125, 27);
            this.LengthTextBox.TabIndex = 7;
            this.LengthTextBox.Visible = false;
            this.LengthTextBox.TextChanged += new System.EventHandler(this.LengthTextBox_TextChanged);
            // 
            // Angle_label
            // 
            this.Angle_label.AutoSize = true;
            this.Angle_label.Location = new System.Drawing.Point(12, 254);
            this.Angle_label.Name = "Angle_label";
            this.Angle_label.Size = new System.Drawing.Size(48, 20);
            this.Angle_label.TabIndex = 8;
            this.Angle_label.Text = "Angle";
            this.Angle_label.Visible = false;
            // 
            // Length_label
            // 
            this.Length_label.AutoSize = true;
            this.Length_label.Location = new System.Drawing.Point(12, 182);
            this.Length_label.Name = "Length_label";
            this.Length_label.Size = new System.Drawing.Size(54, 20);
            this.Length_label.TabIndex = 9;
            this.Length_label.Text = "Length";
            this.Length_label.Visible = false;
            // 
            // Angle_1textBox
            // 
            this.Angle_1textBox.Location = new System.Drawing.Point(12, 362);
            this.Angle_1textBox.Name = "Angle_1textBox";
            this.Angle_1textBox.Size = new System.Drawing.Size(125, 27);
            this.Angle_1textBox.TabIndex = 10;
            this.Angle_1textBox.Visible = false;
            this.Angle_1textBox.TextChanged += new System.EventHandler(this.Angle_1textBox_TextChanged);
            // 
            // Angle_2textBox
            // 
            this.Angle_2textBox.Location = new System.Drawing.Point(12, 438);
            this.Angle_2textBox.Name = "Angle_2textBox";
            this.Angle_2textBox.Size = new System.Drawing.Size(125, 27);
            this.Angle_2textBox.TabIndex = 11;
            this.Angle_2textBox.Visible = false;
            this.Angle_2textBox.TextChanged += new System.EventHandler(this.Angel_2textBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Angle_1";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 405);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Angle_2";
            this.label4.Visible = false;
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Location = new System.Drawing.Point(12, 118);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(125, 27);
            this.WidthTextBox.TabIndex = 14;
            this.WidthTextBox.Visible = false;
            this.WidthTextBox.TextChanged += new System.EventHandler(this.WidthTextBox_TextChanged_1);
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WidthLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.WidthLabel.Location = new System.Drawing.Point(12, 87);
            this.WidthLabel.MaximumSize = new System.Drawing.Size(360, 40);
            this.WidthLabel.MinimumSize = new System.Drawing.Size(170, 20);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(170, 20);
            this.WidthLabel.TabIndex = 15;
            this.WidthLabel.Text = "Width";
            this.WidthLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 673);
            this.Controls.Add(this.WidthLabel);
            this.Controls.Add(this.WidthTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Angle_2textBox);
            this.Controls.Add(this.Angle_1textBox);
            this.Controls.Add(this.Length_label);
            this.Controls.Add(this.Angle_label);
            this.Controls.Add(this.LengthTextBox);
            this.Controls.Add(this.AngleTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Draw);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Draw;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AngleTextBox;
        private System.Windows.Forms.TextBox LengthTextBox;
        private System.Windows.Forms.Label Angle_label;
        private System.Windows.Forms.Label Length_label;
        private System.Windows.Forms.TextBox Angle_1textBox;
        private System.Windows.Forms.TextBox Angle_2textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox WidthTextBox;
        private System.Windows.Forms.Label WidthLabel;
    }
}

