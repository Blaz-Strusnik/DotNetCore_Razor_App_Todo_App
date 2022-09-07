using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace NEW__Razor_Upravljalec_nalog.Model
{
    public class NalogaDto
    {
        public long Id { get; set; }
        public string Ime { get; set; }
        public string Opis { get; set; }
        [Display(Name = "Začetni datum")]
        [DisplayFormat(DataFormatString = "{0:d.M.yyyy HH:mm}")]
        public DateTime ZacetniDatum { get; set; }
        [Display(Name = "Končni datum")]
        [DisplayFormat(DataFormatString = "{0:d.M.yyyy HH:mm}")]
        public DateTime KoncniDatum { get; set; }
        public string? Owner { get; set; }
    }
}
