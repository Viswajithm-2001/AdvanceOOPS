using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AttendanceQuestion
{
    public class Attendance
    {
        public int WorkingDays { get; set; }
        public int LeavesTaken { get; set; }
        public int Permissions {get;set;}

        public Attendance(int workingDays,int leavesTaken,int permissions)
        {
            WorkingDays = workingDays;
            LeavesTaken = leavesTaken;
            Permissions = permissions;
        }
        public double Calculate()
        {
            return (WorkingDays-LeavesTaken)*500;
        }
    }
}