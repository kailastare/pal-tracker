using System.Collections.Generic;

namespace PalTracker
{
    public interface ITimeEntryRepository
    {
        bool Contains(int v);

        TimeEntry Create(TimeEntry timeEntry);

        TimeEntry? Find(int v)
        ;
         IEnumerable<TimeEntry> List();

         TimeEntry Update(int v, TimeEntry timeEntry);

         void Delete(int v);
    }
}