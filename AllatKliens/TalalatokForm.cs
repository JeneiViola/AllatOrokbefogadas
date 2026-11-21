
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using AllatKliens.Models;

namespace AllatKliens
{
    public partial class TalalatokForm : Form
    {
        public TalalatokForm()
        {
            InitializeComponent();
        }

        public TalalatokForm(List<AllatAjanlas> ajanlasok) : this()
        {
            if (ajanlasok.Count == 0)
            {
                Panel pnlNincsTalalat = new Panel
                {
                    Size = new Size(920, 470),
                    BackColor = Color.Transparent
                };

                PictureBox picSzomoruCica = new PictureBox
                {
                    Image = Properties.Resources.szomoru_cica,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Size = new Size(230, 230),
                    Location = new Point(345, 5),
                    BackColor = Color.Transparent
                };

                Label lblNincsTalalat = new Label
                {
                    Text = "Sajnos most nem találtunk hozzád illő kedvencet.\n\n" +
                           "Próbálj meg nagyobb keresési távolságot megadni,\n" +
                           "vagy módosíts a keresési feltételeken!",
                    Font = new Font("Georgia", 16, FontStyle.Italic),
                    ForeColor = Color.FromArgb(100, 40, 55),
                    TextAlign = ContentAlignment.MiddleCenter,
                    AutoSize = false,
                    Size = new Size(900, 160),
                    Location = new Point(10, 245)
                };

                pnlNincsTalalat.Controls.Add(picSzomoruCica);
                pnlNincsTalalat.Controls.Add(lblNincsTalalat);

                flpAllatok.Controls.Add(pnlNincsTalalat);
                return;
            }

            foreach (var ajanlas in ajanlasok)
            {
                var kartya = new AllatKartya();
                kartya.AdatokBetoltese(ajanlas);

                flpAllatok.Controls.Add(kartya);
            }
        }

        private void btnVissza_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
