using System;
using System.Collections.Generic;

/*
 * TODO:
 *	- ChromiumDriver.GetD2LVersionInformation() --> Grab LE and LP versions from pagesource and set
 */

namespace CustomBrightspaceDriver
{
	class Program
	{
		static void Main(string[] args)
		{
			//~~~~~~~~~ Setup app
			if (!Initalizer.InitalizeAppStart())
			{
				Console.WriteLine("App Start Failed. Exitting...");
			}
			else //~~~~~~~~~~~~~~
			{
				ChromiumDriver.InitializeDriver(); //start driver if appdata / database properties setup (username, pass, uri of school)

				InfoExtractor.WriteToJSONFile("classes.json", ChromiumDriver.RunGETRequest(D2LPaths.ReturnD2lPath(D2LPATHS.MYENROLLMENTS)));
				List <Class> new_classes = InfoExtractor.GetClassesFromFile("classes.json");

				//create new json file with only most recent classes
				InfoExtractor.CreateJsonFromClasses(new_classes);

				ChromiumDriver.CloseConnection(); //Close driver connection at program exit

				Console.WriteLine("Done");
			}
		}
	}
}
