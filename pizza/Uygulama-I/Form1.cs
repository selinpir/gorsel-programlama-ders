using System.Runtime.CompilerServices;

namespace Uygulama_I
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            temizle();
        }

        void temizle()
        {
            groupBox1.Enabled = true;
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;

            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            numericUpDown1.Value = 1;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
                groupBox2.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
                groupBox2.Enabled = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
                groupBox2.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
                groupBox3.Enabled = true;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
                groupBox3.Enabled = true;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked == true)
                groupBox3.Enabled = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double toplam = 0;

            DialogResult secilentus = MessageBox.Show("Hesaplama iþlemine geçilsin mi?", "Pizza YBS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secilentus == DialogResult.Yes)
            {
                //Boyut Seçeneði Hesaplamasý
                if (radioButton1.Checked) toplam += 40;
                else if (radioButton2.Checked) toplam += 50;
                else toplam += 60;

                //Hamur Seçeneði Hesaplamasý
                if (radioButton4.Checked) toplam += 5;
                else toplam += 10;

                //Malzeme Seçenekleri Hesaplamasý
                if (checkBox1.Checked) toplam += 2.5;
                if (checkBox2.Checked) toplam += 3.5;
                if (checkBox3.Checked) toplam += 2;
                if (checkBox4.Checked) toplam += 2.5;
                if (checkBox5.Checked) toplam += 2;
                if (checkBox6.Checked) toplam += 3;
                if (checkBox7.Checked) toplam += 2;
                if (checkBox8.Checked) toplam += 2.25;
                if (checkBox9.Checked) toplam += 2.75;
                if (checkBox10.Checked) toplam += 2;
                if (checkBox11.Checked) toplam += 2.25;
                if (checkBox12.Checked) toplam += 2.25;

                //Adet deðeri hesaplamasý
                toplam *= Convert.ToInt32(numericUpDown1.Value);

                MessageBox.Show("Hesaplanan Tutar: " + toplam + " ?");
            }
        }
    }
}