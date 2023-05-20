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
    public class CustomerConfiguredModelPaymentsController : Controller
    {
        private readonly AppDbContext _context;

        public CustomerConfiguredModelPaymentsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: CustomerConfiguredModelPayments
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.CustomerConfiguredModelPayments.Include(c => c.CustomerConfiguredModelOrder);
            return View(await appDbContext.ToListAsync());
        }

        // GET: CustomerConfiguredModelPayments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.CustomerConfiguredModelPayments == null)
            {
                return NotFound();
            }

            var customerConfiguredModelPayment = await _context.CustomerConfiguredModelPayments
                .Include(c => c.CustomerConfiguredModelOrder)
                .FirstOrDefaultAsync(m => m.CustomerConfiguredModelPaymentID == id);
            if (customerConfiguredModelPayment == null)
            {
                return NotFound();
            }

            return View(customerConfiguredModelPayment);
        }

        // GET: CustomerConfiguredModelPayments/Create
        public IActionResult Create()
        {
            ViewData["CustomerConfiguredModelOrderID"] = new SelectList(_context.CustomerConfiguredModelOrders, "CustomerConfiguredModelOrderID", "CustomerConfiguredModelOrderID");
            return View();
        }

        // POST: CustomerConfiguredModelPayments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CustomerConfiguredModelPaymentID,Amount,PaymentDate,PaymentMethod,CustomerConfiguredModelOrderID")] CustomerConfiguredModelPayment customerConfiguredModelPayment)
        {
            if (ModelState.IsValid)
            {
                _context.Add(customerConfiguredModelPayment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CustomerConfiguredModelOrderID"] = new SelectList(_context.CustomerConfiguredModelOrders, "CustomerConfiguredModelOrderID", "CustomerConfiguredModelOrderID", customerConfiguredModelPayment.CustomerConfiguredModelOrderID);
            return View(customerConfiguredModelPayment);
        }

        // GET: CustomerConfiguredModelPayments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.CustomerConfiguredModelPayments == null)
            {
                return NotFound();
            }

            var customerConfiguredModelPayment = await _context.CustomerConfiguredModelPayments.FindAsync(id);
            if (customerConfiguredModelPayment == null)
            {
                return NotFound();
            }
            ViewData["CustomerConfiguredModelOrderID"] = new SelectList(_context.CustomerConfiguredModelOrders, "CustomerConfiguredModelOrderID", "CustomerConfiguredModelOrderID", customerConfiguredModelPayment.CustomerConfiguredModelOrderID);
            return View(customerConfiguredModelPayment);
        }

        // POST: CustomerConfiguredModelPayments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CustomerConfiguredModelPaymentID,Amount,PaymentDate,PaymentMethod,CustomerConfiguredModelOrderID")] CustomerConfiguredModelPayment customerConfiguredModelPayment)
        {
            if (id != customerConfiguredModelPayment.CustomerConfiguredModelPaymentID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customerConfiguredModelPayment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerConfiguredModelPaymentExists(customerConfiguredModelPayment.CustomerConfiguredModelPaymentID))
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
            ViewData["CustomerConfiguredModelOrderID"] = new SelectList(_context.CustomerConfiguredModelOrders, "CustomerConfiguredModelOrderID", "CustomerConfiguredModelOrderID", customerConfiguredModelPayment.CustomerConfiguredModelOrderID);
            return View(customerConfiguredModelPayment);
        }

        // GET: CustomerConfiguredModelPayments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.CustomerConfiguredModelPayments == null)
            {
                return NotFound();
            }

            var customerConfiguredModelPayment = await _context.CustomerConfiguredModelPayments
                .Include(c => c.CustomerConfiguredModelOrder)
                .FirstOrDefaultAsync(m => m.CustomerConfiguredModelPaymentID == id);
            if (customerConfiguredModelPayment == null)
            {
                return NotFound();
            }

            return View(customerConfiguredModelPayment);
        }

        // POST: CustomerConfiguredModelPayments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.CustomerConfiguredModelPayments == null)
            {
                return Problem("Entity set 'AppDbContext.CustomerConfiguredModelPayments'  is null.");
            }
            var customerConfiguredModelPayment = await _context.CustomerConfiguredModelPayments.FindAsync(id);
            if (customerConfiguredModelPayment != null)
            {
                _context.CustomerConfiguredModelPayments.Remove(customerConfiguredModelPayment);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CustomerConfiguredModelPaymentExists(int id)
        {
          return (_context.CustomerConfiguredModelPayments?.Any(e => e.CustomerConfiguredModelPaymentID == id)).GetValueOrDefault();
        }
    }
}
