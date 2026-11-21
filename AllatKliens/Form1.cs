
using System.Net.Http.Json;
using AllatKliens.Models;

namespace AllatKliens
{
    public partial class Form1 : Form
    {
        private async Task<List<Allat>> AllatokLekereseAsync()
        {
            using var client = new HttpClient();

            var allatok = await client.GetFromJsonAsync<List<Allat>>(
                "https://localhost:7249/api/Allatok");

            return allatok ?? new List<Allat>();
        }

        private async Task<List<AllatAjanlas>> AjanlasokLekereseAsync(
            FelhasznaloiIgeny igeny)
        {
            using var client = new HttpClient();

            var valasz = await client.PostAsJsonAsync(
                "https://localhost:7249/api/Allatok/ajanlas",
                igeny);

            valasz.EnsureSuccessStatusCode();

            var ajanlasok =
                await valasz.Content.ReadFromJsonAsync<List<AllatAjanlas>>();

            return ajanlasok ?? new List<AllatAjanlas>();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private async void btnKapcsolodas_Click(object sender, EventArgs e)
        {
            try
            {
                using HttpClient kliens = new HttpClient();

                string valasz = await kliens.GetStringAsync(
                    "https://localhost:7249/api/Allatok");

                MessageBox.Show(valasz, "Szerver válasza");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nem sikerült kapcsolódni: " + ex.Message);
            }
        }

        private void picAllatok_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private async void btnKereses_Click(object sender, EventArgs e)
        {
            try
            {

                var igeny = new FelhasznaloiIgeny
                {
                    AllatTipus = cmbAllatTipus.Text,
                    Kornyezet = cmbLakhatas.Text,
                    Telepules = txtTelepules.Text.Trim(),
                    VanMasikAllat = cmbMasikAllat.Text == "Igen",
                    Aktivitas = cmbAktivitas.Text,
                    MaxTavolsagKm = (int)numTavolsag.Value
                };


                var ajanlasok = await AjanlasokLekereseAsync(igeny);


                using (var talalatokForm = new TalalatokForm(ajanlasok))
                {
                    this.Hide();

                    try
                    {
                        talalatokForm.ShowDialog(this);
                    }
                    finally
                    {
                        cmbAllatTipus.SelectedIndex = -1;
                        cmbLakhatas.SelectedIndex = -1;
                        txtTelepules.Clear();
                        cmbMasikAllat.SelectedIndex = -1;
                        cmbAktivitas.SelectedIndex = -1;
                        numTavolsag.Value = numTavolsag.Minimum;

                        this.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Nem sikerült lekérni az ajánlásokat:\n{ex.Message}",
                    "Hiba");
            }
        }
    }
}
