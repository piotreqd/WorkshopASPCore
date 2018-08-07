using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkshopAsp.Models.DomainModel.Interfaces;

namespace WorkshopAsp.Models.DomainModel.Repositories
{
    public class ActivityRepository : IActivityRepository
    {
        private WorkshopContext context;

        public ActivityRepository(WorkshopContext context)
        {
            this.context = context;
        }

        public IQueryable<Activity> Activities => context.Activities;

        public void Delete(int activityId)
        {
            throw new NotImplementedException();
        }

        public void Save(Activity activity)
        {
            var changedActivity = context.Activities.FirstOrDefault(a => a.Id == activity.Id);
            if(changedActivity == null)
            {
                context.Activities.Add(activity);
            }
            else
            {
                throw new NotImplementedException();
            }
            context.SaveChanges();
        }
    }
}
