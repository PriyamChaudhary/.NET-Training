using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StudentPortal.Models;
using StudentPortal.Services;

namespace StudentPortal.Controllers
{
    public class StudentsController : Controller
    {
        private readonly IStudentService _service;

        public StudentsController(IStudentService service)
        {
            _service = service;
        }

        // GET: Students
        public async Task<IActionResult> Index(string q)
        {
            var students = await _service.SearchAsync(q);
            ViewBag.Query = q;
            return View(students);
        }

        // AJAX Search
        [HttpGet]
        public async Task<IActionResult> Search(string q)
        {
            var students = await _service.SearchAsync(q);
            return Json(students);
        }

        // GET: Details
        public async Task<IActionResult> Details(int id)
        {
            var student = await _service.GetByIdAsync(id);
            if (student == null)
                return NotFound();

            return View(student);
        }

        // GET: Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Student student)
        {
            if (!ModelState.IsValid)
                return View(student);

            await _service.AddAsync(student);
            return RedirectToAction(nameof(Index));
        }

        // GET: Edit
        public async Task<IActionResult> Edit(int id)
        {
            var student = await _service.GetByIdAsync(id);
            if (student == null)
                return NotFound();

            return View(student);
        }

        // POST: Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Student student)
        {
            if (id != student.StudentId)
                return NotFound();

            if (!ModelState.IsValid)
                return View(student);

            await _service.UpdateAsync(student);
            return RedirectToAction(nameof(Index));
        }

        // GET: Delete
        public async Task<IActionResult> Delete(int id)
        {
            var student = await _service.GetByIdAsync(id);
            if (student == null)
                return NotFound();

            return View(student);
        }

        // POST: Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}