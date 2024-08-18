using CRUD_IN_CORE.Data;
using CRUD_IN_CORE.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRUD_IN_CORE.Controllers
{
    public class Carv2Controller : Controller
    {

        private readonly ApplicationDbContext _context;

        public Carv2Controller(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var data = _context.cars.ToList();
            return View(data);
        }

        [HttpPost]
        public IActionResult Edit(Car c)
        {
            if (ModelState.IsValid)
            {
                _context.Update(c);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");

        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var mydata=_context.cars.Find(id);
            if (mydata != null)
            {
                _context.cars.Remove(mydata);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }


        [HttpPost]
        public IActionResult Create(Car c)
        {
            if (ModelState.IsValid)
            {
                _context.cars.Add(c);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
 
        public IActionResult Details(int id)
        {
            var mydata = _context.cars.Find(id);
            return View(mydata);
        }
    }
}
