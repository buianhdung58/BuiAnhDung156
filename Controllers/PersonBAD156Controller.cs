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
    public class PersonBAD156Controller : Controller
    {
        private readonly BUIANHDUNG156 _context;

        public PersonBAD156Controller(BUIANHDUNG156 context)
        {
            _context = context;
        }

        // GET: PersonBAD156
        public async Task<IActionResult> Index()
        {
            return View(await _context.PersonBAD156.ToListAsync());
        }

        // GET: PersonBAD156/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personBAD156 = await _context.PersonBAD156
                .FirstOrDefaultAsync(m => m.PersonId == id);
            if (personBAD156 == null)
            {
                return NotFound();
            }

            return View(personBAD156);
        }

        // GET: PersonBAD156/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PersonBAD156/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PersonId,PersonName")] PersonBAD156 personBAD156)
        {
            if (ModelState.IsValid)
            {
                _context.Add(personBAD156);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(personBAD156);
        }

        // GET: PersonBAD156/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personBAD156 = await _context.PersonBAD156.FindAsync(id);
            if (personBAD156 == null)
            {
                return NotFound();
            }
            return View(personBAD156);
        }

        // POST: PersonBAD156/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("PersonId,PersonName")] PersonBAD156 personBAD156)
        {
            if (id != personBAD156.PersonId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(personBAD156);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonBAD156Exists(personBAD156.PersonId))
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
            return View(personBAD156);
        }

        // GET: PersonBAD156/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personBAD156 = await _context.PersonBAD156
                .FirstOrDefaultAsync(m => m.PersonId == id);
            if (personBAD156 == null)
            {
                return NotFound();
            }

            return View(personBAD156);
        }

        // POST: PersonBAD156/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var personBAD156 = await _context.PersonBAD156.FindAsync(id);
            _context.PersonBAD156.Remove(personBAD156);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PersonBAD156Exists(string id)
        {
            return _context.PersonBAD156.Any(e => e.PersonId == id);
        }
    }
}
