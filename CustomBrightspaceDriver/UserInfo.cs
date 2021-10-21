using System;
using System.Collections.Generic;
using System.Text;

namespace CustomBrightspaceDriver
{
	/*
	 * Class kept static as only 1 user instance per application at a time, so no need to keep muliple user login data
	 * (in this instance)
	 */
	public static class UserInfo
	{
		//~~~ login / user information
		private static String user;
		private static String pw;

		//~~~ School information
		private static String login_domain;
		private static String homepage;

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
	}
}
