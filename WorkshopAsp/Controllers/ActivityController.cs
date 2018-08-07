using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using WorkshopAsp.Models.DomainModel.Interfaces;
using WorkshopAsp.Models;

namespace WorkshopAsp.Controllers
{
    public class ActivityController : Controller
    {
        private IActivityRepository repository;

        public ActivityController(IActivityRepository repository)
        {
            this.repository = repository;
        }

        public IActionResult List(int orderId)
        {
            ViewBag.orderId = orderId;
            return View(repository.Activities.Where(a => a.OrderId == orderId));
        }

        public IActionResult Create(int orderId)
        {
            ViewBag.orderId = orderId;
            return View("Create");
        }

        [HttpPost]
        public IActionResult Create(Activity activity)
        {
            if (ModelState.IsValid)
            {
                repository.Save(activity);
                TempData["message"] = $"Zapisano";
            }
            else
            {
                TempData["message"] = $"Wystąpił błąd";
            }

            return RedirectToAction("List", new { orderId = activity.OrderId });
        }
    }
}