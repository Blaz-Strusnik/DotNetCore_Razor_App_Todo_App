using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NEW__Razor_Upravljalec_nalog.Data;
using NEW__Razor_Upravljalec_nalog.Model;

namespace NEW__Razor_Upravljalec_nalog
{
    [Authorize]
    public class EditModel : PageModel
    {
        private readonly NEW__Razor_Upravljalec_nalog.Data.NEW__Razor_Upravljalec_nalogContext _context;

        public EditModel(NEW__Razor_Upravljalec_nalog.Data.NEW__Razor_Upravljalec_nalogContext context)
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

            var nalogadto =  await _context.NalogaDto.FirstOrDefaultAsync(m => m.Id == id);
            if (nalogadto == null)
            {
                return NotFound();
            }
            NalogaDto = nalogadto;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(NalogaDto).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NalogaDtoExists(NalogaDto.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool NalogaDtoExists(long id)
        {
          return (_context.NalogaDto?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
