using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkshopAsp.Models.DomainModel;

namespace WorkshopAsp.Models
{
    public class Seed
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            var context = app.ApplicationServices
                .GetRequiredService<WorkshopContext>();
            context.Database.Migrate();

            if (!context.Owners.Any())
            {
                context.Owners.AddRange(
                    new Owner
                    {
                        Name = "Kakashi",
                        Surname = "Hatake",
                        PhoneNumber = "111222333",
                        Cars =
                        new List<Car> {
                            new Car {Mark = "vw", Model = "golf", Registration = "swd123" }
                    }
                    }
                    //new Owner { Name = "Naruto", Surname = "Uzumaki", PhoneNumber = "222333444" },
                    //new Owner { Name = "Ichigo", Surname = "Kurosaki", PhoneNumber = "333444555" }
                    );
                context.SaveChanges();
            }
            /*if (!context.Cars.Any())
            {
                context.Cars.AddRange(
                    new Car { Mark = "vw", Model = "golf", Registration = "swd123", OwnerId = 1 }
                    );
                context.SaveChanges();
            }*/
        }
    }
}
