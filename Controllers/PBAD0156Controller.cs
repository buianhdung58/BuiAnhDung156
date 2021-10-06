using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BuiAnhDung156.Models;

namespace BuiAnhDung156.Controllers
{
    public class PBAD0156Controller : Controller
    {
        private readonly BUIANHDUNG156 _context;

        public PBAD0156Controller(BUIANHDUNG156 context)
        {
            _context = context;
        }

        // GET: PBAD0156
        public async Task<IActionResult> Index()
        {
            return View(await _context.BAD0156.ToListAsync());
        }

        // GET: PBAD0156/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bAD0156 = await _context.BAD0156
                .FirstOrDefaultAsync(m => m.NVNId == id);
            if (bAD0156 == null)
            {
                return NotFound();
            }

            return View(bAD0156);
        }

        // GET: PBAD0156/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PBAD0156/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NVNId,NVNName,NVNGender")] BAD0156 bAD0156)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bAD0156);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bAD0156);
        }

        // GET: PBAD0156/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bAD0156 = await _context.BAD0156.FindAsync(id);
            if (bAD0156 == null)
            {
                return NotFound();
            }
            return View(bAD0156);
        }

        // POST: PBAD0156/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("NVNId,NVNName,NVNGender")] BAD0156 bAD0156)
        {
            if (id != bAD0156.NVNId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bAD0156);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BAD0156Exists(bAD0156.NVNId))
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
            return View(bAD0156);
        }

        // GET: PBAD0156/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bAD0156 = await _context.BAD0156
                .FirstOrDefaultAsync(m => m.NVNId == id);
            if (bAD0156 == null)
            {
                return NotFound();
            }

            return View(bAD0156);
        }

        // POST: PBAD0156/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var bAD0156 = await _context.BAD0156.FindAsync(id);
            _context.BAD0156.Remove(bAD0156);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BAD0156Exists(string id)
        {
            return _context.BAD0156.Any(e => e.NVNId == id);
        }
    }
}
