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
    public class CustomerConfigurationsController : Controller
    {
        private readonly AppDbContext _context;

        public CustomerConfigurationsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: CustomerConfigurations
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.CustomerConfigurations.Include(c => c.Antivirus).Include(c => c.Customer).Include(c => c.Memory).Include(c => c.Model).Include(c => c.Processor).Include(c => c.VGA);
            return View(await appDbContext.ToListAsync());
        }

        // GET: CustomerConfigurations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.CustomerConfigurations == null)
            {
                return NotFound();
            }

            var customerConfiguration = await _context.CustomerConfigurations
                .Include(c => c.Antivirus)
                .Include(c => c.Customer)
                .Include(c => c.Memory)
                .Include(c => c.Model)
                .Include(c => c.Processor)
                .Include(c => c.VGA)
                .FirstOrDefaultAsync(m => m.CustomerConfigID == id);
            if (customerConfiguration == null)
            {
                return NotFound();
            }

            return View(customerConfiguration);
        }

        // GET: CustomerConfigurations/Create
        public IActionResult Create()
        {
            ViewData["AntivirusID"] = new SelectList(_context.AntivirusSoftwares, "AntivirusID", "AntivirusID");
            ViewData["CustomerID"] = new SelectList(_context.Customers, "CustomerID", "CustomerID");
            ViewData["MemoryID"] = new SelectList(_context.Memories, "MemoryID", "MemoryID");
            ViewData["ModelID"] = new SelectList(_context.Models, "ModelID", "ModelID");
            ViewData["ProcessorID"] = new SelectList(_context.Processors, "ProcessorID", "ProcessorID");
            ViewData["VGAID"] = new SelectList(_context.VGAs, "VGAID", "VGAID");
            return View();
        }

        // POST: CustomerConfigurations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CustomerConfigID,CustomerID,ModelID,ProcessorID,MemoryID,VGAID,AntivirusID,ConfigurationPrice")] CustomerConfiguration customerConfiguration)
        {
            if (ModelState.IsValid)
            {
                _context.Add(customerConfiguration);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AntivirusID"] = new SelectList(_context.AntivirusSoftwares, "AntivirusID", "AntivirusID", customerConfiguration.AntivirusID);
            ViewData["CustomerID"] = new SelectList(_context.Customers, "CustomerID", "CustomerID", customerConfiguration.CustomerID);
            ViewData["MemoryID"] = new SelectList(_context.Memories, "MemoryID", "MemoryID", customerConfiguration.MemoryID);
            ViewData["ModelID"] = new SelectList(_context.Models, "ModelID", "ModelID", customerConfiguration.ModelID);
            ViewData["ProcessorID"] = new SelectList(_context.Processors, "ProcessorID", "ProcessorID", customerConfiguration.ProcessorID);
            ViewData["VGAID"] = new SelectList(_context.VGAs, "VGAID", "VGAID", customerConfiguration.VGAID);
            return View(customerConfiguration);
        }

        // GET: CustomerConfigurations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.CustomerConfigurations == null)
            {
                return NotFound();
            }

            var customerConfiguration = await _context.CustomerConfigurations.FindAsync(id);
            if (customerConfiguration == null)
            {
                return NotFound();
            }
            ViewData["AntivirusID"] = new SelectList(_context.AntivirusSoftwares, "AntivirusID", "AntivirusID", customerConfiguration.AntivirusID);
            ViewData["CustomerID"] = new SelectList(_context.Customers, "CustomerID", "CustomerID", customerConfiguration.CustomerID);
            ViewData["MemoryID"] = new SelectList(_context.Memories, "MemoryID", "MemoryID", customerConfiguration.MemoryID);
            ViewData["ModelID"] = new SelectList(_context.Models, "ModelID", "ModelID", customerConfiguration.ModelID);
            ViewData["ProcessorID"] = new SelectList(_context.Processors, "ProcessorID", "ProcessorID", customerConfiguration.ProcessorID);
            ViewData["VGAID"] = new SelectList(_context.VGAs, "VGAID", "VGAID", customerConfiguration.VGAID);
            return View(customerConfiguration);
        }

        // POST: CustomerConfigurations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CustomerConfigID,CustomerID,ModelID,ProcessorID,MemoryID,VGAID,AntivirusID,ConfigurationPrice")] CustomerConfiguration customerConfiguration)
        {
            if (id != customerConfiguration.CustomerConfigID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customerConfiguration);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerConfigurationExists(customerConfiguration.CustomerConfigID))
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
            ViewData["AntivirusID"] = new SelectList(_context.AntivirusSoftwares, "AntivirusID", "AntivirusID", customerConfiguration.AntivirusID);
            ViewData["CustomerID"] = new SelectList(_context.Customers, "CustomerID", "CustomerID", customerConfiguration.CustomerID);
            ViewData["MemoryID"] = new SelectList(_context.Memories, "MemoryID", "MemoryID", customerConfiguration.MemoryID);
            ViewData["ModelID"] = new SelectList(_context.Models, "ModelID", "ModelID", customerConfiguration.ModelID);
            ViewData["ProcessorID"] = new SelectList(_context.Processors, "ProcessorID", "ProcessorID", customerConfiguration.ProcessorID);
            ViewData["VGAID"] = new SelectList(_context.VGAs, "VGAID", "VGAID", customerConfiguration.VGAID);
            return View(customerConfiguration);
        }

        // GET: CustomerConfigurations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.CustomerConfigurations == null)
            {
                return NotFound();
            }

            var customerConfiguration = await _context.CustomerConfigurations
                .Include(c => c.Antivirus)
                .Include(c => c.Customer)
                .Include(c => c.Memory)
                .Include(c => c.Model)
                .Include(c => c.Processor)
                .Include(c => c.VGA)
                .FirstOrDefaultAsync(m => m.CustomerConfigID == id);
            if (customerConfiguration == null)
            {
                return NotFound();
            }

            return View(customerConfiguration);
        }

        // POST: CustomerConfigurations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.CustomerConfigurations == null)
            {
                return Problem("Entity set 'AppDbContext.CustomerConfigurations'  is null.");
            }
            var customerConfiguration = await _context.CustomerConfigurations.FindAsync(id);
            if (customerConfiguration != null)
            {
                _context.CustomerConfigurations.Remove(customerConfiguration);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CustomerConfigurationExists(int id)
        {
          return (_context.CustomerConfigurations?.Any(e => e.CustomerConfigID == id)).GetValueOrDefault();
        }
    }
}
