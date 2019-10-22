using System;
using System.Collections;

namespace PalTracker
{
    public class TimeEntryController
    {
        private ITimeEntryRepository @object;

        public TimeEntryController(ITimeEntryRepository @object)
        {
            this.@object = @object;
        }

        public Microsoft.AspNetCore.Mvc.ActionResult Read(int id)
        {
            throw new NotImplementedException();
        }

        public Microsoft.AspNetCore.Mvc.ActionResult Create(TimeEntry toCreate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable List()
        {
            throw new NotImplementedException();
        }

        public Microsoft.AspNetCore.Mvc.ActionResult Update(int id, TimeEntry theUpdate)
        {
            throw new NotImplementedException();
        }

        public Microsoft.AspNetCore.Mvc.ActionResult Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}