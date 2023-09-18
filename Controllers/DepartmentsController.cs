using Microsoft.AspNetCore.Mvc;
using SalesWebMVC.Models;

namespace SalesWebMVC.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> list = new();

            list.Add(new Department { Id = 1, Name = "Electronics"});
            list.Add(new Department { Id = 2, Name = "Fashion" });

            return View(list);
        }
    }
}
