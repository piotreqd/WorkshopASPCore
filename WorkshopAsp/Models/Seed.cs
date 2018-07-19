using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
                    new Owner { Name = "Kakashi", Surname = "Hatake", PhoneNumber = "111222333" },
                    new Owner { Name = "Naruto", Surname = "Uzumaki", PhoneNumber = "222333444" },
                    new Owner { Name = "Ichigo", Surname = "Kurosaki", PhoneNumber = "333444555" }
                    );
                context.SaveChanges();
            }
        }
    }
}
