using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace hafta_6_gorsel_prog
{
    public partial class Form1 : Form
    {
        ArrayList urunA = new ArrayList();

        ArrayList urunF = new ArrayList();

        ArrayList urunS = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") MessageBox.Show("Lütfen ürün ismi Giriniz");
            else urunA.Add(textBox1.Text);

            textBox1.Clear();
            textBox1.Focus();
            listBox1.Items.Clear();
            listele();


            if (textBox2.Text == "") MessageBox.Show("Lütfen ürün fiyatı Giriniz");
            else urunF.Add(textBox2.Text);

            textBox2.Clear();
            textBox2.Focus();
            listBox1.Items.Clear();
            listele();

            if (textBox3.Text == "") MessageBox.Show("Lütfen ürün stoğu Giriniz");
            else urunS.Add(textBox3.Text);

            textBox3.Clear();
            textBox3.Focus();
            listBox1.Items.Clear();
            listele();

        }

        void listele()
        {

            for (int i = 0; i < urunA.Count; i++)
            {
                listBox1.Items.Add(urunA[i].ToString());
          
            }
            for (int i = 0; i < urunF.Count; i++)
            {
                listBox1.Items.Add(urunF[i].ToString());

            }

            for (int i = 0; i < urunS.Count; i++)
            {
                listBox1.Items.Add(urunS[i].ToString());

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Listede herhangi bir ürün bulunmamaktadır.");
                return;
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {

            // En az ve fazla sayıda stokta bulunan ürünler
            int minStok = Convert.ToInt32(urunS[0]);
            int maxStok = Convert.ToInt32(urunS[0]);
            string minStokUrun = urunA[0].ToString();
            string maxStokUrun = urunA[0].ToString();

            // En ucuz ve en pahalı fiyata satılan ürünler
            double minFiyat = Convert.ToDouble(urunF[0]);
            double maxFiyat = Convert.ToDouble(urunF[0]);
            string minFiyatUrun = urunA[0].ToString();
            string maxFiyatUrun = urunA[0].ToString();


            // Toplam kayıtlı ürün sayısı
            int toplamUrunSayisi = urunA.Count;

            // Ürünlerin fiyat ortalaması
            double toplamFiyat = 0;

            for (int i = 0; i < urunS.Count; i++)
            {
                int stok = Convert.ToInt32(urunS[i]);
                double fiyat = Convert.ToDouble(urunF[i]);

                // En az ve fazla sayıda stokta bulunan ürünler
                if (stok < minStok)
                {
                    minStok = stok;
                    minStokUrun = urunA[i].ToString();
                }

                if (stok > maxStok)
                {
                    maxStok = stok;
                    maxStokUrun = urunA[i].ToString();
                }

                // En ucuz ve en pahalı fiyata satılan ürünler
                if (fiyat < minFiyat)
                {
                    minFiyat = fiyat;
                    minFiyatUrun = urunA[i].ToString();
                }

                if (fiyat > maxFiyat)
                {
                    maxFiyat = fiyat;
                    maxFiyatUrun = urunA[i].ToString();
                }

                // Toplam fiyatı hesapla
                toplamFiyat += fiyat;
            }

            // Ürünlerin fiyat ortalaması
            double fiyatOrtalamasi = toplamFiyat / urunA.Count;

            listBox1.Items.Add("En az stokta bulunan ürün: " + minStokUrun + " (" + minStok + " adet)");
            listBox1.Items.Add("En fazla stokta bulunan ürün: " + maxStokUrun + " (" + maxStok + " adet)");
            listBox1.Items.Add("");
            listBox1.Items.Add("En ucuz fiyatlı ürün: " + minFiyatUrun + " (" + minFiyat.ToString("C") + ")");
            listBox1.Items.Add("En pahalı fiyatlı ürün: " + maxFiyatUrun + " (" + maxFiyat.ToString("C") + ")");
            listBox1.Items.Add("");
            listBox1.Items.Add("Toplam kayıtlı ürün sayısı: " + toplamUrunSayisi);
            listBox1.Items.Add("");
            listBox1.Items.Add("Ürünlerin fiyat ortalaması: " + fiyatOrtalamasi.ToString("C"));

        }
    }
}
