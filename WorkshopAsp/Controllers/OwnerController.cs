using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using WorkshopAsp.Models;

namespace WorkshopAsp.Controllers
{
    public class OwnerController : Controller
    {
        IOwnerRepository repository;
        public OwnerController(IOwnerRepository repo)
        {
            repository = repo;
        }

        public ViewResult List()
        {
            return View(repository.Owners);
        }
        public ViewResult Edit(int ownerId) =>
            View(repository.Owners.FirstOrDefault(o => o.Id == ownerId));

        [HttpPost]
        public IActionResult Edit(Owner owner)
        {
            if (ModelState.IsValid)
            {
                repository.Save(owner);
                TempData["message"] = $"Zapisano";                
            }
            else
            {
                TempData["message"] = $"Wystąpił błąd";
            }
            return RedirectToAction("List");
        }

        public ViewResult Create() => View("Edit", new Owner());

        [HttpPost]
        public IActionResult Delete(int id)
        {
            repository.Delete(id);
            return RedirectToAction("List");
        }
    }
}
