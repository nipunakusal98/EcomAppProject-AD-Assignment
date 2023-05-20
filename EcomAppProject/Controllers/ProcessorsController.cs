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
    public class ProcessorsController : Controller
    {
        private readonly AppDbContext _context;

        public ProcessorsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Processors
        public async Task<IActionResult> Index()
        {
              return _context.Processors != null ? 
                          View(await _context.Processors.ToListAsync()) :
                          Problem("Entity set 'AppDbContext.Processors'  is null.");
        }

        // GET: Processors/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Processors == null)
            {
                return NotFound();
            }

            var processor = await _context.Processors
                .FirstOrDefaultAsync(m => m.ProcessorID == id);
            if (processor == null)
            {
                return NotFound();
            }

            return View(processor);
        }

        // GET: Processors/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Processors/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProcessorID,ProcessorDescription,ProcessorPictureURL,ProcessorPrice")] Processor processor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(processor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(processor);
        }

        // GET: Processors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Processors == null)
            {
                return NotFound();
            }

            var processor = await _context.Processors.FindAsync(id);
            if (processor == null)
            {
                return NotFound();
            }
            return View(processor);
        }

        // POST: Processors/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProcessorID,ProcessorDescription,ProcessorPictureURL,ProcessorPrice")] Processor processor)
        {
            if (id != processor.ProcessorID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(processor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProcessorExists(processor.ProcessorID))
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
            return View(processor);
        }

        // GET: Processors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Processors == null)
            {
                return NotFound();
            }

            var processor = await _context.Processors
                .FirstOrDefaultAsync(m => m.ProcessorID == id);
            if (processor == null)
            {
                return NotFound();
            }

            return View(processor);
        }

        // POST: Processors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Processors == null)
            {
                return Problem("Entity set 'AppDbContext.Processors'  is null.");
            }
            var processor = await _context.Processors.FindAsync(id);
            if (processor != null)
            {
                _context.Processors.Remove(processor);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProcessorExists(int id)
        {
          return (_context.Processors?.Any(e => e.ProcessorID == id)).GetValueOrDefault();
        }
    }
}
