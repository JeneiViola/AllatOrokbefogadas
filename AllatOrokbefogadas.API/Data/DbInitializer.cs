
using System.Collections.Generic;
using System.Linq;
using AllatOrokbefogadas.API.Models;

namespace AllatOrokbefogadas.API.Data
{
    public static class DbInitializer
    {
        public static void Initialize(AllatDbContext context)
        {
            var allatok = new List<Allat>
            {
                new Allat
                {
                    Nev = "Bodri",
                    Nem = "Hím",
                    Tipus = "Kutya",
                    Eletkor = 0,
                    EletkorSzoveg = "6 hónapos",
                    Telepules = "Mohács",
                    Aktivitas = "Közepes",
                    LakasbanTarthato = true,
                    MasAllattalKijon = true,
                    Leiras = "Barátságos, játékos kutya.",
                    KepUrl = ""
                },
                new Allat
                {
                    Nev = "Mici",
                    Nem = "Nőstény",
                    Tipus = "Macska",
                    Eletkor = 2,
                    EletkorSzoveg = "2 éves",
                    Telepules = "Pécs",
                    Aktivitas = "Alacsony",
                    LakasbanTarthato = true,
                    MasAllattalKijon = false,
                    Leiras = "Nyugodt, bújós cica.",
                    KepUrl = ""
                },               
                new Allat
                {
                    Nev = "Cirmi",
                    Nem = "Nőstény",
                    Tipus = "Macska",
                    Eletkor = 0,
                    EletkorSzoveg = "7 hetes",
                    Telepules = "Baja",
                    Aktivitas = "Alacsony",
                    LakasbanTarthato = true,
                    MasAllattalKijon = true,
                    Leiras = "Kíváncsi, játékos kiscica.",
                    KepUrl = ""
                },
                new Allat
                {
                    Nev = "Max",
                    Nem = "Hím",
                    Tipus = "Kutya",
                    Eletkor = 4,
                    EletkorSzoveg = "4 éves",
                    Telepules = "Pécs",
                    Aktivitas = "Közepes",
                    LakasbanTarthato = true,
                    MasAllattalKijon = false,
                    Leiras = "Hűséges, nyugodt kutya.",
                    KepUrl = ""
                },
                new Allat
                {
                    Nev = "Nala",
                    Nem = "Nőstény",
                    Tipus = "Macska",
                    Eletkor = 1,
                    EletkorSzoveg = "1 éves",
                    Telepules = "Mohács",
                    Aktivitas = "Magas",
                    LakasbanTarthato = true,
                    MasAllattalKijon = true,
                    Leiras = "Békés természetű, szeret pihenni.",
                    KepUrl = ""
                },
                new Allat
                {
                    Nev = "Bogyó",
                    Nem = "Hím",
                    Tipus = "Kutya",
                    Eletkor = 2,
                    EletkorSzoveg = "2 éves",
                    Telepules = "Baja",
                    Aktivitas = "Magas",
                    LakasbanTarthato = false,
                    MasAllattalKijon = true,
                    Leiras = "Vidám, energikus kutya, aki imád kirándulni.",
                    KepUrl = ""
                },
                new Allat
                {
                    Nev = "Igor",
                    Nem = "Hím",
                    Tipus = "Kutya",
                    Eletkor = 4,
                    EletkorSzoveg = "4 éves",
                    Telepules = "Pécs",
                    Aktivitas = "Alacsony",
                    LakasbanTarthato = false,
                    MasAllattalKijon = true,
                    Leiras = "Nagyon családcentrikus kutyus",
                    KepUrl = ""
                },
                new Allat
                {
                    Nev = "Rocky",
                    Nem = "Hím",
                    Tipus = "Kutya",
                    Eletkor = 3,
                    EletkorSzoveg = "3 éves",
                    Telepules = "Szekszárd",
                    Aktivitas = "Magas",
                    LakasbanTarthato = true,
                    MasAllattalKijon = false,
                    Leiras = "Sportos, sok mozgást igénylő kutya.",
                    KepUrl = ""
                },
                new Allat
                {
                    Nev = "Morzsi",
                    Nem = "Hím",
                    Tipus = "Kutya",
                    Eletkor = 3,
                    EletkorSzoveg = "3 éves",
                    Telepules = "Mohács",
                    Aktivitas = "Alacsony",
                    LakasbanTarthato = true,
                    MasAllattalKijon = true,
                    Leiras = "Igazi vadász kutya, minden érdekli, ami mozog.",
                    KepUrl = ""
                },
                new Allat
                {
                    Nev = "Zeusz",
                    Nem = "Hím",
                    Tipus = "Kutya",
                    Eletkor = 2,
                    EletkorSzoveg = "2 éves",
                    Telepules = "Kaposvár",
                    Aktivitas = "Magas",
                    LakasbanTarthato = true,
                    MasAllattalKijon = true,
                    Leiras = "Nagy mozgásigényű, játékos kutya.",
                    KepUrl = ""
                },
                new Allat
                {
                    Nev = "Léna",
                    Nem = "Nőstény",
                    Tipus = "Kutya",
                    Eletkor = 1,
                    EletkorSzoveg = "1 éves",
                    Telepules = "Siklós",
                    Aktivitas = "Közepes",
                    LakasbanTarthato = true,
                    MasAllattalKijon = true,
                    Leiras = "Fiatal, barátságos kutya.",
                    KepUrl = ""
                },
                new Allat
                {
                    Nev = "Brúnó",
                    Nem = "Hím",
                    Tipus = "Kutya",
                    Eletkor = 2,
                    EletkorSzoveg = "2 éves",
                    Telepules = "Bonyhád",
                    Aktivitas = "Alacsony",
                    LakasbanTarthato = false,
                    MasAllattalKijon = false,
                    Leiras = "Nyugodt természetű, kertes házba ajánlott kutya.",
                    KepUrl = ""
                },
                new Allat
                {
                    Nev = "Füge",
                    Nem = "Hím",
                    Tipus = "Kutya",
                    Eletkor = 0,
                    EletkorSzoveg = "3 hónapos",
                    Telepules = "Paks",
                    Aktivitas = "Közepes",
                    LakasbanTarthato = true,
                    MasAllattalKijon = false,
                    Leiras = "Játékos, könnyen barátkozó kiskutya",
                    KepUrl = ""
                },
                new Allat
                {
                    Nev = "Cirnyuli",
                    Nem = "Nőstény",
                    Tipus = "Macska",
                    Eletkor = 1,
                    EletkorSzoveg = "1 éves",
                    Telepules = "Pécs",
                    Aktivitas = "Alacsony",
                    LakasbanTarthato = true,
                    MasAllattalKijon = true,
                    Leiras = "Bújós, nyugodt cica.",
                    KepUrl = ""
                },
                new Allat
                {
                    Nev = "Pityu",
                    Nem = "Hím",
                    Tipus = "Macska",
                    Eletkor = 3,
                    EletkorSzoveg = "3 éves",
                    Telepules = "Baja",
                    Aktivitas = "Magas",
                    LakasbanTarthato = true,
                    MasAllattalKijon = false,
                    Leiras = "Kíváncsi, aktív kandúr.",
                    KepUrl = ""
                },
                new Allat
                {
                    Nev = "Pötyi",
                    Nem = "Hím",
                    Tipus = "Macska",
                    Eletkor = 0,
                    EletkorSzoveg = "7 hetes",
                    Telepules = "Mohács",
                    Aktivitas = "Alacsony",
                    LakasbanTarthato = true,
                    MasAllattalKijon = true,
                    Leiras = "Barátságos, szeret ölben pihenni.",
                    KepUrl = ""
                },
                new Allat
                {
                    Nev = "Zokni",
                    Nem = "Hím",
                    Tipus = "Macska",
                    Eletkor = 0,
                    EletkorSzoveg = "6 hetes",
                    Telepules = "Szekszárd",
                    Aktivitas = "Magas",
                    LakasbanTarthato = true,
                    MasAllattalKijon = true,
                    Leiras = "Játékos, eleven kiscica.",
                    KepUrl = ""
                },
                new Allat
                {
                    Nev = "Muffin",
                    Nem = "Nőstény",
                    Tipus = "Macska",
                    Eletkor = 2,
                    EletkorSzoveg = "2 éves",
                    Telepules = "Kaposvár",
                    Aktivitas = "Közepes",
                    LakasbanTarthato = true,
                    MasAllattalKijon = false,
                    Leiras = "Önálló, de szeretetteljes cica.",
                    KepUrl = ""
                },
                new Allat
                {
                    Nev = "Pamacs",
                    Nem = "Hím",
                    Tipus = "Macska",
                    Eletkor = 0,
                    EletkorSzoveg = "7 hetes",
                    Telepules = "Siklós",
                    Aktivitas = "Alacsony",
                    LakasbanTarthato = true,
                    MasAllattalKijon = true,
                    Leiras = "Nyugodt, bújós kiscica.",
                    KepUrl = ""
                },
                new Allat
                {
                    Nev = "Coco",
                    Nem = "Nőstény",
                    Tipus = "Macska",
                    Eletkor = 0,
                    EletkorSzoveg = "6 hetes",
                    Telepules = "Bonyhád",
                    Aktivitas = "Közepes",
                    LakasbanTarthato = true,
                    MasAllattalKijon = true,
                    Leiras = "Kíváncsi, barátságos kiscica.",
                    KepUrl = ""
                },
                new Allat
                {
                    Nev = "Frici",
                    Nem = "Hím",
                    Tipus = "Macska",
                    Eletkor = 0,
                    EletkorSzoveg = "8 hetes",
                    Telepules = "Dombóvár",
                    Aktivitas = "Alacsony",
                    LakasbanTarthato = true,
                    MasAllattalKijon = false,
                    Leiras = "Fiatal nyugalmat kedvelő kandúr.",
                    KepUrl = ""
                },
                new Allat
                {
                    Nev = "Minyu",
                    Nem = "Nőstény",
                    Tipus = "Macska",
                    Eletkor = 1,
                    EletkorSzoveg = "1 éves",
                    Telepules = "Paks",
                    Aktivitas = "Közepes",
                    LakasbanTarthato = true,
                    MasAllattalKijon = true,
                    Leiras = "Kedves, játékos cica.",
                    KepUrl = ""
                }
            };

            foreach (var allat in allatok)
            {
                var meglevo = context.Allatok.FirstOrDefault(a =>
                    a.Nev == allat.Nev &&
                    a.Tipus == allat.Tipus &&
                    a.Telepules == allat.Telepules);

                if (meglevo == null)
                {
                    context.Allatok.Add(allat);
                }
                else
                {
                    meglevo.Nem = allat.Nem;
                    meglevo.Eletkor = allat.Eletkor;
                    meglevo.EletkorSzoveg = allat.EletkorSzoveg;
                    meglevo.Aktivitas = allat.Aktivitas;
                    meglevo.LakasbanTarthato = allat.LakasbanTarthato;
                    meglevo.MasAllattalKijon = allat.MasAllattalKijon;
                    meglevo.Leiras = allat.Leiras;
                }
            }

            context.SaveChanges();
        }
    }
}
