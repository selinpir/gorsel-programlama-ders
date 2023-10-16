using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace görsel_prog_h3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        void temizle()
        {
            groupBox1.Enabled=true;
            groupBox2.Enabled=false;
            groupBox3.Enabled = false;

            radioButton1.Checked=false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
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
            if (radioButton1.Checked==true)
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

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton6.Checked == true)
                groupBox3.Enabled = true;

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton5.Checked == true)
                groupBox3.Enabled = true;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton4.Checked == true)
                groupBox3.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double toplam = 0;

            DialogResult secilentus=MessageBox.Show("Hesaplama işlemine geçilsin mi?"
                ,"LEDA PİZZA HOUSE",MessageBoxButtons.YesNo,MessageBoxIcon.Question); 

            if(secilentus==DialogResult.Yes)
            {
                // boyut secenegi
                if (radioButton1.Checked) toplam += 40;
                else if (radioButton2.Checked) toplam += 50;
                else toplam += 60;

                // hamur secenek
                if (radioButton4.Checked) toplam += 5;
                else toplam += 10;

                // malzeme secenekleri
                //else kullanmiyoruz cunku fazla secenek var
                if(checkBox1.Checked) toplam += 2.5;
                if (checkBox2.Checked) toplam +=  3.5   ;
                if (checkBox3.Checked) toplam +=  2 ;
                if (checkBox4.Checked) toplam += 2.5;
                if (checkBox5.Checked) toplam += 2;
                if (checkBox6.Checked) toplam += 3;
                if (checkBox7.Checked) toplam += 2;
                if (checkBox8.Checked) toplam += 2.75;
                if (checkBox9.Checked) toplam += 2.75;
                if (checkBox10.Checked) toplam += 2;
                if (checkBox11.Checked) toplam += 2.75;
                if (checkBox12.Checked) toplam += 2.75;

                // adet degeri hesaplamasi
                toplam*=Convert.ToInt32(numericUpDown1.Value);

                MessageBox.Show("Hesaplanan tutar: " + toplam, "Afiyet olsun!");




            }
        }
    }
}
