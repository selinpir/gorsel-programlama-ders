namespace _23GorselProg_III_NO
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            numericUpDown1 = new NumericUpDown();
            label2 = new Label();
            button2 = new Button();
            listBox1 = new ListBox();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            listBox2 = new ListBox();
            button3 = new Button();
            dateTimePicker2 = new DateTimePicker();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1002, 551);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.MistyRose;
            tabPage1.Controls.Add(numericUpDown1);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(listBox1);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 50);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(994, 497);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Personel Bilgileri";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(296, 129);
            numericUpDown1.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 47);
            numericUpDown1.TabIndex = 6;
            numericUpDown1.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 131);
            label2.Name = "label2";
            label2.Size = new Size(208, 41);
            label2.TabIndex = 5;
            label2.Text = "İzin Gün Sayısı";
            // 
            // button2
            // 
            button2.Location = new Point(195, 330);
            button2.Name = "button2";
            button2.Size = new Size(318, 92);
            button2.TabIndex = 4;
            button2.Text = "Seçili Personeli Sil";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 41;
            listBox1.Location = new Point(571, 49);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(365, 373);
            listBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(241, 230);
            button1.Name = "button1";
            button1.Size = new Size(227, 55);
            button1.TabIndex = 2;
            button1.Text = "Personel Kaydet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(296, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(217, 47);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(98, 37);
            label1.Name = "label1";
            label1.Size = new Size(183, 41);
            label1.TabIndex = 0;
            label1.Text = "Personel Adı";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.MistyRose;
            tabPage2.Controls.Add(listBox2);
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(dateTimePicker2);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(dateTimePicker1);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(comboBox1);
            tabPage2.Controls.Add(label3);
            tabPage2.Location = new Point(4, 50);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(994, 497);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "İzin İşlemleri";
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 41;
            listBox2.Location = new Point(573, 24);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(404, 414);
            listBox2.TabIndex = 7;
            // 
            // button3
            // 
            button3.Location = new Point(171, 383);
            button3.Name = "button3";
            button3.Size = new Size(214, 69);
            button3.TabIndex = 6;
            button3.Text = "İzin Girişi";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(328, 283);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 47);
            dateTimePicker2.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 288);
            label5.Name = "label5";
            label5.Size = new Size(203, 41);
            label5.TabIndex = 4;
            label5.Text = "İzin Bitiş Tarihi";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(328, 207);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 47);
            dateTimePicker1.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 212);
            label4.Name = "label4";
            label4.Size = new Size(272, 41);
            label4.TabIndex = 2;
            label4.Text = "İzin Başlangıç Tarihi";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(313, 132);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(215, 49);
            comboBox1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 140);
            label3.Name = "label3";
            label3.Size = new Size(131, 41);
            label3.TabIndex = 0;
            label3.Text = "Personel";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1026, 600);
            Controls.Add(tabControl1);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.DarkRed;
            Margin = new Padding(6);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private NumericUpDown numericUpDown1;
        private Label label2;
        private Button button2;
        private ListBox listBox1;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private TabPage tabPage2;
        private ListBox listBox2;
        private Button button3;
        private DateTimePicker dateTimePicker2;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private ComboBox comboBox1;
        private Label label3;
    }
}