using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections; // ArrayList için
namespace hafta_7
{
    public partial class Form1 : Form
    {
        ArrayList urunler =new ArrayList();
        ArrayList stoklar = new ArrayList();
        ArrayList fiyatlar = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //veri ekleme
            urunler.Add(textBox1.Text);
            fiyatlar.Add(Convert.ToInt32(numericUpDown1.Value));
            stoklar.Add(Convert.ToInt32(numericUpDown2.Value));

            hesaplavelistele();
        }
        void hesaplavelistele()
        {
        int minfiyat=0,maxfiyat=0, minstok=0, maxstok=0, fiyattoplam=0; 
        for(int i=0;i<urunler.Count;i++)
            {
                fiyattoplam += Convert.ToInt32(fiyatlar[i]);
                if (i == 0)
                {
                    minfiyat = Convert.ToInt32(fiyatlar[i]);
                    maxfiyat = Convert.ToInt32(fiyatlar[i]);
                    minstok = Convert.ToInt32(stoklar[i]);
                    maxstok = Convert.ToInt32(stoklar[i]);           
                }
                //fiyatlarda min max kontrol
                else if (Convert.ToInt32(fiyatlar[i]) > maxfiyat) maxfiyat = (Convert.ToInt32(fiyatlar[i]));
                else if (Convert.ToInt32(fiyatlar[i]) < minfiyat) minfiyat = (Convert.ToInt32(fiyatlar[i]));

                //stoklarda min max kontrol
                if (Convert.ToInt32(stoklar[i])>maxstok) maxstok = Convert.ToInt32(stoklar[i]);
                else if (Convert.ToInt32(stoklar[i]) <minstok) minstok = Convert.ToInt32(stoklar[i]);
            }

        string minfiyaturun,maxfiyaturun,minstokurun,maxstokurun;
        minfiyaturun = urunler[fiyatlar.IndexOf(minfiyat)].ToString();
        maxfiyaturun = urunler[fiyatlar.IndexOf(maxfiyat)].ToString();

        minstokurun = urunler[stoklar.IndexOf(minstok)].ToString();
        maxstokurun = urunler[stoklar.IndexOf(maxstok)].ToString();

            int fiyatort = fiyattoplam / urunler.Count;
            listBox1.Items.Clear();
            listBox1.Items.Add("urun sayısı:" + urunler.Count);
            listBox1.Items.Add("urun fiyat ort:" + fiyatort);
            listBox1.Items.Add("en ucuz urun:" + minfiyaturun + "-" +minfiyat);
            listBox1.Items.Add("en pahalı urun:" + maxfiyaturun + "-" + maxfiyat);
            listBox1.Items.Add("en az stok:" + minstokurun + "-" + minstok);
            listBox1.Items.Add("en fazla stok:" + maxstokurun + "-" + maxstok);
            textBox1.Clear();
            textBox1.Focus();

        }
    }
}
