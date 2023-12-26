using CodegraphiaTesting.Data;
using CodegraphiaTesting.Models;
using Microsoft.AspNetCore.Mvc;

namespace CodegraphiaTesting.Controllers
{
    public class EmployeeController:Controller
    {
        private readonly ApplicationContext _context;
        public EmployeeController(ApplicationContext dbContext) {
            _context = dbContext;
        }

        public ActionResult Index()
        {
            return View(_context.Employees.ToList());
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            ViewData["id"] = id;
            return View("");
        }

        public ActionResult Update(Employee employee)
        {
            return RedirectToAction("Index");
        }
    }
}
