using System;

namespace TodoApp.DTO
{
    public class NalogaDto
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Opis { get; set; }
        public DateTime ZacetniDatum { get; set; }
        public DateTime KoncniDatum { get; set; }
    }
}
