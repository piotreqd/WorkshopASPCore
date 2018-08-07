using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
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
    }
}