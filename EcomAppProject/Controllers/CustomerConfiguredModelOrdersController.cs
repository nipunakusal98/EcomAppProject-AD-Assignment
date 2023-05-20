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
    public class CustomerConfiguredModelOrdersController : Controller
    {
        private readonly AppDbContext _context;

        public CustomerConfiguredModelOrdersController(AppDbContext context)
        {
            _context = context;
        }

        // GET: CustomerConfiguredModelOrders
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.CustomerConfiguredModelOrders.Include(c => c.CustomerConfiguration);
            return View(await appDbContext.ToListAsync());
        }

        // GET: CustomerConfiguredModelOrders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.CustomerConfiguredModelOrders == null)
            {
                return NotFound();
            }

            var customerConfiguredModelOrder = await _context.CustomerConfiguredModelOrders
                .Include(c => c.CustomerConfiguration)
                .FirstOrDefaultAsync(m => m.CustomerConfiguredModelOrderID == id);
            if (customerConfiguredModelOrder == null)
            {
                return NotFound();
            }

            return View(customerConfiguredModelOrder);
        }

        // GET: CustomerConfiguredModelOrders/Create
        public IActionResult Create()
        {
            ViewData["CustomerConfigID"] = new SelectList(_context.CustomerConfigurations, "CustomerConfigID", "CustomerConfigID");
            return View();
        }

        // POST: CustomerConfiguredModelOrders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CustomerConfiguredModelOrderID,ShippingAddress,BillingAddress,ShippingMethod,OrderDate,TotalAmount,OrderStatus,ConfigurationPrice,CustomerConfigID")] CustomerConfiguredModelOrder customerConfiguredModelOrder)
        {
            if (ModelState.IsValid)
            {
                _context.Add(customerConfiguredModelOrder);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CustomerConfigID"] = new SelectList(_context.CustomerConfigurations, "CustomerConfigID", "CustomerConfigID", customerConfiguredModelOrder.CustomerConfigID);
            return View(customerConfiguredModelOrder);
        }

        // GET: CustomerConfiguredModelOrders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.CustomerConfiguredModelOrders == null)
            {
                return NotFound();
            }

            var customerConfiguredModelOrder = await _context.CustomerConfiguredModelOrders.FindAsync(id);
            if (customerConfiguredModelOrder == null)
            {
                return NotFound();
            }
            ViewData["CustomerConfigID"] = new SelectList(_context.CustomerConfigurations, "CustomerConfigID", "CustomerConfigID", customerConfiguredModelOrder.CustomerConfigID);
            return View(customerConfiguredModelOrder);
        }

        // POST: CustomerConfiguredModelOrders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CustomerConfiguredModelOrderID,ShippingAddress,BillingAddress,ShippingMethod,OrderDate,TotalAmount,OrderStatus,ConfigurationPrice,CustomerConfigID")] CustomerConfiguredModelOrder customerConfiguredModelOrder)
        {
            if (id != customerConfiguredModelOrder.CustomerConfiguredModelOrderID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customerConfiguredModelOrder);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerConfiguredModelOrderExists(customerConfiguredModelOrder.CustomerConfiguredModelOrderID))
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
            ViewData["CustomerConfigID"] = new SelectList(_context.CustomerConfigurations, "CustomerConfigID", "CustomerConfigID", customerConfiguredModelOrder.CustomerConfigID);
            return View(customerConfiguredModelOrder);
        }

        // GET: CustomerConfiguredModelOrders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.CustomerConfiguredModelOrders == null)
            {
                return NotFound();
            }

            var customerConfiguredModelOrder = await _context.CustomerConfiguredModelOrders
                .Include(c => c.CustomerConfiguration)
                .FirstOrDefaultAsync(m => m.CustomerConfiguredModelOrderID == id);
            if (customerConfiguredModelOrder == null)
            {
                return NotFound();
            }

            return View(customerConfiguredModelOrder);
        }

        // POST: CustomerConfiguredModelOrders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.CustomerConfiguredModelOrders == null)
            {
                return Problem("Entity set 'AppDbContext.CustomerConfiguredModelOrders'  is null.");
            }
            var customerConfiguredModelOrder = await _context.CustomerConfiguredModelOrders.FindAsync(id);
            if (customerConfiguredModelOrder != null)
            {
                _context.CustomerConfiguredModelOrders.Remove(customerConfiguredModelOrder);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CustomerConfiguredModelOrderExists(int id)
        {
          return (_context.CustomerConfiguredModelOrders?.Any(e => e.CustomerConfiguredModelOrderID == id)).GetValueOrDefault();
        }
    }
}
