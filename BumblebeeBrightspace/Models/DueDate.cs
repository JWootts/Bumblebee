using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BumblebeeBrightspace.Models
{
    public class DueDate
    {
        public String Title;
        public DateTime StartDate;
        public DateTime EndDate;

        public DueDate(String title, DateTime start, DateTime end)
        {
            Title = title;
            StartDate = start;
            EndDate = end;
        }
    }
}
