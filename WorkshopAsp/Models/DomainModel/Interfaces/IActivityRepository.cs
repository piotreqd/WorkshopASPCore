using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkshopAsp.Models.DomainModel.Interfaces
{
    public interface IActivityRepository
    {
        IQueryable<Activity> Activities { get;}
        void Save(Activity activity);
        void Delete(int activityId);
    }
}
