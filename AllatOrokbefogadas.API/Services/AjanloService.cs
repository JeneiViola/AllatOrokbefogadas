
using AllatOrokbefogadas.API.Models;

namespace AllatOrokbefogadas.API.Services
{
    public class AjanloService
    {
        public List<AllatAjanlas> AjanlasokSzamitasa(
            List<Allat> allatok,
            FelhasznaloiIgeny igeny)
        {
            var eredmenyek = new List<AllatAjanlas>();

            foreach (var allat in allatok)
            {
                // Csak a kiválasztott állattípust vizsgáljuk
                if (!string.Equals(
                    allat.Tipus,
                    igeny.AllatTipus,
                    StringComparison.OrdinalIgnoreCase))
                {
                    continue;
                }

                int pontszam = 0;

                // 1. Lakókörnyezet: maximum 35 pont
                if (igeny.Kornyezet == "Kert" ||
                    allat.LakasbanTarthato)
                {
                    pontszam += 35;
                }

                // 2. Más háziállattal való együttélés: maximum 30 pont
                if (!igeny.VanMasikAllat ||
                    allat.MasAllattalKijon)
                {
                    pontszam += 30;
                }

                // 3. Aktivitási szint: maximum 35 pont

                string keresettAktivitas = igeny.Aktivitas switch
                {
                    "Nyugodt" => "Alacsony",
                    "Kevésbé aktív" => "Alacsony",
                    "Közepesen aktív" => "Közepes",
                    "Nagyon aktív" => "Magas",
                    _ => igeny.Aktivitas
                };


                if (string.Equals(
                    allat.Aktivitas,
                    keresettAktivitas,
                    StringComparison.OrdinalIgnoreCase))
                {
                    pontszam += 35;
                }

                eredmenyek.Add(new AllatAjanlas
                {
                    Allat = allat,
                    Pontszam = pontszam
                });
            }

            return eredmenyek
                .OrderByDescending(a => a.Pontszam)
                .ToList();
        }
    }
}
