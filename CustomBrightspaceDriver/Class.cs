using System;

namespace CustomBrightspaceDriver
{
    public class Class
    {
        public int Id;
        public string Code;
        public string Name;
        public DateTime StartDate;
        public DateTime EndDate;
        public DateTime LastAccessed;
        public string Notes;

        public Class(int id, string course_code, string course_name, DateTime start_date, DateTime end_date, DateTime last_accessed, string notes)
        {
            this.Id = id;
            this.Code = course_code;
            this.Name = course_name;
            this.StartDate = start_date;
            this.EndDate = end_date;
            this.LastAccessed = last_accessed;
            this.Notes = notes;
        }
    }
}
