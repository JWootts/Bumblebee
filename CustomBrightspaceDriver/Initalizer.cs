using System;
using System.Data.SqlClient;
using System.IO;
using System.Text;

namespace CustomBrightspaceDriver
{
	public static class Initalizer
	{
		private const  String APP_NAME = "BUMBLEBEE";
		private static String APPDATA_DIR = "C:\\Users\\" + Environment.UserName + "\\AppData\\Roaming\\" + APP_NAME;

		private static String FANSHAWE_LOGIN_URI = "https://login.fanshawec.ca/cas/login?service=https%3A%2F%2Flogin.fanshawec.ca%2Fidp%2FAuthn%2FExtCas%3Fconversation%3De2s1&entityId=https%3A%2F%2Fc70baeb4-290e-4d0f-864b-dee68f276d2c.tenants.brightspace.com%2FsamlLogin";
		private static String FANSHAWE_HOMEPAGE_URI = "https://www.fanshaweonline.ca/";


		public static bool InitalizeAppStart()
		{
			if (!CreateAppDataStore() || !ConfirmUserProperties() || !ConfirmSchoolInformation())
				return false;
			else
				return true; //~No Errors
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

					Console.WriteLine("Are you a Fanshawe Student???");
					String input = Console.ReadLine().ToLower();

					if (input == "n" || input == "no")
					{

						//~~~ write to school props ###
						Console.WriteLine("Please Enter School Login URI:");
						loginuri = Console.ReadLine();

						while (loginuri == "")
							loginuri = Console.ReadLine();


						Console.WriteLine("Please Enter School Homepage URI:");
						homepageuri = Console.ReadLine();

						while (homepageuri == "")
							homepageuri = Console.ReadLine();
					}
					else
					{
						loginuri = FANSHAWE_LOGIN_URI;
						homepageuri = FANSHAWE_HOMEPAGE_URI;
					}

					using (StreamWriter sw = File.CreateText(school_propsDIR))
					{
						sw.WriteLine(loginuri);
						sw.WriteLine(homepageuri);
					}
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
				//************************* Work on using db, currently select works but insert does not
				//Connect to local db
				/*SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + AppDomain.CurrentDomain.BaseDirectory + "data.mdf;Integrated Security=True;database=data");
				Console.WriteLine("Connected.");
				

				//~~~ Check if user Exists in Local Database
				String selectUser = "Select username, password FROM UserInfo";
				var sqlCommand = new SqlCommand(selectUser, con);
				con.Open();
				var result = sqlCommand.ExecuteScalar();
				con.Close();

				if(result == null)
				{
					//~~ User properties do not exist
					Console.WriteLine("Please Enter Username:");
					username = Console.ReadLine();

					while (username == "")
						username = Console.ReadLine();


					Console.WriteLine("Please Enter Password:");
					password = Console.ReadLine();

					while (password == "")
						password = Console.ReadLine();

					con.Open();
					string insertSQL = "INSERT INTO UserInfo (username, password) " +
										"VALUES (@username,@pw);";
					var insertCommand = new SqlCommand(insertSQL, con);
					insertCommand.Parameters.AddWithValue("@username",username);
					insertCommand.Parameters.AddWithValue("@pw",password);
					sqlCommand.ExecuteNonQuery();
					con.Close();

				}
				else
				{
					//Set user properties from retrieved values from db

				}
				*/

				if (!File.Exists(user_propsDIR))
				{
					//~~~ write to user props ###
					Console.WriteLine("Please Enter Username:");
				    username = Console.ReadLine();

					while (username == "")
						username = Console.ReadLine();


					Console.WriteLine("Please Enter Password:");
				    password = Console.ReadLine();

					while (password == "")
						password = Console.ReadLine();

					using (StreamWriter sw = File.CreateText(user_propsDIR))
					{
						sw.WriteLine(username);
						sw.WriteLine(password);
					}
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
