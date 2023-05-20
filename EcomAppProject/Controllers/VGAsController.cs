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
    public class VGAsController : Controller
    {
        private readonly AppDbContext _context;

        public VGAsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: VGAs
        public async Task<IActionResult> Index()
        {
              return _context.VGAs != null ? 
                          View(await _context.VGAs.ToListAsync()) :
                          Problem("Entity set 'AppDbContext.VGAs'  is null.");
        }

        // GET: VGAs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.VGAs == null)
            {
                return NotFound();
            }

            var vGA = await _context.VGAs
                .FirstOrDefaultAsync(m => m.VGAID == id);
            if (vGA == null)
            {
                return NotFound();
            }

            return View(vGA);
        }

        // GET: VGAs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: VGAs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("VGAID,VGADescription,VGAPictureURL,VGAPrice")] VGA vGA)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vGA);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vGA);
        }

        // GET: VGAs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.VGAs == null)
            {
                return NotFound();
            }

            var vGA = await _context.VGAs.FindAsync(id);
            if (vGA == null)
            {
                return NotFound();
            }
            return View(vGA);
        }

        // POST: VGAs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("VGAID,VGADescription,VGAPictureURL,VGAPrice")] VGA vGA)
        {
            if (id != vGA.VGAID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vGA);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VGAExists(vGA.VGAID))
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
            return View(vGA);
        }

        // GET: VGAs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.VGAs == null)
            {
                return NotFound();
            }

            var vGA = await _context.VGAs
                .FirstOrDefaultAsync(m => m.VGAID == id);
            if (vGA == null)
            {
                return NotFound();
            }

            return View(vGA);
        }

        // POST: VGAs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.VGAs == null)
            {
                return Problem("Entity set 'AppDbContext.VGAs'  is null.");
            }
            var vGA = await _context.VGAs.FindAsync(id);
            if (vGA != null)
            {
                _context.VGAs.Remove(vGA);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VGAExists(int id)
        {
          return (_context.VGAs?.Any(e => e.VGAID == id)).GetValueOrDefault();
        }
    }
}
