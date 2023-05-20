using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EcomApp.Data;
using EcomAppProject.Models;

namespace EcomAppProject.Controllers
{
    public class AntivirusSoftwaresController : Controller
    {
        private readonly AppDbContext _context;

        public AntivirusSoftwaresController(AppDbContext context)
        {
            _context = context;
        }

        // GET: AntivirusSoftwares
        public async Task<IActionResult> Index()
        {
              return _context.AntivirusSoftwares != null ? 
                          View(await _context.AntivirusSoftwares.ToListAsync()) :
                          Problem("Entity set 'AppDbContext.AntivirusSoftwares'  is null.");
        }

        // GET: AntivirusSoftwares/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.AntivirusSoftwares == null)
            {
                return NotFound();
            }

            var antivirusSoftware = await _context.AntivirusSoftwares
                .FirstOrDefaultAsync(m => m.AntivirusID == id);
            if (antivirusSoftware == null)
            {
                return NotFound();
            }

            return View(antivirusSoftware);
        }

        // GET: AntivirusSoftwares/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AntivirusSoftwares/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AntivirusID,AntivirusDescription,AntivirusPrice")] AntivirusSoftware antivirusSoftware)
        {
            if (ModelState.IsValid)
            {
                _context.Add(antivirusSoftware);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(antivirusSoftware);
        }

        // GET: AntivirusSoftwares/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.AntivirusSoftwares == null)
            {
                return NotFound();
            }

            var antivirusSoftware = await _context.AntivirusSoftwares.FindAsync(id);
            if (antivirusSoftware == null)
            {
                return NotFound();
            }
            return View(antivirusSoftware);
        }

        // POST: AntivirusSoftwares/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AntivirusID,AntivirusDescription,AntivirusPrice")] AntivirusSoftware antivirusSoftware)
        {
            if (id != antivirusSoftware.AntivirusID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(antivirusSoftware);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AntivirusSoftwareExists(antivirusSoftware.AntivirusID))
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
            return View(antivirusSoftware);
        }

        // GET: AntivirusSoftwares/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.AntivirusSoftwares == null)
            {
                return NotFound();
            }

            var antivirusSoftware = await _context.AntivirusSoftwares
                .FirstOrDefaultAsync(m => m.AntivirusID == id);
            if (antivirusSoftware == null)
            {
                return NotFound();
            }

            return View(antivirusSoftware);
        }

        // POST: AntivirusSoftwares/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.AntivirusSoftwares == null)
            {
                return Problem("Entity set 'AppDbContext.AntivirusSoftwares'  is null.");
            }
            var antivirusSoftware = await _context.AntivirusSoftwares.FindAsync(id);
            if (antivirusSoftware != null)
            {
                _context.AntivirusSoftwares.Remove(antivirusSoftware);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AntivirusSoftwareExists(int id)
        {
          return (_context.AntivirusSoftwares?.Any(e => e.AntivirusID == id)).GetValueOrDefault();
        }
    }
}
