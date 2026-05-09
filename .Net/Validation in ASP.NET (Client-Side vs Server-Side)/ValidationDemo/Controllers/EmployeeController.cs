using Microsoft.AspNetCore.Mvc;
using ValidationDemo.Models;

namespace ValidationDemo.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: /Employee/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: /Employee/Create
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            // Server-Side Validation check
            if (!ModelState.IsValid)
            {
                return View(employee); // return same form with errors
            }

            // Valid → redirect to success page
            TempData["SuccessMessage"] = "Employee saved successfully!";
            return RedirectToAction("Success");
        }

        public IActionResult Success()
        {
            return View();
        }
    }
}
