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
                        Name = "Harry",
                        Surname = "Potter",
                        PhoneNumber = "111222333",
                        Cars = new List<Car>{
                            new Car {
                                Mark = "vw",
                                Model = "golf",
                                Registration = "swd123",
                                Orders = new List<Order>{
                                    new Order{
                                        Name = "Wymiana przegubu",
                                        StartDate = DateTime.Now,
                                        EndDate = null,
                                        Activities = new List<Activity> {
                                            new Activity{
                                                Name = "rozkręcenie przegubu",
                                                LaborPrice = 30m
                                            },
                                            new Activity{
                                                Name = "przykręcenie przegubu",
                                                LaborPrice = 50m,
                                                Parts = new List<Part>{
                                                    new Part{Name = "śrubki 10", Price = 10m}
                                                }
                                            }

                                        }
                                    }
                                }
                            }
                        }
                    }


                    );
                context.SaveChanges();
            }
        }
    }
}
