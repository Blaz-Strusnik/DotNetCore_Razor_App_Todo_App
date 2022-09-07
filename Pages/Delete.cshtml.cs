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
    public class DeleteModel : PageModel
    {
        private readonly NEW__Razor_Upravljalec_nalog.Data.NEW__Razor_Upravljalec_nalogContext _context;

        public DeleteModel(NEW__Razor_Upravljalec_nalog.Data.NEW__Razor_Upravljalec_nalogContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(long? id)
        {
            if (id == null || _context.NalogaDto == null)
            {
                return NotFound();
            }
            var nalogadto = await _context.NalogaDto.FindAsync(id);

            if (nalogadto != null)
            {
                NalogaDto = nalogadto;
                _context.NalogaDto.Remove(NalogaDto);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
