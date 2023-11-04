using System.Collections;

namespace Ders_II
{
    public partial class Form1 : Form
    {
        ArrayList musteriler = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") MessageBox.Show("Lütfen Ýsim Giriniz");
            else musteriler.Add(textBox1.Text);

            textBox1.Clear();
            textBox1.Focus();
            listBox1.Items.Clear();
            comboBox1.Items.Clear();
            listele();

        }

        void listele()
        {

            for (int i = 0; i < musteriler.Count; i++)
            {
                listBox1.Items.Add(musteriler[i].ToString());
                comboBox1.Items.Add(musteriler[i].ToString());

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1) MessageBox.Show("Lütfen Müþteri Seçiniz...");
            else
            {
                musteriler.RemoveAt(listBox1.SelectedIndex);
                MessageBox.Show("Müþteri Silindi");
                listBox1.Items.Clear();
                comboBox1.Items.Clear();
                listele();
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) numericUpDown1.Enabled = true;
            else numericUpDown1.Enabled = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked) numericUpDown2.Enabled = true;
            else numericUpDown2.Enabled = false;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked) numericUpDown3.Enabled = true;
            else numericUpDown3.Enabled = false;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked) numericUpDown4.Enabled = true;
            else numericUpDown4.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Müþteri Adýnýn Eklenmesi
            listBox2.Items.Add(comboBox1.Text);
            double toplamtutar = 0;

            //Kum Tutarýnýn Hesaplanmasý
            if (checkBox1.Checked)
            {
                toplamtutar += 3000 * Convert.ToDouble(numericUpDown1.Value);
                listBox2.Items.Add("Kum :" + 3000 * Convert.ToDouble(numericUpDown1.Value));
            }

            //Çimento Tutarýnýn Hesaplanmasý
            if (checkBox2.Checked)
            {
                toplamtutar += 2000 * Convert.ToDouble(numericUpDown2.Value);
                listBox2.Items.Add("Çimento : " + 2000 * Convert.ToDouble(numericUpDown2.Value));
            }
            //Kömür Tutarýnýn Hesaplanmasý
            if (checkBox3.Checked)
            {
                toplamtutar += 5000 * Convert.ToDouble(numericUpDown3.Value);
                listBox2.Items.Add("Kömür : " + 5000 * Convert.ToDouble(numericUpDown3.Value));
            }

            //Çakýl Tutarýnýn Hesaplanmasý
            if (checkBox4.Checked)
            {
                toplamtutar += 2500 * Convert.ToDouble(numericUpDown4.Value);
                listBox2.Items.Add("Çakýl : " + 2500 * Convert.ToDouble(numericUpDown4.Value));

                if (toplamtutar == 0)
                {
                    MessageBox.Show("Lütfen Ürün Seçiniz....");
                    listBox2.Items.Clear();
                }
                else
                {
                    listBox2.Items.Add("Ödenecek Tutar: " + toplamtutar);
                }


            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}