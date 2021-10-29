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
				
				while(true)
                {
					Console.WriteLine("Your current classes are:");
					for (int i = 0; i < new_classes.Count; ++i)
                    {
						Console.WriteLine((i + 1) + ". " + new_classes[i].Name);
                    }

					Console.WriteLine("Would you like to add notes to a class[1] or view notes for a class[2]?");
					String input = Console.ReadLine().ToLower();

					if(input == "n" || input == "no")
                    {
						break;
                    }
					else if(input == "1")
                    {
						Console.WriteLine("Which class would you like to enter notes for? [enter index to access that class]");
						String index = Console.ReadLine().ToLower();

						Console.WriteLine("Please enter notes for that class:");
						String notes = Console.ReadLine();
						new_classes[Int32.Parse(index) - 1].Notes = notes;
					}
					else if(input == "2")
                    {
						Console.WriteLine("Which class would you like to view notes for? [enter index to access that class]");
						String index = Console.ReadLine().ToLower();
						Console.WriteLine(new_classes[Int32.Parse(index) - 1].Notes);
					}

				}

				ChromiumDriver.CloseConnection(); //Close driver connection at program exit

				Console.WriteLine("Done");
			}
		}
	}
}
