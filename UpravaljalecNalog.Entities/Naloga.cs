using System;
using Core.Entities;

namespace UpravaljalecNalog.Entities
{
    public class Naloga : IEntity
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Opis { get; set; }
        public DateTime ZacetniDatum { get; set; }
        public DateTime KoncniDatum { get; set; }
    }
}
