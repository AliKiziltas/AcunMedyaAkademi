using System.Text.Json;

namespace AcunmedyaOdev6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUrunleriGoster_Click(object sender, EventArgs e)
        {
            try
            {
                string json = File.ReadAllText("urunler.json");
                List<Urun> urunler = JsonSerializer.Deserialize<List<Urun>>(json);

                string mesaj = "";
                foreach (var urun in urunler)
                {
                    mesaj += $"Ürün: {urun.UrunAdi}, Fiyatý: {urun.Fiyat} TL\n";
                }

                MessageBox.Show(mesaj, "Ürün Listesi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
    

