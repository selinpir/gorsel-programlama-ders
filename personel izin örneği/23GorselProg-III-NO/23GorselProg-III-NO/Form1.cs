using System.Collections;
using System.Diagnostics.Eventing.Reader;

namespace _23GorselProg_III_NO
{
    public partial class Form1 : Form
    {

        ArrayList personeller = new ArrayList();
        ArrayList gunsayisi = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") MessageBox.Show("Lütfen Ýsim Girin");
            else
            {
                personeller.Add(textBox1.Text);
                gunsayisi.Add(numericUpDown1.Value);
                textBox1.Clear();
                textBox1.Focus();
                listele();
            }
        }

        void listele()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            comboBox1.Items.Clear();

            for (int i = 0; i < personeller.Count; i++)
            {
                listBox1.Items.Add(personeller[i] + " - " + gunsayisi[i]);
                listBox2.Items.Add(personeller[i] + " - " + gunsayisi[i]);
                comboBox1.Items.Add(personeller[i].ToString());

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1) MessageBox.Show("Lütfen Personel Seçiniz");
            else
            {
                personeller.RemoveAt(listBox1.SelectedIndex);
                gunsayisi.RemoveAt(listBox1.SelectedIndex);
                MessageBox.Show("Personel Silindi");
                listele();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult secilentus = MessageBox.Show("Ýþlemi Onaylýyor Musunuz?", "Ýzin", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secilentus == DialogResult.Yes)
            {
                DateTime izinbaslangic, izinbitis;
                izinbaslangic = dateTimePicker1.Value;
                izinbitis = dateTimePicker2.Value;

                if (izinbaslangic < izinbitis)
                {
                    if (izinbaslangic < DateTime.Now || izinbitis < DateTime.Now) MessageBox.Show("Hatalý Tarih Giriþi");
                    else
                    {
                        TimeSpan zamanaraligi = izinbitis - izinbaslangic;
                        int secilenizin = zamanaraligi.Days;

                        string secilenpersonel = comboBox1.Text;
                        int index = personeller.IndexOf(secilenpersonel);
                        int personelizinsayisi = Convert.ToInt32(gunsayisi[index]);

                        if (secilenizin > personelizinsayisi) MessageBox.Show("Yeterli izin günü bulunmamaktadýr");
                        else
                        {
                            MessageBox.Show(secilenpersonel + " " + secilenizin + " gün izin kullandý.");
                            gunsayisi[index] = Convert.ToInt32(gunsayisi[index]) - secilenizin;
                            listele();
                        }
                    }
                }
                else MessageBox.Show("Hatalý Tarih Seçimi");

            }
        }
    }
}