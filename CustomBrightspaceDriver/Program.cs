﻿using System;
using System.Collections.Generic;

//~~~~~Custom imports
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace CustomBrightspaceDriver
{
	class Program
	{
		private const string URL1 = "https://login.fanshawec.ca/cas/login?service=https%3A%2F%2Flogin.fanshawec.ca%2Fidp%2FAuthn%2FExtCas%3Fconversation%3De2s1&entityId=https%3A%2F%2Fc70baeb4-290e-4d0f-864b-dee68f276d2c.tenants.brightspace.com%2FsamlLogin";
		private const string URL2 = "https://www.fanshaweonline.ca/";
		private const string URL3 = "https://www.fanshaweonline.ca/d2l/api/lp/1.32/enrollments/myenrollments/?sortBy=-EndDate";

		static void Main(string[] args)
		{
			String user = "";
			String pass = "";

			ChromeDriverService service = ChromeDriverService.CreateDefaultService();
			service.HideCommandPromptWindow = true;

			var options = new ChromeOptions();
			options.AddArgument("headless");

			var driver = new ChromeDriver(service, options);

			//~~~~~~~~~ Setup app

			if (!Initalizer.InitalizeAppStart())
			{
				Console.WriteLine("App Start Failed. Exitting...");
				driver.Quit();
			}
			else //~~~~~~~~~~~~~~
			{
				//~~~ Grab user properties
				user = UserInfo.GetUsername();
				pass = UserInfo.GetPass();

				driver.Navigate().GoToUrl(URL1);

				IWebElement userfield = driver.FindElement(By.Id("username"));
				IWebElement passfield = driver.FindElement(By.Id("password"));

				userfield.Clear();
				userfield.SendKeys(user);
				passfield.Clear();
				passfield.SendKeys(pass);

				driver.FindElement(By.Name("submit")).Click();

				//~~~ Navigate URL
				driver.Navigate().GoToUrl(URL2);
				driver.Navigate().GoToUrl(URL3);

				InfoExtractor.WriteToJSONFile("classes.json", driver.PageSource);
				List<Class> new_classes = InfoExtractor.GetClassesFromFile("classes.json");

				//create new json file with only most recent classes
				InfoExtractor.CreateJsonFromClasses(new_classes);

				driver.Quit();

				Console.WriteLine("Done");
			}
		}
	}
}
