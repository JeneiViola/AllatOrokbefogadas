
namespace AllatOrokbefogadas.API.Models
{
    public class Allat
    {
        public int Id { get; set; }
        public string Nev { get; set; } = "";
        public string Nem { get; set; } = "";
        public string Tipus { get; set; } = "";
        public int Eletkor { get; set; }
        public string EletkorSzoveg { get; set; } = "";
        public string Telepules { get; set; } = "";
        public string Aktivitas { get; set; } = "";
        public bool LakasbanTarthato { get; set; }
        public bool MasAllattalKijon { get; set; }
        public string Leiras { get; set; } = "";
        public string KepUrl { get; set; } = "";
      
    }
}
