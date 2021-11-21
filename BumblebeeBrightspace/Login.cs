﻿using BumblebeeBrightspace.Helpers;
using BumblebeeBrightspace.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BumblebeeBrightspace
{
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();
		}

		private void Form1_Activated(object sender, EventArgs e)
		{

			if (Initalizer.InitalizeAppStart())
			{
				this.Hide();

				//***************ADD LOADING SCREEN FOR SLOW TIMES
				PullAndStoreUserInformation();


				Initalizer.homescreen.Show();

			}
		}

		private void b_Submit_Click(object sender, EventArgs e)
		{
			if (tb_User.Text != "" && tb_Pass.Text != "")
				UserInfo.SetUserInfo(tb_User.Text, tb_Pass.Text);

			if (cb_FanshaweStudent.Checked)
				Initalizer.SetSchoolAsFanshawe();
			else
				UserInfo.SetSchoolInformation(tb_SchoolDomain.Text, "HOMEPAGEURL");

			//Check user information is stored
			ChromiumDriver.InitializeDriver();

			PullAndStoreUserInformation();
			ShowHomepageForm();
		}

		//~~~ Private helper

		private void PullAndStoreUserInformation()
		{
			if (UserInfo.firstname == null || UserInfo.lastname == null || UserInfo.uniqueName == null)
				GetWhoAmiInformation();//Query Who-Am-I for user details ~ Rest of userdetails filled

			GetUserClasses(); //Query Classes for class details
		}


		private void ShowHomepageForm()
		{
			this.Hide();
			Initalizer.homescreen.Show();
		}

		private void GetWhoAmiInformation()
		{
			InfoExtractor.WriteToJSONFile("whoami.json", ChromiumDriver.RunGETRequest(D2LPaths.ReturnD2lPath(D2LPATHS.WHOAMI)));
			List<string> userDetails = InfoExtractor.GetUserDetails("whoami.json");
			UserInfo.SetDirectUserInfo(userDetails[0], userDetails[1], userDetails[2]);
		}

		private void GetUserClasses()
		{
			//Query Class information 
			InfoExtractor.WriteToJSONFile("classes.json", ChromiumDriver.RunGETRequest(D2LPaths.ReturnD2lPath(D2LPATHS.MYENROLLMENTS)));
			UserInfo.SetUserClasses(InfoExtractor.GetClassesFromFile("classes.json"));

			//create new json file with only most recent classes
			InfoExtractor.CreateJsonFromClasses(UserInfo.GetClassList());
		}

		private void cb_FanshaweStudent_CheckedChanged(object sender, EventArgs e)
		{
			if (cb_FanshaweStudent.Checked)
			{
				tb_SchoolDomain.Enabled = false;
				tb_SchoolDomain.Text = Initalizer.FANSHAWE_LOGIN_URI;
			}
		}
	}
}
