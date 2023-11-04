namespace Ders_II
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            pictureBox1 = new PictureBox();
            listBox1 = new ListBox();
            button2 = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            pictureBox2 = new PictureBox();
            button4 = new Button();
            button3 = new Button();
            numericUpDown4 = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            numericUpDown1 = new NumericUpDown();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            listBox2 = new ListBox();
            comboBox1 = new ComboBox();
            label2 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(40, 23);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(821, 539);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Transparent;
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Controls.Add(listBox1);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 38);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(813, 497);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Müşteriler";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(370, 76);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(449, 280);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 29;
            listBox1.Location = new Point(60, 89);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(304, 236);
            listBox1.TabIndex = 4;
            // 
            // button2
            // 
            button2.BackColor = Color.OldLace;
            button2.ForeColor = Color.Black;
            button2.Location = new Point(60, 414);
            button2.Name = "button2";
            button2.Size = new Size(279, 53);
            button2.TabIndex = 3;
            button2.Text = "Seçilen Müşteriyi Sil";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.OldLace;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(60, 352);
            button1.Name = "button1";
            button1.Size = new Size(279, 41);
            button1.TabIndex = 2;
            button1.Text = "Müşteri Ekle";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(222, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(169, 35);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(60, 35);
            label1.Name = "label1";
            label1.Size = new Size(132, 29);
            label1.TabIndex = 0;
            label1.Text = "Müşteri Adı";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.White;
            tabPage2.Controls.Add(pictureBox2);
            tabPage2.Controls.Add(button4);
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(numericUpDown4);
            tabPage2.Controls.Add(numericUpDown3);
            tabPage2.Controls.Add(numericUpDown2);
            tabPage2.Controls.Add(numericUpDown1);
            tabPage2.Controls.Add(checkBox4);
            tabPage2.Controls.Add(checkBox3);
            tabPage2.Controls.Add(checkBox2);
            tabPage2.Controls.Add(checkBox1);
            tabPage2.Controls.Add(listBox2);
            tabPage2.Controls.Add(comboBox1);
            tabPage2.Controls.Add(label2);
            tabPage2.Location = new Point(4, 38);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(813, 497);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "İşlemler";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(668, 165);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(187, 462);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // button4
            // 
            button4.BackColor = Color.CadetBlue;
            button4.ForeColor = Color.Black;
            button4.Location = new Point(212, 372);
            button4.Name = "button4";
            button4.Size = new Size(160, 63);
            button4.TabIndex = 12;
            button4.Text = "Temizle";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.CadetBlue;
            button3.ForeColor = Color.Black;
            button3.Location = new Point(27, 372);
            button3.Name = "button3";
            button3.Size = new Size(160, 63);
            button3.TabIndex = 11;
            button3.Text = "Kaydet";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // numericUpDown4
            // 
            numericUpDown4.DecimalPlaces = 2;
            numericUpDown4.Enabled = false;
            numericUpDown4.ForeColor = Color.CadetBlue;
            numericUpDown4.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDown4.Location = new Point(227, 268);
            numericUpDown4.Margin = new Padding(4, 5, 4, 5);
            numericUpDown4.Minimum = new decimal(new int[] { 5, 0, 0, 65536 });
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(105, 35);
            numericUpDown4.TabIndex = 10;
            numericUpDown4.Value = new decimal(new int[] { 5, 0, 0, 65536 });
            // 
            // numericUpDown3
            // 
            numericUpDown3.DecimalPlaces = 2;
            numericUpDown3.Enabled = false;
            numericUpDown3.ForeColor = Color.CadetBlue;
            numericUpDown3.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDown3.Location = new Point(227, 215);
            numericUpDown3.Margin = new Padding(4, 5, 4, 5);
            numericUpDown3.Minimum = new decimal(new int[] { 5, 0, 0, 65536 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(104, 35);
            numericUpDown3.TabIndex = 9;
            numericUpDown3.Value = new decimal(new int[] { 5, 0, 0, 65536 });
            // 
            // numericUpDown2
            // 
            numericUpDown2.DecimalPlaces = 2;
            numericUpDown2.Enabled = false;
            numericUpDown2.ForeColor = Color.CadetBlue;
            numericUpDown2.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDown2.Location = new Point(229, 165);
            numericUpDown2.Margin = new Padding(4, 5, 4, 5);
            numericUpDown2.Minimum = new decimal(new int[] { 5, 0, 0, 65536 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(102, 35);
            numericUpDown2.TabIndex = 8;
            numericUpDown2.Value = new decimal(new int[] { 5, 0, 0, 65536 });
            // 
            // numericUpDown1
            // 
            numericUpDown1.DecimalPlaces = 2;
            numericUpDown1.Enabled = false;
            numericUpDown1.ForeColor = Color.CadetBlue;
            numericUpDown1.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDown1.Location = new Point(227, 117);
            numericUpDown1.Margin = new Padding(4, 5, 4, 5);
            numericUpDown1.Minimum = new decimal(new int[] { 5, 0, 0, 65536 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(105, 35);
            numericUpDown1.TabIndex = 7;
            numericUpDown1.Value = new decimal(new int[] { 5, 0, 0, 65536 });
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.ForeColor = Color.CadetBlue;
            checkBox4.Location = new Point(62, 268);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(88, 33);
            checkBox4.TabIndex = 6;
            checkBox4.Text = "Çakıl";
            checkBox4.UseVisualStyleBackColor = true;
            checkBox4.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.ForeColor = Color.CadetBlue;
            checkBox3.Location = new Point(62, 215);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(104, 33);
            checkBox3.TabIndex = 5;
            checkBox3.Text = "Kömür";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.ForeColor = Color.CadetBlue;
            checkBox2.Location = new Point(62, 165);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(125, 33);
            checkBox2.TabIndex = 4;
            checkBox2.Text = "Çimento";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.ForeColor = Color.CadetBlue;
            checkBox1.Location = new Point(63, 117);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(81, 33);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Kum";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 29;
            listBox2.Location = new Point(387, 49);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(275, 381);
            listBox2.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(169, 49);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(190, 37);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(63, 49);
            label2.Name = "label2";
            label2.Size = new Size(92, 29);
            label2.TabIndex = 0;
            label2.Text = "Müşteri";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 64, 64);
            ClientSize = new Size(895, 593);
            Controls.Add(tabControl1);
            Font = new Font("Trebuchet MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Brown;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Hırdavatçı";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private ListBox listBox1;
        private Button button2;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private TabPage tabPage2;
        private Button button3;
        private NumericUpDown numericUpDown4;
        private NumericUpDown numericUpDown3;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown1;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private ListBox listBox2;
        private ComboBox comboBox1;
        private Label label2;
        private Button button4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}