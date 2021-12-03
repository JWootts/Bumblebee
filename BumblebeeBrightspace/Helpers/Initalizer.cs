using BumblebeeBrightspace.Models;
using System;
using System.IO;

namespace BumblebeeBrightspace.Helpers
{
	public static class Initalizer
	{
		public const  String APP_NAME = "BUMBLEBEE";
		public static String APPDATA_DIR = "C:\\Users\\" + Environment.UserName + "\\AppData\\Roaming\\" + APP_NAME;
		public static String LOGO_LOCATION = APPDATA_DIR + "\\logo.jpeg";

		public static String FANSHAWE_LOGIN_URI = "https://fanshaweonline.ca/";
		private static String FANSHAWE_HOMEPAGE_URI = "https://www.fanshaweonline.ca/";

		public static Homepage homescreen = new Homepage();


		//Note *May have to seperate appdata as it will pop form1 if failed (try-catch)
		public static bool InitalizeAppStart()
		{
			if (!CreateAppDataStore() || !ConfirmSchoolInformation() || !ConfirmUserProperties())
				return false;
			else
				return true; //~No Errors
		}

		public static void SetSchoolAsFanshawe()
		{
			UserInfo.SetSchoolInformation(FANSHAWE_LOGIN_URI, FANSHAWE_HOMEPAGE_URI);
		}


		private static bool CreateAppDataStore()
		{
			try
			{
				if (!Directory.Exists(APPDATA_DIR))
					Directory.CreateDirectory(APPDATA_DIR);
			}
			catch (Exception e){
				Console.WriteLine(e.Message);
				return false; //Failed
			}
			return true;
		}

		private static bool ConfirmSchoolInformation()
		{
			string school_propsDIR = APPDATA_DIR + "\\schoolinfo.ini";
			string loginuri = "";
			string homepageuri = "";

			try
			{
				if (!File.Exists(school_propsDIR))
				{
					return false;
				}
				else
				{
					using (StreamReader sr = File.OpenText(school_propsDIR))
					{
						loginuri = sr.ReadLine();
						homepageuri = sr.ReadLine();
					}
				}
				UserInfo.SetSchoolInformation(loginuri, homepageuri);
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
				return false; //Failed
			}
			return true;
		}

		private static bool ConfirmUserProperties()
		{
			string user_propsDIR = APPDATA_DIR + "\\userprop.ini";
			string username = "";
			string password = "";
			try
			{

				if (!File.Exists(user_propsDIR))
				{
					return false;
				}
				else
				{
					using (StreamReader sr = File.OpenText(user_propsDIR))
					{
						username = sr.ReadLine();
						password = sr.ReadLine();		
					}
				}

				UserInfo.SetUserInfo(username, password);

			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
				return false; //Failed
			}
			return true;

		}
	}
}
