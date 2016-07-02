using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApp.Models;
using WebApp.Models.WebApp;

namespace WebApp.Controllers
{
    public class JobInfoController : Controller
    {
        private readonly WebAppDbContext _context;

        public JobInfoController(WebAppDbContext context)
        {
            _context = context;    
        }

        // GET: JobInfo
        public async Task<IActionResult> Index()
        {
            return View(await _context.JobInfo.ToListAsync());
        }

        // GET: JobInfo/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobInfo = await _context.JobInfo.SingleOrDefaultAsync(m => m.jobID == id);
            if (jobInfo == null)
            {
                return NotFound();
            }

            return View(jobInfo);
        }

        // GET: JobInfo/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: JobInfo/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("jobID,deadline,employeer,employeerLogo,jobDescriptions,jobTitle,requirements,views")] JobInfo jobInfo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(jobInfo);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(jobInfo);
        }

        // GET: JobInfo/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobInfo = await _context.JobInfo.SingleOrDefaultAsync(m => m.jobID == id);
            if (jobInfo == null)
            {
                return NotFound();
            }
            return View(jobInfo);
        }

        // POST: JobInfo/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("jobID,deadline,employeer,employeerLogo,jobDescriptions,jobTitle,requirements,views")] JobInfo jobInfo)
        {
            if (id != jobInfo.jobID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(jobInfo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JobInfoExists(jobInfo.jobID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(jobInfo);
        }

        // GET: JobInfo/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobInfo = await _context.JobInfo.SingleOrDefaultAsync(m => m.jobID == id);
            if (jobInfo == null)
            {
                return NotFound();
            }

            return View(jobInfo);
        }

        // POST: JobInfo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var jobInfo = await _context.JobInfo.SingleOrDefaultAsync(m => m.jobID == id);
            _context.JobInfo.Remove(jobInfo);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool JobInfoExists(int id)
        {
            return _context.JobInfo.Any(e => e.jobID == id);
        }
    }
}
