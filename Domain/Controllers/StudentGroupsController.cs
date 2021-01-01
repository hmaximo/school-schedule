using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Domain.Models;

namespace Domain.Controllers
{
    public class StudentGroupsController : Controller
    {
        private readonly Context _context;

        public StudentGroupsController(Context context)
        {
            _context = context;
        }

        // GET: StudentGroups
        public async Task<IActionResult> Index()
        {
            return View(await _context.StudentGroup.ToListAsync());
        }

        // GET: StudentGroups/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentGroup = await _context.StudentGroup
                .FirstOrDefaultAsync(m => m.Id == id);
            if (studentGroup == null)
            {
                return NotFound();
            }

            return View(studentGroup);
        }

        // GET: StudentGroups/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: StudentGroups/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,SchoolYear,ClassesPerWeek")] StudentGroup studentGroup)
        {
            if (ModelState.IsValid)
            {
                _context.Add(studentGroup);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(studentGroup);
        }

        // GET: StudentGroups/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentGroup = await _context.StudentGroup.FindAsync(id);
            if (studentGroup == null)
            {
                return NotFound();
            }
            return View(studentGroup);
        }

        // POST: StudentGroups/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,SchoolYear,ClassesPerWeek")] StudentGroup studentGroup)
        {
            if (id != studentGroup.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(studentGroup);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentGroupExists(studentGroup.Id))
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
            return View(studentGroup);
        }

        // GET: StudentGroups/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentGroup = await _context.StudentGroup
                .FirstOrDefaultAsync(m => m.Id == id);
            if (studentGroup == null)
            {
                return NotFound();
            }

            return View(studentGroup);
        }

        // POST: StudentGroups/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var studentGroup = await _context.StudentGroup.FindAsync(id);
            _context.StudentGroup.Remove(studentGroup);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StudentGroupExists(int id)
        {
            return _context.StudentGroup.Any(e => e.Id == id);
        }
    }
}
