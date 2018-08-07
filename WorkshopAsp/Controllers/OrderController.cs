using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WorkshopAsp.Models;
using WorkshopAsp.Models.DomainModel.Interfaces;

namespace WorkshopAsp.Controllers
{
    public class OrderController : Controller
    {
        private IOrderRepository repository;
        public OrderController(IOrderRepository repository)
        {
            this.repository = repository;
        }
        public IActionResult List(int carId)
        {
            ViewBag.carId = carId;
            return View(repository.Orders.Where(o => o.CarId == carId));
        }

        public IActionResult End(int orderId, int carId)
        {
            repository.End(orderId);
            return RedirectToAction("List", new { carId });
        }

        public IActionResult Create(int carId)
        {
            ViewBag.carId = carId;
            return View("Create");
        }

        [HttpPost]
        public IActionResult Create(Order order)
        {
            if (ModelState.IsValid)
            {
                repository.Begin(order);
                TempData["message"] = $"Zapisano";
            }
            else
            {
                TempData["message"] = $"Wystąpił błąd";
            }
            return RedirectToAction("List", new { carId = order.CarId});
        }
    }
}