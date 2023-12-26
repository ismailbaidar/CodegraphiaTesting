

using CodegraphiaTesting.Data;
using CodegraphiaTesting.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CodegraphiaTesting.Controllers
{
    public class DepartmentController:Controller
    {
        private readonly ApplicationContext _context;

        public DepartmentController(ApplicationContext dbContext)
        {
            _context = dbContext;
        }

        public ActionResult Index()
        {
            return View(_context.Departments.ToList());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Department departemnt)
        {
            _context.Departments.Add(departemnt);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            _context.Departments.Remove(_context.Departments.Find(id));
            _context.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}
