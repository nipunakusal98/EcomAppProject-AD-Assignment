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
    public class MemoriesController : Controller
    {
        private readonly AppDbContext _context;

        public MemoriesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Memories
        public async Task<IActionResult> Index()
        {
              return _context.Memories != null ? 
                          View(await _context.Memories.ToListAsync()) :
                          Problem("Entity set 'AppDbContext.Memories'  is null.");
        }

        // GET: Memories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Memories == null)
            {
                return NotFound();
            }

            var memory = await _context.Memories
                .FirstOrDefaultAsync(m => m.MemoryID == id);
            if (memory == null)
            {
                return NotFound();
            }

            return View(memory);
        }

        // GET: Memories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Memories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MemoryID,MemoryDescription,MemoryPictureURL,MemoryPrice")] Memory memory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(memory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(memory);
        }

        // GET: Memories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Memories == null)
            {
                return NotFound();
            }

            var memory = await _context.Memories.FindAsync(id);
            if (memory == null)
            {
                return NotFound();
            }
            return View(memory);
        }

        // POST: Memories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MemoryID,MemoryDescription,MemoryPictureURL,MemoryPrice")] Memory memory)
        {
            if (id != memory.MemoryID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(memory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MemoryExists(memory.MemoryID))
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
            return View(memory);
        }

        // GET: Memories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Memories == null)
            {
                return NotFound();
            }

            var memory = await _context.Memories
                .FirstOrDefaultAsync(m => m.MemoryID == id);
            if (memory == null)
            {
                return NotFound();
            }

            return View(memory);
        }

        // POST: Memories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Memories == null)
            {
                return Problem("Entity set 'AppDbContext.Memories'  is null.");
            }
            var memory = await _context.Memories.FindAsync(id);
            if (memory != null)
            {
                _context.Memories.Remove(memory);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MemoryExists(int id)
        {
          return (_context.Memories?.Any(e => e.MemoryID == id)).GetValueOrDefault();
        }
    }
}
