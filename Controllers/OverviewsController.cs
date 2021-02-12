using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AddressBook.Data;
using AddressBook.Models;

namespace AddressBook.Controllers
{
    public class OverviewsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OverviewsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Overviews
        public async Task<IActionResult> Index()
        {
            return View(await _context.Overview.ToListAsync());
        }

        // GET: Overviews/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var overview = await _context.Overview
                .FirstOrDefaultAsync(m => m.Id == id);
            if (overview == null)
            {
                return NotFound();
            }

            return View(overview);
        }

        // GET: Overviews/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Overviews/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserId,FirstName,LastName,PersonalEmail,WorkEmail,MobilePhone,WorkPhone,HomePhone,Address1,Address2,City,State,Zip,Company,Fax")] Overview overview)
        {
            if (ModelState.IsValid)
            {
                _context.Add(overview);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(overview);
        }

        // GET: Overviews/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var overview = await _context.Overview.FindAsync(id);
            if (overview == null)
            {
                return NotFound();
            }
            return View(overview);
        }

        // POST: Overviews/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UserId,FirstName,LastName,PersonalEmail,WorkEmail,MobilePhone,WorkPhone,HomePhone,Address1,Address2,City,State,Zip,Company,Fax")] Overview overview)
        {
            if (id != overview.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(overview);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OverviewExists(overview.Id))
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
            return View(overview);
        }

        // GET: Overviews/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var overview = await _context.Overview
                .FirstOrDefaultAsync(m => m.Id == id);
            if (overview == null)
            {
                return NotFound();
            }

            return View(overview);
        }

        // POST: Overviews/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var overview = await _context.Overview.FindAsync(id);
            _context.Overview.Remove(overview);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OverviewExists(int id)
        {
            return _context.Overview.Any(e => e.Id == id);
        }
    }
}
