using BumblebeeBrightspace.Models;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;

namespace BumblebeeBrightspace.Helpers
{
	/*
	 * Global static ChromiumDriver to be initalized at program start and kept in
	 * context throughout execution so that cached user properties are not lost
	 */
	public static class ChromiumDriver
	{
		//Driver information
		private static ChromeDriverService service;
		private static ChromeDriver driver;

		//~~~ D2l Version information
		private static String d2lCall_Address;
		private static String LE_VERSION;
		private static String LP_VERSION;

		public static void InitializeDriver()
		{
			service = ChromeDriverService.CreateDefaultService();
			service.HideCommandPromptWindow = true;
			var options = new ChromeOptions();
			options.AddArgument("headless");
			driver = new ChromeDriver(service, options);
			RunLogin(); //Run login from stored data (this is stored at program start)

			//~~~ Grab d2l versions
			GetD2LVersionInformation(); //Run version selection - will be used in d2l calls
		}

		public static String RunGETRequest(String d2lCall) //SETUP CONSTS OF d2l CALLS? OR ENUMS?
		{
			driver.Navigate().GoToUrl(d2lCall);
			return driver.PageSource;
		}

		public static void CloseConnection()
		{
			driver.Quit();
		}

		public static ChromeDriver GetDriver()
		{
			return driver;
		}

		//~~~~ Private function Helpers
		private static void RunLogin()
		{
			String user, pass;
			//~~~ Grab user properties
			user = UserInfo.GetUsername();
			pass = UserInfo.GetPass();

			//~~~ Grab homepage uri and append d2l inital postfix
			d2lCall_Address = UserInfo.GetHomepageURI() + "d2l/api/";

			//~~ Continue with driver load to store a session key for our program initaliztion
			driver.Navigate().GoToUrl(UserInfo.GetLoginURI());

			IWebElement userfield = ChromiumDriver.GetDriver().FindElement(By.Id("username"));
			IWebElement passfield = ChromiumDriver.GetDriver().FindElement(By.Id("password"));

			userfield.Clear();
			userfield.SendKeys(user);
			passfield.Clear();
			passfield.SendKeys(pass);

			driver.FindElement(By.Name("submit")).Click();

			//~~~ Navigate URL
			driver.Navigate().GoToUrl(UserInfo.GetHomepageURI());

			//Grab homepage image information and save
			SaveHomepageImage(driver);
		}

		//Save homepage logo image to be used within program
		private static void SaveHomepageImage(ChromeDriver driver)
		{
			if (!Directory.Exists(Initalizer.LOGO_LOCATION))
			{
				System.Threading.Thread.Sleep(1000); //Sleep to ensure page is loaded with image
				var logoImage = driver.FindElement(By.XPath("//d2l-navigation-link-image[@text='My Home']"));

				//Load image
				Screenshot ss = driver.GetScreenshot();
				byte[] screenshotAsByteArray = ss.AsByteArray;
				Bitmap bmp;
				using (var ms = new MemoryStream(screenshotAsByteArray))
				{
					bmp = new Bitmap(ms);
				}

				//Create image with cropped values and save
				Bitmap cropped = cropAtRect(bmp, new Rectangle(logoImage.Location.X, logoImage.Location.Y, logoImage.Size.Width, logoImage.Size.Height));
				cropped.Save(Initalizer.LOGO_LOCATION, ImageFormat.Jpeg);
			}
		}

		static Bitmap cropAtRect(Bitmap b, Rectangle r)
		{
			Bitmap nb = new Bitmap(r.Width, r.Height);
			Graphics g = Graphics.FromImage(nb);
			g.DrawImage(b, -r.X, -r.Y);
			return nb;
		}

		private static void GetD2LVersionInformation()
		{
			driver.Navigate().GoToUrl(d2lCall_Address + D2LPaths.ReturnD2lPath(D2LPATHS.VERSION));

			//Load version data from driver.PageSource(); --> ref LatestVersion field *Currently explictly set
			LE_VERSION = "1.57";
			LP_VERSION = "1.33";
		}


		//------------------------- Getters to reference LE AND LP Versions to return for a compiled dynamic d2l GET path
		public static String Return_D2lInital()
		{
			return d2lCall_Address;
		}

		public static String Return_LEVersion()
		{
			return LE_VERSION;
		}

		public static String Return_LPVersion()
		{
			return LP_VERSION;
		}


	}
}
