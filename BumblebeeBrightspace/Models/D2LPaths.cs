using BumblebeeBrightspace.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace BumblebeeBrightspace.Models
{
	public enum D2LPATHS
	{
		VERSION,
		MYENROLLMENTS,
		WHOAMI,
		GRADES
	}

	public static class D2LPaths
	{
		public static String ReturnD2lPath(D2LPATHS selection, int classId = 0)
		{
			switch (selection)
			{
				case D2LPATHS.VERSION:
					return ChromiumDriver.Return_D2lInital() + "versions/";
				case D2LPATHS.MYENROLLMENTS:
					return ChromiumDriver.Return_D2lInital() +  "lp/" + ChromiumDriver.Return_LPVersion() + "/enrollments/myenrollments/?sortBy=-EndDate";
				case D2LPATHS.WHOAMI:
					return ChromiumDriver.Return_D2lInital() + "lp/" + ChromiumDriver.Return_LPVersion() + "/users/whoami";
				case D2LPATHS.GRADES:
					return ChromiumDriver.Return_D2lInital() + "le/" + ChromiumDriver.Return_LEVersion() + "/" + classId + "/grades/values/myGradeValues/";
				default:
					return "";
			}
		}
	}
}
