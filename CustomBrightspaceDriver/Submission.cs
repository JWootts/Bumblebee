using System;
using System.Collections.Generic;
using System.Text;

namespace CustomBrightspaceDriver
{
    public class Submission
    {
        public int Id;
        public string Name;
        public DateTime StartDate;
        public DateTime EndDate;

        public Submission(int id, string name, DateTime start_date, DateTime end_date)
        {
            this.Id = id;
            this.Name = name;
            this.StartDate = start_date;
            this.EndDate = end_date;
        }
    }
}
