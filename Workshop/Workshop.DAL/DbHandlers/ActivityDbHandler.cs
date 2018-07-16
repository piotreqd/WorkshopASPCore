﻿using System;
using System.Collections.Generic;
using System.Text;
using Workshop.Models.Entities;

namespace Workshop.DAL.DbHandlers
{
    public class ActivityDbHandler
    {
        public void ChangeActivity(int activityId, decimal laborPrice)
        {
            using (var context = new WorkshopContext())
            {
                var changedActivity = context.Activities.Find(activityId);
                try
                {
                    changedActivity.LaborPrice = laborPrice;
                    context.SaveChanges();
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }
        }
        public void ChangeActivity(int activityId, string newName)
        {
            using (var context = new WorkshopContext())
            {
                var changedActivity = context.Activities.Find(activityId);
                try
                {
                    if (changedActivity != null)
                    {
                        changedActivity.Name = newName;
                        context.SaveChanges();
                    }
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }
        }
        public void Delete(int activityId)
        {
            using (var context = new WorkshopContext())
            {
                try
                {
                    var activity = context.Activities.Find(activityId);                                    
                    context.Activities.Remove(activity);
                    context.SaveChanges();                    
                }
                catch (NullReferenceException exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }
        }
        public void Add(int orderId, string activityName, decimal laborPrice)
        {
            var activity = new Activity()
            {
                OrderId = orderId,
                Name = activityName,
                LaborPrice = laborPrice
            };

            using (var context = new WorkshopContext())
            {
                try
                {
                    context.Activities.Add(activity);
                    context.SaveChanges();
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }

        }
    }
}
