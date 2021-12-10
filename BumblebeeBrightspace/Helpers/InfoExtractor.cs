using BumblebeeBrightspace.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace BumblebeeBrightspace.Helpers
{
    public static class InfoExtractor
    {
        //const string jsonRegex = @"\{(?:[^\{\}]|(?<o>\{)|(?<-o>\}))+(?(o)(?!))\}";

        /*public static void WriteToJSONFile(string filename, string page_source)
        {
            //page_source contains all json wrapped in a pre-wrap tag
            string input = page_source.Substring(page_source.IndexOf("pre-wrap;\">"));

            Match match = Regex.Matches(input, jsonRegex, RegexOptions.Multiline | RegexOptions.IgnoreCase)[0];

            string jsonText = match.Groups[0].Value;
            JObject jsonObj = JObject.Parse(jsonText);
            File.WriteAllText(filename, jsonObj.ToString());
        }*/
        public static JObject GetJObject(string data)
        {
            data = Regex.Replace(data, "<.*?>", string.Empty);

            JObject jsonObj = JObject.Parse(data);

            return jsonObj;
        }

        public static List<Class> GetClassesFromJObject(JObject obj)
        {
            //list to be added to and returned
            List<Class> classes = new List<Class>();

            //list of parameters pulled for all classes. It skips the junk we don't need
            List<int> ids = obj.SelectTokens("..OrgUnit").Select(s => (int)s.SelectToken("Id")).ToList();
            List<string> codes = obj.SelectTokens("..OrgUnit").Select(s => (string)s.SelectToken("Code")).ToList();
            List<string> names = obj.SelectTokens("..OrgUnit").Select(s => (string)s.SelectToken("Name")).ToList();
            List<string> start_dates = obj.SelectTokens("..Access").Select(s => (string)s.SelectToken("StartDate")).ToList();
            List<string> end_dates = obj.SelectTokens("..Access").Select(s => (string)s.SelectToken("EndDate")).ToList();
            List<string> last_accessed = obj.SelectTokens("..LastAccessed").Select(s => (string)s).ToList();

            //loop through and add all classes, if dates are null, will return a default date of 01-01-0001
            for (int i = 0; i < ids.Count; ++i)
            {
                //comment out if statements if you want all classes included not just current
                if (end_dates[i] == null)
                    continue;
                else if (DateTime.Parse(end_dates[i]) < DateTime.Now)
                    continue;

                string[] empty = { };

                classes.Add(new Class(ids[i], codes[i], names[i], Convert.ToDateTime(start_dates[i]), Convert.ToDateTime(end_dates[i]), Convert.ToDateTime(last_accessed[i]), empty));
            }
            return classes;
        }

        public static JArray GetJArray(string data)
        {
            data = Regex.Replace(data, "<.*?>", string.Empty);

            JArray jsonArray = JArray.Parse(data);

            return jsonArray;
        }

        /*public static List<Class> GetClassesFromFile(string filename)
        {
            //list to be added to and returned
            List<Class> classes = new List<Class>();

            string json_text = File.ReadAllText(filename);
            JObject obj = JObject.Parse(json_text);

            //list of parameters pulled for all classes. It skips the junk we don't need
            List<int> ids = obj.SelectTokens("..OrgUnit").Select(s => (int)s.SelectToken("Id")).ToList();
            List<string> codes = obj.SelectTokens("..OrgUnit").Select(s => (string)s.SelectToken("Code")).ToList();
            List<string> names = obj.SelectTokens("..OrgUnit").Select(s => (string)s.SelectToken("Name")).ToList();
            List<string> start_dates = obj.SelectTokens("..Access").Select(s => (string)s.SelectToken("StartDate")).ToList();
            List<string> end_dates = obj.SelectTokens("..Access").Select(s => (string)s.SelectToken("EndDate")).ToList();
            List<string> last_accessed = obj.SelectTokens("..LastAccessed").Select(s => (string)s).ToList();

            //loop through and add all classes, if dates are null, will return a default date of 01-01-0001
            for (int i = 0; i < ids.Count; ++i)
            {
                //comment out if statements if you want all classes included not just current
                if (end_dates[i] == null)
                    continue;
                else if(DateTime.Parse(end_dates[i]) < DateTime.Now)
                    continue;

                classes.Add(new Class(ids[i], codes[i], names[i], Convert.ToDateTime(start_dates[i]), Convert.ToDateTime(end_dates[i]), Convert.ToDateTime(last_accessed[i]), ""));
            }
            return classes;
        }*/

        public static List<string> GetUserDetails(JObject obj)
		{
            List<string> returnList = new List<string>();
            returnList.Add(obj.SelectToken("FirstName").ToString());
            returnList.Add(obj.SelectToken("LastName").ToString());
            returnList.Add(obj.SelectToken("UniqueName").ToString());

            return returnList;
		}

        public static List<Assignment> GetGrades(JArray array)
        {

            List<Assignment> grades = new List<Assignment>();

            foreach (JObject i in array)
            {
                JObject holder = i;
                string name = i.SelectToken("GradeObjectName").ToString();
                string gradeType = i.SelectToken("GradeObjectTypeName").ToString();
                string grade = i.SelectToken("DisplayedGrade").ToString();
                Assignment newAssignment = new Assignment(gradeType, name, grade);
                grades.Add(newAssignment);
            }

            return grades;
        }

        public static List<Assignment> GetClassGrades(int classIndex)
        {
            JArray holdJArray = InfoExtractor.GetJArray(ChromiumDriver.RunGETRequest(D2LPaths.ReturnD2lPath(D2LPATHS.GRADES, UserInfo.GetClassList()[classIndex].Id)));
            List<Assignment> grades = GetGrades(holdJArray);
            return grades;
        }

        public static List<DueDate> GetDueDates(JArray array)
        {
            List<DueDate> dates = new List<DueDate>();

            foreach (JObject i in array)
            {
                JObject holder = i;
                string title = i.SelectToken("Title").ToString();
                string start = i.SelectToken("StartDateTime").ToString();
                string end = i.SelectToken("EndDateTime").ToString();
                DueDate date = new DueDate(title, DateTime.Parse(start).AddHours(-5), DateTime.Parse(end).AddHours(-5));
                dates.Add(date);
            }

            return dates;
        }

        public static List<DueDate> GetClassDueDates(int classIndex)
        {
            JArray holdJArray = InfoExtractor.GetJArray(ChromiumDriver.RunGETRequest(D2LPaths.ReturnD2lPath(D2LPATHS.DUE_DATES, UserInfo.GetClassList()[classIndex].Id)));
            List<DueDate> dates = GetDueDates(holdJArray);
            return dates;
        }


        public static void CreateJsonFromClasses(List<Class> classes)
        {
            string JSONresult = JsonConvert.SerializeObject(classes);
            string path = @"filteredClasses.json";
            if(File.Exists(path))
            {
                File.Delete(path);
            }
            using (var tw = new StreamWriter(path, true))
            {
                tw.WriteLine(JSONresult.ToString());
                tw.Close();
            }
        }
    }
}
