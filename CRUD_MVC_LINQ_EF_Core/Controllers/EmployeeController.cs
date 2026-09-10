using System.Linq;
using Microsoft.EntityFrameworkCore;
using CRUD_MVC_LINQ_EF_Core.Data;
using CRUD_MVC_LINQ_EF_Core.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace CRUD_MVC_LINQ_EF_Core.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EmployeeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // READ: Display all records using LINQ
        public async Task<IActionResult> Index()
        {
            var employees = await (from emp in _context.Employees
                                   orderby emp.id ascending
                                   select emp).ToListAsync();
            return View(employees);
        }

        // CREATE: GET
        public IActionResult Create()
        {
            return View();
        }

        // CREATE: POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _context.Employees.Add(employee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }

        // EDIT: GET (Retrieve record with LINQ)
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            var employee = await (from emp in _context.Employees
                                  where emp.id == id
                                  select emp).FirstOrDefaultAsync();

            if (employee == null) return NotFound();

            return View(employee);
        }

        // EDIT: POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Employee employee)
        {
            if (id != employee.id) return NotFound();

            if (ModelState.IsValid)
            {
                _context.Update(employee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }

        // DELETE: GET confirmation
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var employee = await _context.Employees
                                         .FirstOrDefaultAsync(m => m.id == id);

            if (employee == null) return NotFound();

            return View(employee);
        }

        // DELETE: POST confirmation
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employee = await (from emp in _context.Employees
                                  where emp.id == id
                                  select emp).FirstOrDefaultAsync();

            if (employee != null)
            {
                _context.Employees.Remove(employee);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
