using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
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
            return View(repository.Orders.Where(o => o.CarId == carId));
        }

        public IActionResult End(int orderId)
        {
            repository.End(orderId);
            return RedirectToAction("List", "Owner");

        }
    }
}