using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Upravljalec_Nalog.Models
{
    public class NalogaDto
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Opis { get; set; }
        [Display(Name = "Začetni datum")]
        [DisplayFormat(DataFormatString = "{0:d.M.yyyy HH:mm}")]
        public DateTime ZacetniDatum { get; set; }
        [Display(Name = "Končni datum")]
        [DisplayFormat(DataFormatString = "{0:d.M.yyyy HH:mm}")]
        public DateTime KoncniDatum { get; set; }
    }
}
