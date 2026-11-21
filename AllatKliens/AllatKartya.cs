
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using AllatKliens.Models;

namespace AllatKliens
{
    public partial class AllatKartya : UserControl
    {
        public AllatKartya()
        {
            InitializeComponent();
        }

        public void AdatokBetoltese(AllatAjanlas ajanlas)
        {
            var allat = ajanlas.Allat;

            lblNev.Text = allat.Nev;
            lblAdatok.Text = $"{allat.EletkorSzoveg} · {allat.Telepules}";
            lblPontszam.Text = $"{ajanlas.Pontszam} pont";
            lblTavolsag.Text = $"{ajanlas.TavolsagKm:0.0} km légvonalban";
            lblLeiras.Text = allat.Leiras;

            // A képfájl neve megegyezik az állat nevével.
            string kepMappa = Path.Combine(
                AppContext.BaseDirectory, "kepek");

            string kepUtvonal = Path.Combine(
                kepMappa, allat.Nev + ".jpg");

            if (File.Exists(kepUtvonal))
            {
                // A képet úgy töltjük be, hogy a fájl ne maradjon zárolva.

                try
                {
                    using (var eredetiKep = Image.FromFile(kepUtvonal))
                    {
                        picAllat.Image?.Dispose();
                        picAllat.Image = new Bitmap(eredetiKep);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        $"Nem sikerült betölteni a képet:\n{kepUtvonal}\n\nHiba: {ex.Message}",
                        "Képhiba");

                    picAllat.Image = null;
                }

            }
            else
            {
                picAllat.Image = null;
            }
        }
    }
}
