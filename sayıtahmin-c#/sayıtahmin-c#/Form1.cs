using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayıtahmin_c_
{
    public partial class Form1 : Form
    {
        int min, max;
        int adim = 0;
        int uretilensayi;
       

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            min = Convert.ToInt32(numericUpDown1.Value);
            max = Convert.ToInt32(numericUpDown2.Value);

            if (min > max)
            {
                MessageBox.Show("Hatalı Veri Girişi.");
            }
            else
            {
                try
                {
                    Random uret = new Random();
                    uretilensayi = uret.Next(min, max + 1);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            adim++;
            listBox1.Items.Add(textBox1.Text);
            int tahmin = Convert.ToInt32(textBox1.Text);
            if (uretilensayi == tahmin)
            {
                MessageBox.Show("Doğru Tahmin" + adim + " . adımda bildiniz.");
            }
            else if (uretilensayi > tahmin)
            {
                MessageBox.Show("Uretilen sayı daha büyük,tahminden daha büyük değer giriniz!");
            }
            else
            {
                MessageBox.Show("Uretilen sayı daha küçük,tahminden daha küçük değer giriniz!");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //yeniden başlat
            listBox1.Items.Clear();
            adim = 0;
            textBox1.Clear();
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
        }
    }
}
