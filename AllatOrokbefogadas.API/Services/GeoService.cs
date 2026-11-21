
using System.Net.Http.Json;
using System.Globalization;

namespace AllatOrokbefogadas.API.Services
{
    public class GeoService
    {
        private static readonly HttpClient client = new HttpClient();

        private static readonly Dictionary<string, (double Lat, double Lon)?>
            koordinataCache = new(StringComparer.OrdinalIgnoreCase);

        private static readonly SemaphoreSlim keresesiZar = new(1, 1);

        private static DateTime utolsoKereses = DateTime.MinValue;

        public GeoService()
        {
            client.DefaultRequestHeaders.UserAgent.ParseAdd(
                "AllatOrokbefogadas/1.0 (egyetemi beadando)");
        }

        public async Task<(double Lat, double Lon)?> KoordinatakLekereseAsync(
            string telepules)
        {
            string nev = telepules.Trim();

            if (string.IsNullOrWhiteSpace(nev))
                return null;

            await keresesiZar.WaitAsync();

            try
            {
                if (koordinataCache.TryGetValue(nev, out var tarolt))
                    return tarolt;

                var eltelt = DateTime.UtcNow - utolsoKereses;

                if (eltelt < TimeSpan.FromSeconds(1))
                {
                    await Task.Delay(TimeSpan.FromSeconds(1) - eltelt);
                }

                string keresettHely = Uri.EscapeDataString(
                    nev + ", Hungary");

                string url =
                    $"https://nominatim.openstreetmap.org/search?q={keresettHely}&format=json&limit=1";

                utolsoKereses = DateTime.UtcNow;

                var eredmeny =
                    await client.GetFromJsonAsync<List<GeoEredmeny>>(url);

                (double Lat, double Lon)? koordinatak = null;

                if (eredmeny != null && eredmeny.Count > 0)
                {
                    var hely = eredmeny[0];

                    koordinatak = (
                        double.Parse(hely.lat, CultureInfo.InvariantCulture),
                        double.Parse(hely.lon, CultureInfo.InvariantCulture)
                    );
                }

                koordinataCache[nev] = koordinatak;

                return koordinatak;
            }
            finally
            {
                keresesiZar.Release();
            }
        }

        public double TavolsagSzamitasa(
            double lat1, double lon1,
            double lat2, double lon2)
        {
            const double foldSugaraKm = 6371;

            double fokRadianna = Math.PI / 180;

            double latKulonbseg = (lat2 - lat1) * fokRadianna;
            double lonKulonbseg = (lon2 - lon1) * fokRadianna;

            double a =
                Math.Pow(Math.Sin(latKulonbseg / 2), 2) +
                Math.Cos(lat1 * fokRadianna) *
                Math.Cos(lat2 * fokRadianna) *
                Math.Pow(Math.Sin(lonKulonbseg / 2), 2);

            double c = 2 * Math.Atan2(
                Math.Sqrt(a),
                Math.Sqrt(1 - a));

            return foldSugaraKm * c;
        }

        private class GeoEredmeny
        {
            public string lat { get; set; } = "";
            public string lon { get; set; } = "";
        }
    }
}
