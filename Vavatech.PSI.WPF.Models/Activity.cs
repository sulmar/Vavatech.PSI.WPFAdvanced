using System;

namespace Vavatech.PSI.WPF.Models
{
    public class Activity : Base
    {
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public Employee Assigned { get; set; }
        public ActivityType Type { get; set; }

        public Activity(int id, DateTime startTime, DateTime? endTime, Employee assigned, ActivityType type)
        {
            Id = id;
            StartTime = startTime;
            EndTime = endTime;
            Assigned = assigned;
            Type = type;
        }
    }

    
}
