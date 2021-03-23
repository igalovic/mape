using System.Collections.Generic;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using API.Helpers;

namespace API.Controllers
{
    [ApiController]
    [Route("api/map")]
    public class MapController
    {
        private readonly DataContext _context;
        DoubleConverter doubleConverter = new DoubleConverter(); 

        public MapController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("dohvatiZupanije")]
        public async Task<ActionResult<IEnumerable<Mapa>>> DohvatiZupanije()
        {
            var upit = from A in _context.Lokacije 
                      select new Mapa
                      {
                        Id = A.Id,
                        //Lokacija = A.Lokacija,
                        NazivGrada = A.NazivGrada,
                        LokacijaUString =A.Lokacija.ToString(),
                        TipLokacije = A.TipLokacije
                        //Longitude = A.Lokacija.ToString()
                        //Longitude = double.Parse(A.Lokacija.ToString().Split('('))
                        //LokacijaUDouble = A.Lokacija
                      };
            return await upit.ToListAsync(); 
        }
    }
}