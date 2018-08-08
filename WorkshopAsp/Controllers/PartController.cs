using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WorkshopAsp.Models;
using WorkshopAsp.Models.DomainModel.Interfaces;
using WorkshopAsp.Models.DomainModel.Repositories;

namespace WorkshopAsp.Controllers
{
    public class PartController : Controller
    {
        private IPartRepository repository;
        public PartController(IPartRepository repository)
        {
            this.repository = repository;
        }

        public IActionResult List(int activityId)
        {
            ViewBag.ActivityId = activityId;
            return View(repository.Parts.Where(p => p.ActivityId == activityId));
        }

        public IActionResult Create(int activityId)
        {
            ViewBag.ActivityId = activityId;
            return View("Create");
        }

        [HttpPost]
        public IActionResult Create(Part part)
        {
            if (ModelState.IsValid)
            {
                repository.Save(part);
                TempData["message"] = $"Zapisano";
            }
            else
            {
                TempData["message"] = $"Wystąpił błąd";
            }

            return RedirectToAction("List", new { activityId = part.ActivityId });
        }
    }
}