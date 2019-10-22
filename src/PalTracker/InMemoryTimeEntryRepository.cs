using System;
using System.Collections.Generic;

namespace PalTracker
{
    public class InMemoryTimeEntryRepository : ITimeEntryRepository
    {
        private int count = 1;
        private Dictionary<int,TimeEntry> timeEntryList;
        public InMemoryTimeEntryRepository()
        {
            timeEntryList = new Dictionary<int, TimeEntry>();
        }

        public TimeEntry Create(TimeEntry timeEntry)
        {
            TimeEntry createdTimeEntry =
                new TimeEntry(count,
                        timeEntry.ProjectId,
                        timeEntry.UserId,
                        timeEntry.Date,
                        timeEntry.Hours);
            timeEntryList.Add(count, createdTimeEntry);
            count++;

            return createdTimeEntry;
        }

        public TimeEntry? Find(int id)
        {
            if(timeEntryList.ContainsKey(id))
                        return timeEntryList[id];
            return null;
        }

        public bool Contains(int v)
        {
            return timeEntryList.ContainsKey(v);
        }

        public IEnumerable<TimeEntry> List()
        {
            return timeEntryList.Values;
        }

        public TimeEntry Update(int v, TimeEntry timeEntry)
        {
            timeEntry.Id = v;
            timeEntryList[v] = timeEntry;
            return timeEntry;
        }

        public void Delete(int v)
        {
            timeEntryList.Remove(v);
        }
    }
}