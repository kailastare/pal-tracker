using System;

namespace PalTracker
{
    public struct TimeEntry
    {
        public int? Id;
        public int ProjectId;
        public int UserId;
        public DateTime Date;
        public int Hours;

        public TimeEntry(int projectId, int userId, DateTime date, int hours)
        {
            Id = null;
            ProjectId = projectId;
            Date = date;
            UserId = userId;
            Hours = hours;
        }

        public TimeEntry(int id, int projectId, int userId, DateTime date, int hours)
        {
            this.Id = id;
            this.ProjectId = projectId;
            this.UserId = userId;
            this.Date = date;
            this.Hours = hours; 
        }
    }
}
