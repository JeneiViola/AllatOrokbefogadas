
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AllatOrokbefogadas.API.Data;
using AllatOrokbefogadas.API.Models;
using AllatOrokbefogadas.API.Services;

namespace AllatOrokbefogadas.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AllatokController : ControllerBase
    {
        private readonly AllatDbContext _context;

        public AllatokController(AllatDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Allat>>> GetAllatok()
        {
            return await _context.Allatok.ToListAsync();
        }

        [HttpPost("ajanlas")]
        public async Task<IActionResult> Ajanlas(
            [FromBody] FelhasznaloiIgeny igeny)
        {
            if (igeny == null ||
                string.IsNullOrWhiteSpace(igeny.AllatTipus) ||
                string.IsNullOrWhiteSpace(igeny.Kornyezet) ||
                string.IsNullOrWhiteSpace(igeny.Telepules) ||
                string.IsNullOrWhiteSpace(igeny.Aktivitas) ||
                igeny.MaxTavolsagKm < 1 ||
                igeny.MaxTavolsagKm > 500)
            {
                return BadRequest("Hiányos vagy érvénytelen kérdőív!");
            }

            var allatok = await _context.Allatok.ToListAsync();

            var geoService = new GeoService();

            var felhasznaloHelye =
                await geoService.KoordinatakLekereseAsync(
                    igeny.Telepules);

            if (felhasznaloHelye == null)
            {
                return BadRequest(
                    "A megadott település nem található.");
            }

            var kozeliAllatok = new List<Allat>();

            var tavolsagok = new Dictionary<int, double>();

            foreach (var allat in allatok)
            {
                var allatHelye =
                    await geoService.KoordinatakLekereseAsync(
                        allat.Telepules);

                if (allatHelye == null)
                    continue;

                double tavolsag = geoService.TavolsagSzamitasa(
                    felhasznaloHelye.Value.Lat,
                    felhasznaloHelye.Value.Lon,
                    allatHelye.Value.Lat,
                    allatHelye.Value.Lon);

                if (tavolsag <= igeny.MaxTavolsagKm)
                {
                    kozeliAllatok.Add(allat);
                    tavolsagok[allat.Id] = tavolsag;
                }
            }

            var ajanloService = new AjanloService();

            var eredmenyek = ajanloService.AjanlasokSzamitasa(
                kozeliAllatok, igeny);

            foreach (var ajanlas in eredmenyek)
            {
                ajanlas.TavolsagKm = Math.Round(
                    tavolsagok[ajanlas.Allat.Id], 1);
            }

            return Ok(eredmenyek);
        }
    }
}
