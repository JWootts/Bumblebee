using System;
using System.Collections.Generic;
using System.Text;

namespace CustomBrightspaceDriver
{
	public static class UserInfo
	{
		private static String user;
		private static String pw;

		public static void SetUserInfo(string u, string p)
		{
			user = u;
			pw = p;
		}

		public static String GetUsername()
		{
			return user;
		}

		public static String GetPass()
		{
			return pw;
		}
	}
}
