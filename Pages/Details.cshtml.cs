using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NEW__Razor_Upravljalec_nalog.Data;
using NEW__Razor_Upravljalec_nalog.Model;

namespace NEW__Razor_Upravljalec_nalog
{
    [Authorize]
    public class DetailsModel : PageModel
    {
        private readonly NEW__Razor_Upravljalec_nalog.Data.NEW__Razor_Upravljalec_nalogContext _context;

        public DetailsModel(NEW__Razor_Upravljalec_nalog.Data.NEW__Razor_Upravljalec_nalogContext context)
        {
            _context = context;
        }

      public NalogaDto NalogaDto { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null || _context.NalogaDto == null)
            {
                return NotFound();
            }

            var nalogadto = await _context.NalogaDto.FirstOrDefaultAsync(m => m.Id == id);
            if (nalogadto == null)
            {
                return NotFound();
            }
            else 
            {
                NalogaDto = nalogadto;
            }
            return Page();
        }
    }
}
