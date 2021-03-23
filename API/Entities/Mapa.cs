using NetTopologySuite.Geometries;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace API.Entities
{
    [Table("Lokacije")]
    public class Mapa
    {
        public int Id { get; set; }
        public string NazivGrada { get; set; }
        public Geometry Lokacija { get; set; }
        public string LokacijaUString { get; set; }
        public string TipLokacije { get; set; }
    }
}