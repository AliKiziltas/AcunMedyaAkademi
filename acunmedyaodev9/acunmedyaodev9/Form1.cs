using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace acunmedyaodev9
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDogrula_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci = new Ogrenci
            {
                Ad = txtAd.Text,
                Soyad = txtSoyad.Text,
                Bolum = txtBolum.Text
            };

            var hatalar = new List<string>();

            foreach (var prop in typeof(Ogrenci).GetProperties())
            {
                var attr = (ZorunluAlanAttribute)Attribute.GetCustomAttribute(prop, typeof(ZorunluAlanAttribute));
                if (attr != null)
                {
                    var deger = prop.GetValue(ogrenci) as string;
                    if (string.IsNullOrWhiteSpace(deger))
                    {
                        hatalar.Add(attr.HataMesaji);
                    }
                }
            }

            if (hatalar.Any())
            {
                MessageBox.Show(string.Join("\n", hatalar), "Hatalar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                lblSonuc.Text = $"Ad: {ogrenci.Ad}\nSoyad: {ogrenci.Soyad}\nBölüm: {ogrenci.Bolum}";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
    
