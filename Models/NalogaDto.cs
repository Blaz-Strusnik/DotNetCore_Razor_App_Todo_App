using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Upravljalec_Nalog.Models
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
