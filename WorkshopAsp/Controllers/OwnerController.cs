using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public ViewResult List() => View(repository.Owners);
    }
}
