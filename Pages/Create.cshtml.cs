using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using NEW__Razor_Upravljalec_nalog.Data;
using NEW__Razor_Upravljalec_nalog.Model;

namespace NEW__Razor_Upravljalec_nalog
{
    [Authorize]
    public class CreateModel : PageModel
    {
        private readonly NEW__Razor_Upravljalec_nalog.Data.NEW__Razor_Upravljalec_nalogContext _context;

        public CreateModel(NEW__Razor_Upravljalec_nalog.Data.NEW__Razor_Upravljalec_nalogContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public NalogaDto NalogaDto { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.NalogaDto == null || NalogaDto == null)
            {
                return Page();
            }

            _context.NalogaDto.Add(NalogaDto);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Naloge_Index");
        }
    }
}
