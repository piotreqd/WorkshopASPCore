using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WorkshopAsp.Models;
using WorkshopAsp.Models.DomainModel.Interfaces;
using WorkshopAsp.Models.ViewModels;

namespace WorkshopAsp.Controllers
{
    public class CarController : Controller
    {
        private ICarRepository repository;
        public CarController(ICarRepository repository)
        {
            this.repository = repository;
        }

        public ViewResult List(int ownerId, string ownerFullName)
        {
            var OwnerCars = new OwnerCarViewModel
            {
                OwnerId = ownerId,
                OwnerFullName = ownerFullName,
                Cars = repository.Cars.Where(o => o.OwnerId == ownerId)
            };
        
            return View(OwnerCars);
        }

        public IActionResult Create(int ownerId)
        {
           ViewBag.ownerId = ownerId;
           return View("Create");
        }

        [HttpPost]
        public IActionResult Create(Car car)
        {
            if (ModelState.IsValid)
            {
                repository.Save(car);
                TempData["message"] = $"Zapisano";
            }
            else
            {
                TempData["message"] = $"Wystąpił błąd";
            }
            return RedirectToAction("List", "Owner");
        }

        public ViewResult Edit(int carId) =>
            View(repository.Cars.FirstOrDefault(c => c.Id == carId));

        [HttpPost]
        public IActionResult Edit(Car car)
        {
            if (ModelState.IsValid)
            {
                repository.Save(car);
                TempData["message"] = $"Zapisano";
            }
            else
            {
                TempData["message"] = $"Wystąpił błąd";
            }
            return RedirectToAction("List", "Owner");
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            repository.Delete(id);
            return RedirectToAction("List", "Owner");
        }
    }
}