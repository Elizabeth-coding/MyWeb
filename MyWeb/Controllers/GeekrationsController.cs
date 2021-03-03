using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyWeb.Data;
using MyWeb.Models;

namespace MyWeb.Controllers
{
    public class GeekrationsController : Controller
    {
        private readonly Info _context;

        public GeekrationsController(Info context)
        {
            _context = context;
        }

        // GET: Geekrations
        public async Task<IActionResult> Index(string searchString)
        {
            var movies = from m in _context.Geekration
                         select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                movies = movies.Where(s => s.Passions.Contains(searchString));
            }

            return View(await movies.ToListAsync());
        }

        // GET: Geekrations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var geekration = await _context.Geekration
                .FirstOrDefaultAsync(m => m.Id == id);
            if (geekration == null)
            {
                return NotFound();
            }

            return View(geekration);
        }
        public async Task<IActionResult> Geeksign(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var geekration = await _context.Geekration
                .FirstOrDefaultAsync(m => m.Id == id);
            if (geekration == null)
            {
                return NotFound();
            }

            return View(geekration);
        }

        // GET: Geekrations/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Geekrations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Passions,Hobbies,Your_Values,Change,MyLife,geeky1,geeky2")] Geekration geekration)
        {
            if (ModelState.IsValid)
            {
                _context.Add(geekration);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(geekration);
        }

        // GET: Geekrations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var geekration = await _context.Geekration.FindAsync(id);
            if (geekration == null)
            {
                return NotFound();
            }
            return View(geekration);
        }

        // POST: Geekrations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Passions,Hobbies,Your_Values,Change,MyLife,geeky1,geeky2")] Geekration geekration)
        {
            if (id != geekration.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(geekration);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GeekrationExists(geekration.Id))
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
            return View(geekration);
        }

        // GET: Geekrations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var geekration = await _context.Geekration
                .FirstOrDefaultAsync(m => m.Id == id);
            if (geekration == null)
            {
                return NotFound();
            }

            return View(geekration);
        }

        // POST: Geekrations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var geekration = await _context.Geekration.FindAsync(id);
            _context.Geekration.Remove(geekration);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GeekrationExists(int id)
        {
            return _context.Geekration.Any(e => e.Id == id);
        }
    }
}
