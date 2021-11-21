using BumblebeeBrightspace.Helpers;
using BumblebeeBrightspace.Models;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BumblebeeBrightspace
{
	public partial class Homepage : Form
	{

        private static int curClass = 0;

		public Homepage()
		{
			InitializeComponent();
		}

		private void Form2_Load(object sender, EventArgs e)
		{
			logo.Image = ResizeImage(Image.FromFile(Initalizer.LOGO_LOCATION), logo.Size);
            bumblebeeLogo.Image = ResizeImage(Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "\\assets\\BumblebeeLogo.png"), bumblebeeLogo.Size);
            l_Name.Text = UserInfo.firstname + ", " + UserInfo.lastname;

            ShowClassInformation(curClass);
        }

		private void tabPage1_Click(object sender, EventArgs e)
		{

		}


        //~~~~~~~~~~ Private Helper Functions

        private void ShowClassInformation(int classIndex)
		{
            l_ClassName.Text = UserInfo.GetClassList()[classIndex].Name;
            l_Code.Text = UserInfo.GetClassList()[classIndex].Code;
            GetClassGrades(curClass);
            l_Notes.Text = UserInfo.GetClassList()[classIndex].Notes;

            ConfirmNoEndings();
            SetCurrentClassCountLabel();
        }

        private void ConfirmNoEndings()
		{
            if (curClass == 0)
                b_Prev.Enabled = false;
            else
                b_Prev.Enabled = true;

            if (curClass == UserInfo.GetClassList().Count - 1)
                b_Next.Enabled = false;
            else
                b_Next.Enabled = true;
        }

        private void GetClassGrades(int classIndex)
        {
            InfoExtractor.WriteToJSONFile("grades.json", ChromiumDriver.RunGETRequest(D2LPaths.ReturnD2lPath(D2LPATHS.GRADES, UserInfo.GetClassList()[classIndex].Id)));
        }

        private static Image ResizeImage(Image imgToResize, Size destinationSize)
        {
            var originalWidth = imgToResize.Width;
            var originalHeight = imgToResize.Height;

            //how many units are there to make the original length
            var hRatio = (float)originalHeight / destinationSize.Height;
            var wRatio = (float)originalWidth / destinationSize.Width;

            //get the shorter side
            var ratio = Math.Min(hRatio, wRatio);

            var hScale = Convert.ToInt32(destinationSize.Height * ratio);
            var wScale = Convert.ToInt32(destinationSize.Width * ratio);

            //start cropping from the center
            var startX = (originalWidth - wScale) / 2;
            var startY = (originalHeight - hScale) / 2;

            //crop the image from the specified location and size
            var sourceRectangle = new Rectangle(startX, startY, wScale, hScale);

            //the future size of the image
            var bitmap = new Bitmap(destinationSize.Width, destinationSize.Height);

            //fill-in the whole bitmap
            var destinationRectangle = new Rectangle(0, 0, bitmap.Width, bitmap.Height);

            //generate the new image
            using (var g = Graphics.FromImage(bitmap))
            {
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.DrawImage(imgToResize, destinationRectangle, sourceRectangle, GraphicsUnit.Pixel);
            }

            return bitmap;

        }

		private void b_Prev_Click(object sender, EventArgs e)
		{
            curClass -= 1;
            ShowClassInformation(curClass);
        }

		private void b_Next_Click(object sender, EventArgs e)
		{
            curClass += 1;
            ShowClassInformation(curClass);
        }

        private void SetCurrentClassCountLabel()
		{
            l_classCounter.Text = (curClass + 1) + "/" + (UserInfo.GetClassList().Count);
        }
	}
}
