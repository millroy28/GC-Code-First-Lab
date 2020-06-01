using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GC_CodeFirstDBLab.Context;
using Microsoft.AspNetCore.Mvc;

namespace GC_CodeFirstDBLab.Controllers
{
    public class CarController : Controller
    {
        private readonly CarContext _context;

        public CarController(CarContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Car> cars = _context.Cars.ToList();
            return View(cars);
        }

        [HttpGet]
        public IActionResult UpdateCar(int id)
        {
            Car found = _context.Cars.Find(id);
            return View(found);
        }
        [HttpPost]
        public IActionResult UpdateCar(Car changedCar)
        {
            Car oldCar = _context.Cars.Find(changedCar.Id);
            if (ModelState.IsValid)
            {
                oldCar.Make = changedCar.Make;
                oldCar.Model = changedCar.Model;
                oldCar.Year = changedCar.Year;
                oldCar.Type = changedCar.Type;
                oldCar.Transmission = changedCar.Transmission;

                _context.Entry(oldCar).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.Update(oldCar);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult AddCar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCar(Car newCar)
        {
            if (ModelState.IsValid)
            {
                _context.Cars.Add(newCar);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public IActionResult DeleteCar(int id)
        {
            Car found = _context.Cars.Find(id);
            if(found != null)
            {
                _context.Cars.Remove(found);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
