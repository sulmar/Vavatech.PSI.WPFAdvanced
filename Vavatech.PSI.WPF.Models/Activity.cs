using System;

namespace Vavatech.PSI.WPF.Models
{
    public struct Location
    {
        public Location(double left, double top) : this()
        {
            Left = left;
            Top = top;
        }

        public double Left { get; set; }
        public double Top { get; set; }
    }

    public class Activity : Base
    {
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public Employee Assigned { get; set; }
        public ActivityType Type { get; set; }
        public Location Location { get; set; }


        public Activity(int id, DateTime startTime, DateTime? endTime, Employee assigned, ActivityType type, Location location)
        {
            Id = id;
            StartTime = startTime;
            EndTime = endTime;
            Assigned = assigned;
            Type = type;
            Location = location;


        }
    }

    
}
