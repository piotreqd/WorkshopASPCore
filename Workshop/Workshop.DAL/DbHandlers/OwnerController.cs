using System;
using System.Collections.Generic;
using System.Linq;
using Workshop.Models.Entities;

namespace Workshop.DAL.DbHandlers
{
    public class OwnerController
    {
        public void ChangePhoneNumber(int id, string newPhoneNumber)
        {
            using (var context = new WorkshopContext())
            {
                var changedOwner = context.Owners.Find(id);
                if (changedOwner != null)
                {
                    changedOwner.PhoneNumber = newPhoneNumber;
                    context.SaveChanges();
                }
            }
        }
        public void Delete(int id)
        {
            using (var context = new WorkshopContext())
            {
                var deletedOwner = context.Owners.Find(id);
                try
                {
                    context.Remove(deletedOwner);
                    context.SaveChanges();
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }
        }
        public void Add(string name, string surname, string phoneNumber)
        {
            var newOwner = new Owner()
            {
                Name = name,
                Surname = surname,
                PhoneNumber = phoneNumber
            };

            using (var context = new WorkshopContext())
            {
                context.Owners.Add(newOwner);
                context.SaveChanges();
            }
        }
        public List<Owner> GetOwners()
        {
            using (var context = new WorkshopContext())
            {
                return context.Owners.ToList();
            }
        }
    }
}
