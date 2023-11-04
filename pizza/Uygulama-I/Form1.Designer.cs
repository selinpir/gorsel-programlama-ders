namespace Uygulama_I
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            groupBox2 = new GroupBox();
            radioButton6 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton4 = new RadioButton();
            groupBox3 = new GroupBox();
            checkBox12 = new CheckBox();
            checkBox11 = new CheckBox();
            checkBox10 = new CheckBox();
            checkBox9 = new CheckBox();
            checkBox8 = new CheckBox();
            checkBox7 = new CheckBox();
            checkBox6 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            numericUpDown1 = new NumericUpDown();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FloralWhite;
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(87, 139);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(287, 147);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Boyut Seçeneği";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(14, 99);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(199, 33);
            radioButton3.TabIndex = 2;
            radioButton3.Text = "Büyük +60.00 ₺";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(14, 65);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(183, 33);
            radioButton2.TabIndex = 1;
            radioButton2.Text = "Orta +50.00 ₺";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(14, 31);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(199, 33);
            radioButton1.TabIndex = 0;
            radioButton1.Text = "Küçük +40.00 ₺";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FloralWhite;
            groupBox2.Controls.Add(radioButton6);
            groupBox2.Controls.Add(radioButton5);
            groupBox2.Controls.Add(radioButton4);
            groupBox2.Enabled = false;
            groupBox2.Location = new Point(87, 310);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(287, 172);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hamur Seçeneği";
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(14, 98);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(267, 33);
            radioButton6.TabIndex = 2;
            radioButton6.TabStop = true;
            radioButton6.Text = "Kalın Hamur ₺10.00 ₺";
            radioButton6.UseVisualStyleBackColor = true;
            radioButton6.CheckedChanged += radioButton6_CheckedChanged;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(14, 69);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(258, 33);
            radioButton5.TabIndex = 1;
            radioButton5.TabStop = true;
            radioButton5.Text = "İnce Hamur +10.00 ₺";
            radioButton5.UseVisualStyleBackColor = true;
            radioButton5.CheckedChanged += radioButton5_CheckedChanged;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(14, 30);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(222, 33);
            radioButton4.TabIndex = 0;
            radioButton4.TabStop = true;
            radioButton4.Text = "Standart  +5.00 ₺";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.FloralWhite;
            groupBox3.Controls.Add(checkBox12);
            groupBox3.Controls.Add(checkBox11);
            groupBox3.Controls.Add(checkBox10);
            groupBox3.Controls.Add(checkBox9);
            groupBox3.Controls.Add(checkBox8);
            groupBox3.Controls.Add(checkBox7);
            groupBox3.Controls.Add(checkBox6);
            groupBox3.Controls.Add(checkBox5);
            groupBox3.Controls.Add(checkBox4);
            groupBox3.Controls.Add(checkBox3);
            groupBox3.Controls.Add(checkBox2);
            groupBox3.Controls.Add(checkBox1);
            groupBox3.Enabled = false;
            groupBox3.Location = new Point(395, 166);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(462, 261);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Malzeme Seçeneği";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // checkBox12
            // 
            checkBox12.AutoSize = true;
            checkBox12.Location = new Point(236, 208);
            checkBox12.Name = "checkBox12";
            checkBox12.Size = new Size(198, 33);
            checkBox12.TabIndex = 11;
            checkBox12.Text = "Acı Sos +2.25 ₺";
            checkBox12.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            checkBox11.AutoSize = true;
            checkBox11.Location = new Point(236, 174);
            checkBox11.Name = "checkBox11";
            checkBox11.Size = new Size(219, 33);
            checkBox11.TabIndex = 10;
            checkBox11.Text = "Özel Sos  +2.25 ₺";
            checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            checkBox10.AutoSize = true;
            checkBox10.Location = new Point(236, 140);
            checkBox10.Name = "checkBox10";
            checkBox10.Size = new Size(219, 33);
            checkBox10.TabIndex = 9;
            checkBox10.Text = "Jalepano +2.00 ₺";
            checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            checkBox9.AutoSize = true;
            checkBox9.Location = new Point(236, 106);
            checkBox9.Name = "checkBox9";
            checkBox9.Size = new Size(188, 33);
            checkBox9.TabIndex = 8;
            checkBox9.Text = "Salam +2.75 ₺";
            checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            checkBox8.AutoSize = true;
            checkBox8.Location = new Point(236, 72);
            checkBox8.Name = "checkBox8";
            checkBox8.Size = new Size(226, 33);
            checkBox8.TabIndex = 7;
            checkBox8.Text = "Mozarella +2.25 ₺";
            checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Location = new Point(236, 38);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(173, 33);
            checkBox7.TabIndex = 6;
            checkBox7.Text = "Mısır +2.00 ₺";
            checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(12, 208);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(182, 33);
            checkBox6.TabIndex = 5;
            checkBox6.Text = "Sosis + 3.00 ₺";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(12, 174);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(189, 33);
            checkBox5.TabIndex = 4;
            checkBox5.Text = "Peynir +2.00 ₺";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(12, 140);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(205, 33);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "Mantar + 2.50 ₺";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(12, 106);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(179, 33);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "Biber +2.00 ₺";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(12, 72);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(185, 33);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Sucuk +3.50 ₺";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(12, 38);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(191, 33);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Zeytin +2.50 ₺";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.Crimson;
            button1.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.PapayaWhip;
            button1.Location = new Point(395, 516);
            button1.Name = "button1";
            button1.Size = new Size(133, 49);
            button1.TabIndex = 3;
            button1.Text = "Hesapla";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Crimson;
            button2.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.PapayaWhip;
            button2.Location = new Point(563, 516);
            button2.Name = "button2";
            button2.Size = new Size(268, 49);
            button2.TabIndex = 4;
            button2.Text = "Yeni Pizza Oluştur";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(563, 453);
            label1.Name = "label1";
            label1.Size = new Size(63, 29);
            label1.TabIndex = 5;
            label1.Text = "Adet";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(650, 447);
            numericUpDown1.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 35);
            numericUpDown1.TabIndex = 6;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gadugi", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.ForestGreen;
            label2.Location = new Point(101, 53);
            label2.Name = "label2";
            label2.Size = new Size(511, 48);
            label2.TabIndex = 7;
            label2.Text = "L e d a   P i z z a   H o u s e";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(650, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(207, 148);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(899, 605);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(numericUpDown1);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Trebuchet MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.IndianRed;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Pizza YBS";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private RadioButton radioButton6;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private CheckBox checkBox12;
        private CheckBox checkBox11;
        private CheckBox checkBox10;
        private CheckBox checkBox9;
        private CheckBox checkBox8;
        private CheckBox checkBox7;
        private CheckBox checkBox6;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Button button1;
        private Button button2;
        private Label label1;
        private NumericUpDown numericUpDown1;
        private Label label2;
        private PictureBox pictureBox1;
    }
}