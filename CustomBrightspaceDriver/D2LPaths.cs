using System;
using System.Collections.Generic;
using System.Text;

namespace CustomBrightspaceDriver
{
	public enum D2LPATHS
	{
		VERSION,
		MYENROLLMENTS
	}

	public static class D2LPaths
	{
		public static String ReturnD2lPath(D2LPATHS selection)
		{
			switch (selection)
			{
				case D2LPATHS.VERSION:
					return ChromiumDriver.Return_D2lInital() + "versions/";
				case D2LPATHS.MYENROLLMENTS:
					return ChromiumDriver.Return_D2lInital() +  "lp/" + ChromiumDriver.Return_LPVersion() + "/enrollments/myenrollments/?sortBy=-EndDate";
				default:
					return "";
			}
		}
	}
}
