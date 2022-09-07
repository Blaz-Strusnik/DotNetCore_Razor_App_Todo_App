using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NEW__Razor_Upravljalec_nalog.Data;
using NEW__Razor_Upravljalec_nalog.Model;

namespace NEW__Razor_Upravljalec_nalog
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly NEW__Razor_Upravljalec_nalog.Data.NEW__Razor_Upravljalec_nalogContext _context;

        public IndexModel(NEW__Razor_Upravljalec_nalog.Data.NEW__Razor_Upravljalec_nalogContext context)
        {
            _context = context;
        }

        public IList<NalogaDto> NalogaDto { get;set; } = default!;


        public void OnGet()
        {
            NalogaDto = _context.NalogaDto
            //You have to convert your IQueryable to a List. You can do this by adding .ToList() at the end of
            //your Linq query.
            //Also change the type as <Lease>. Try this query instead,
            .Where(t => t.Owner == User.Identity.Name).OrderBy(t => t.Ime).ToList();
            NalogaDto = NalogaDto.ToList();
        }
    }
}
