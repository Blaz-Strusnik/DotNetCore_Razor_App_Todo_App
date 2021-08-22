using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Upravljalec_Nalog.Data;
using Upravljalec_Nalog.Models;

namespace Upravljalec_Nalog.Controllers
{
    public class NalogaDtoesController : Controller
    {
        private readonly UpravljalecNaDbContext _context;

        public NalogaDtoesController(UpravljalecNaDbContext context)
        {
            _context = context;
        }

        // GET: NalogaDtoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Naloge.ToListAsync());
        }

        // GET: NalogaDtoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nalogaDto = await _context.Naloge
                .FirstOrDefaultAsync(m => m.Id == id);
            if (nalogaDto == null)
            {
                return NotFound();
            }

            return View(nalogaDto);
        }

        // GET: NalogaDtoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NalogaDtoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Ime,Opis,ZacetniDatum,KoncniDatum")] NalogaDto nalogaDto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nalogaDto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nalogaDto);
        }

        // GET: NalogaDtoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nalogaDto = await _context.Naloge.FindAsync(id);
            if (nalogaDto == null)
            {
                return NotFound();
            }
            return View(nalogaDto);
        }

        // POST: NalogaDtoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Ime,Opis,ZacetniDatum,KoncniDatum")] NalogaDto nalogaDto)
        {
            if (id != nalogaDto.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nalogaDto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NalogaDtoExists(nalogaDto.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(nalogaDto);
        }

        // GET: NalogaDtoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nalogaDto = await _context.Naloge
                .FirstOrDefaultAsync(m => m.Id == id);
            if (nalogaDto == null)
            {
                return NotFound();
            }

            return View(nalogaDto);
        }

        // POST: NalogaDtoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var nalogaDto = await _context.Naloge.FindAsync(id);
            _context.Naloge.Remove(nalogaDto);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NalogaDtoExists(int id)
        {
            return _context.Naloge.Any(e => e.Id == id);
        }
    }
}
