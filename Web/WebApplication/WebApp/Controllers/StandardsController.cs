using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApp.Data;
using WebApp.Models;

namespace WebApp.Controllers
{
    [Authorize]
    public class StandardsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StandardsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Standards
        public async Task<IActionResult> Index()
        {
            return _context.Standards != null ?
                        View(await _context.Standards.ToListAsync()) :
                        Problem("Entity set 'ApplicationDbContext.Standards'  is null.");
        }

        // GET: Standards/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Standards == null)
            {
                return NotFound();
            }

            var standards = await _context.Standards
                .FirstOrDefaultAsync(m => m.Id == id);
            if (standards == null)
            {
                return NotFound();
            }

            return View(standards);
        }

        // GET: Standards/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Standards/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description")] Standards standards)
        {
            if (ModelState.IsValid)
            {
                _context.Add(standards);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(standards);
        }

        // GET: Standards/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Standards == null)
            {
                return NotFound();
            }

            var standards = await _context.Standards.FindAsync(id);
            if (standards == null)
            {
                return NotFound();
            }
            return View(standards);
        }

        // POST: Standards/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description")] Standards standards)
        {
            if (id != standards.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(standards);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StandardsExists(standards.Id))
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
            return View(standards);
        }

        // GET: Standards/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Standards == null)
            {
                return NotFound();
            }

            var standards = await _context.Standards
                .FirstOrDefaultAsync(m => m.Id == id);
            if (standards == null)
            {
                return NotFound();
            }

            return View(standards);
        }

        // POST: Standards/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Standards == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Standards'  is null.");
            }
            var standards = await _context.Standards.FindAsync(id);
            if (standards != null)
            {
                _context.Standards.Remove(standards);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StandardsExists(int id)
        {
            return (_context.Standards?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}