using System;
using System.Collections.Generic;
using System.Text;

namespace BumblebeeBrightspace.Models
{
	/*
	 * Class kept static as only 1 user instance per application at a time, so no need to keep muliple user login data
	 * (in this instance)
	 */
	public static class UserInfo
	{

		private static List<Class> userClasses = null;

		//~~~ login / user information
		private static String user;
		private static String pw;

		//~~~ School information
		private static String login_domain;
		private static String homepage;


		//~~ Direct User Information (From who-am-i)
		public static String firstname;
		public static String lastname;
		public static String uniqueName;

		public static void SetDirectUserInfo(string fname, string lname, string uName)
		{
			firstname = fname;
			lastname = lname;
			uniqueName = uName;
		}

		//-------------------------------------------------------------------------- Setters
		public static void SetUserInfo(string u, string p)
		{
			user = u;
			pw = p;
		}

		public static void SetSchoolInformation(String login_uri, String hp)
		{
			login_domain = login_uri;
			homepage = hp;
		}

		//-------------------------------------------------------------------------- Getters
		public static String GetUsername()
		{
			return user;
		}

		public static String GetPass()
		{
			return pw;
		}

		public static String GetLoginURI()
		{
			return login_domain;
		}

		public static String GetHomepageURI()
		{
			return homepage;
		}

		public static void SetUserClasses(List<Class> cList)
		{
			userClasses = cList;
		}

		public static List<Class> GetClassList()
		{
			return userClasses;
		}

		public static int ReturnClassIndex(string classname)
		{
			for(int i = 0; i < userClasses.Count; ++i)
				if (userClasses[i].Name == classname)
					return i;
			
			return -1;
		}

	}
}
