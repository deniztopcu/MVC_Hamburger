using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVC_Hamburger.DAL;
using MVC_Hamburger.Models.Concrete;

namespace MVC_Hamburger.Areas.UyePaneli.Controllers
{
    [Area("UyePaneli")]
    public class SiparisController : Controller
    {
        private readonly HamburgerDbContext _context;

        public SiparisController(HamburgerDbContext context)
        {
            _context = context;
        }

        // GET: UyePaneli/Siparis
        public async Task<IActionResult> Index()
        {
            var hamburgerDbContext = _context.Siparisler.Include(s => s.Uye);
            return View(await hamburgerDbContext.ToListAsync());
        }

        // GET: UyePaneli/Siparis/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var siparis = await _context.Siparisler
                .Include(s => s.Uye)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (siparis == null)
            {
                return NotFound();
            }

            return View(siparis);
        }

        // GET: UyePaneli/Siparis/Create
        public IActionResult Create()
        {
            ViewData["UyeID"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: UyePaneli/Siparis/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,MenuAdet,ToplamFiyat,OlusturulmaTarihi,UyeID")] Siparis siparis)
        {
            if (ModelState.IsValid)
            {
                _context.Add(siparis);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UyeID"] = new SelectList(_context.Users, "Id", "Id", siparis.UyeID);
            return View(siparis);
        }

        // GET: UyePaneli/Siparis/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var siparis = await _context.Siparisler.FindAsync(id);
            if (siparis == null)
            {
                return NotFound();
            }
            ViewData["UyeID"] = new SelectList(_context.Users, "Id", "Id", siparis.UyeID);
            return View(siparis);
        }

        // POST: UyePaneli/Siparis/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,MenuAdet,ToplamFiyat,OlusturulmaTarihi,UyeID")] Siparis siparis)
        {
            if (id != siparis.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(siparis);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SiparisExists(siparis.ID))
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
            ViewData["UyeID"] = new SelectList(_context.Users, "Id", "Id", siparis.UyeID);
            return View(siparis);
        }

        // GET: UyePaneli/Siparis/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var siparis = await _context.Siparisler
                .Include(s => s.Uye)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (siparis == null)
            {
                return NotFound();
            }

            return View(siparis);
        }

        // POST: UyePaneli/Siparis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var siparis = await _context.Siparisler.FindAsync(id);
            if (siparis != null)
            {
                _context.Siparisler.Remove(siparis);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SiparisExists(int id)
        {
            return _context.Siparisler.Any(e => e.ID == id);
        }
    }
}
