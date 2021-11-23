using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BumblebeeBrightspace.Models
{
    public class Assignment
    {
        public String assignmentType = "";
        public String assignmentName = "";
        public String grade = "0";

        public Assignment(String assiType, String assiName, String gra)
        {

            assignmentName = assiName;
            assignmentType = assiType;
            grade = gra;

        }
    }
}
