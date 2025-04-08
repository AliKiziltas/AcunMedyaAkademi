using System;
using System.Windows.Forms;

namespace ArabaBilgiFormu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string marka = textBox1.Text;
            string model = textBox2.Text;
            string renk = textBox3.Text;
            string kapi = textBox4.Text;
            string pencere = textBox5.Text;
            string yakit = textBox6.Text;
            string mesaj = "🚗 Araba Bilgileri:\n" +
                           "Marka: " + marka + "\n" +
                           "Model: " + model + "\n" +
                           "Renk: " + renk + "\n" +
                           "Kapı Sayısı: " + kapi + "\n" +
                           "Pencere Sayısı: " + pencere + "\n" +
                           "100 km’de Yaktığı Yakıt: " + yakit + " Litre";
            MessageBox.Show(mesaj, "Araba Bilgi Ekranı");
        }
    }
}
