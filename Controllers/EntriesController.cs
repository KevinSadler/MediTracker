using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MediTracker.Data;
using MediTracker.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using MediTracker.Models.ViewModels;

namespace MediTracker.Controllers
{
    [Authorize]
    public class EntriesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public EntriesController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Entries
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            var entries = await _context.Entries.Include(e => e.EntrySymptoms).ThenInclude(e => e.Symptom).Where(e => e.UserId == user.Id).OrderByDescending(e => e.Date).ToListAsync();
            //foreach (var e in entries) {
               //var numSymptoms =  _context.EntrySymptoms.Select(es => es.EntryId).Where(id => id == e.EntryId).Count();
                //var symptomsToUse = _context.EntrySymptoms.Include(es => es.Symptom).Where(es => es.EntryId == e.EntryId).ToList();
                //e.NumOfSymptoms = numSymptoms;
                //e.Symptoms = symptomsToUse;
            //}
            return View(entries);
        }

        // GET: Entries/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var entry = await _context.Entries
                .Include(e => e.User)
                .Include(e => e.EntrySymptoms)
                .ThenInclude(e => e.Symptom)
                .FirstOrDefaultAsync(m => m.EntryId == id);
            //var symptomsToUse = _context.EntrySymptoms.Include(es => es.Symptom).Where(es => es.EntryId == entry.EntryId).ToList();
            //entry.Symptoms = symptomsToUse;
            if (entry == null)
            {
                return NotFound();
            }

            return View(entry);
        }

        // GET: Entries/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Entries/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EntryId,Date,Notes,UserId")] Entry entry)
        {
            ModelState.Remove("User");
            ModelState.Remove("UserId");
            if (ModelState.IsValid)
            {
                var user = await _userManager.GetUserAsync(HttpContext.User);
                entry.User = user;
                entry.UserId = user.Id;
                _context.Add(entry);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = new SelectList(_context.ApplicationUsers, "Id", "Id", entry.UserId);
            return View(entry);
        }

        // GET: Entries/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _userManager.GetUserAsync(HttpContext.User);

            var entry = await _context.Entries.Include(e => e.EntrySymptoms).FirstOrDefaultAsync(e => e.EntryId == id);
            //entry.Symptoms = await _context.EntrySymptoms.Include(es => es.Symptom).Where(es => es.EntryId == entry.EntryId).ToListAsync();
            var viewModel = new EntryEditViewModel()
            {
                Entry = entry,
                AllSymptoms = await _context.Symptoms.Where(s => s.UserId == user.Id).ToListAsync(),
                SelectedSymptomIds = entry.EntrySymptoms.Select(s => s.SymptomId).ToList()
            };
            if (entry == null)
            {
                return NotFound();
            }
            return View(viewModel);
        }

        // POST: Entries/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, EntryEditViewModel viewModel)
        {
            if (id != viewModel.Entry.EntryId)
            {
                return NotFound();
            }
            ModelState.Remove("Entry.User");
            ModelState.Remove("Entry.UserId");
            if (ModelState.IsValid)
            {
                try
                {
                    var user = await _userManager.GetUserAsync(HttpContext.User);
                    var idsToUse = viewModel.SelectedSymptomIds;
                    List<EntrySymptom> symptomsToDelete = _context.EntrySymptoms.Where(es => es.EntryId == viewModel.Entry.EntryId).ToList();
                    List<Symptom> symptomsToUse = _context.Symptoms.Where(s => idsToUse.Contains(s.SymptomId)).ToList();
                    viewModel.Entry.User = user;
                    viewModel.Entry.UserId = user.Id;
                    foreach (var s in symptomsToDelete)
                    {
                        _context.EntrySymptoms.Remove(s);
                       await _context.SaveChangesAsync();
                    }
                    foreach (var s in symptomsToUse)
                    {
                        EntrySymptom newES = new EntrySymptom()
                        {
                            EntryId = viewModel.Entry.EntryId,
                            Entry = viewModel.Entry,
                            SymptomId = s.SymptomId,
                            Symptom = s
                        };
                        _context.EntrySymptoms.Add(newES);
                        //viewModel.Entry.EntrySymptoms.Add(newES);
                    }
                    _context.Entries.Update(viewModel.Entry);
                    await _context.SaveChangesAsync();

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EntryExists(viewModel.Entry.EntryId))
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
            return View(viewModel.Entry);
        }

        // GET: Entries/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var entry = await _context.Entries
                .Include(e => e.User)
                .Include(e => e.EntrySymptoms)
                .FirstOrDefaultAsync(e => e.EntryId == id);
            //var symptomsToUse = _context.EntrySymptoms.Include(es => es.Symptom).Where(es => es.EntryId == entry.EntryId).ToList();
            //entry.Symptoms = symptomsToUse;
            if (entry == null)
            {
                return NotFound();
            }

            return View(entry);
        }

        // POST: Entries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var entry = await _context.Entries.FindAsync(id);
            _context.Entries.Remove(entry);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EntryExists(int id)
        {
            return _context.Entries.Any(e => e.EntryId == id);
        }
    }
}
