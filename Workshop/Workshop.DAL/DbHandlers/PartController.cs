using System;
using System.Collections.Generic;
using System.Text;
using Workshop.Models.Entities;

namespace Workshop.DAL.DbHandlers
{
    public class PartController
    {
        public void Delete(int partId)
        {
            using (var context = new WorkshopContext())
            {
                try
                {
                    var part = context.Parts.Find(partId);
                    context.Parts.Remove(part);
                    context.SaveChanges();
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }
        }
        public void Add(int activityId, string name, decimal price)
        {
            var part = new Part()
            {
                ActivityId = activityId,
                Name = name,
                Price = price
            };
            using(var context = new WorkshopContext())
            {
                context.Parts.Add(part);
                context.SaveChanges();
            }
        }
    }
}
