using BumblebeeBrightspace.Helpers;
using BumblebeeBrightspace.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Windows.Forms;

namespace BumblebeeBrightspace
{
	public partial class Homepage : Form
	{

        private static int curClass = 0;
        List<Assignment> grades = new List<Assignment>();
        List<DueDate> dates = new List<DueDate>();
        private string gradesDisplay = "";
        private string ADDNOTES_STARTER = "SECTION TO ADD NEW CLASS NOTES";

        public Homepage()
		{
			InitializeComponent();
		}

		private void Form2_Load(object sender, EventArgs e)
		{
			logo.Image = ResizeImage(Image.FromFile(Initalizer.LOGO_LOCATION), logo.Size);
            bumblebeeLogo.Image = ResizeImage(Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "\\assets\\BumblebeeLogo.png"), bumblebeeLogo.Size);
            l_Name.Text = UserInfo.firstname + ", " + UserInfo.lastname;
            tb_ClassNotes.Text = ADDNOTES_STARTER;

            ShowClassInformation(curClass);
            LoadNoteInformation();
        }

		private void tabPage1_Click(object sender, EventArgs e)
		{

		}


        //~~~~~~~~~~ Private Helper Functions

        private void ShowClassInformation(int classIndex)
		{
            string classNotesString = "";
            l_ClassName.Text = UserInfo.GetClassList()[classIndex].Name;
            l_Code.Text = UserInfo.GetClassList()[classIndex].Code;
            gradesDisplay = "";

            if (UserInfo.GetClassList()[classIndex].Notes.Length != 0)
            {
                foreach (string note in UserInfo.GetClassList()[classIndex].Notes)
                    classNotesString += "\n --> " + note;

                l_Notes.Text = classNotesString;
            }
            else
            {
                l_Notes.Text = "No notes for this class.";
            }

            ConfirmNoEndings();
            SetCurrentClassCountLabel();
            grades = InfoExtractor.GetClassGrades(classIndex);
            dates = InfoExtractor.GetClassDueDates(classIndex);
            for(int i = 0; i < grades.Count; i++)
            {
                if (grades[i].grade != "0 / 0")
                    gradesDisplay += grades[i].assignmentName + ": " + grades[i].grade + Environment.NewLine;
                else
                    gradesDisplay += grades[i].assignmentName + ": " + grades[i].grade + " (DROPPED) " + Environment.NewLine;
            }

            grade.Text = gradesDisplay;
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

        private void grade_TextChanged(object sender, EventArgs e)
        {

        }

		private void button2_Click(object sender, EventArgs e)
		{
            if (UserInfo.GetClassList()[curClass].Notes.Length != 0)
            {
                tabControl1.SelectedIndex = 2;
                RefreshCurrentClassNotes();
            }
        }

		private void button1_Click(object sender, EventArgs e)
		{
            if(tb_ClassNotes.Text != "" || tb_ClassNotes.Text != ADDNOTES_STARTER) { 
                List<string> noteList = new List<string>();

                foreach (string note in UserInfo.GetClassList()[curClass].Notes)
                    noteList.Add(note);

                noteList.Add(tb_ClassNotes.Text);
                tb_ClassNotes.Text = "";
                UserInfo.GetClassList()[curClass].Notes = noteList.ToArray();
            }
        }

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
            if (tb_ClassNotes.Text == ADDNOTES_STARTER)
                tb_ClassNotes.Text = "";

        }

        private void RefreshCurrentClassNotes()
		{
            l_Notes.Text = Environment.NewLine + Environment.NewLine;

            foreach (string note in UserInfo.GetClassList()[curClass].Notes)
                l_Notes.Text += "--> " + note + Environment.NewLine + Environment.NewLine; 

            l_classNoteHeader.Text = UserInfo.GetClassList()[curClass].Name;
        }

        private void LoadNoteInformation()
		{
            foreach (var classes in UserInfo.GetClassList())
                cb_classNames.Items.Add(classes.Name);
		}

		private void tabPage3_Click(object sender, EventArgs e)
		{

		}

		private void button3_Click(object sender, EventArgs e)
		{
            l_Notes.Text = "";
            if (cb_classNames.Text != "")
			{
                int classIndex = UserInfo.ReturnClassIndex(cb_classNames.Text);
                if(classIndex != -1)
                    foreach(var note in UserInfo.GetClassList()[classIndex].Notes)
                        l_Notes.Text += "--> " + note + Environment.NewLine + Environment.NewLine;
               
			}
		}

		private void cb_classNames_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void b_AddClassNotes_Click(object sender, EventArgs e)
		{
            if(tb_NewClassNote.Text != "" && cb_classNames.Text != "")
			{
                List<string> noteList = new List<string>();

                foreach (string note in UserInfo.GetClassList()[curClass].Notes)
                    noteList.Add(note);

                noteList.Add(tb_NewClassNote.Text);
                tb_NewClassNote.Text = "";
                UserInfo.GetClassList()[curClass].Notes = noteList.ToArray();

                RefreshCurrentClassNotes();
            }
		}

        private void monthCalendar1_DateSelected(object sender, System.Windows.Forms.DateRangeEventArgs e)
        {
            tb_DueDates.Text = "";
            int num_assignments = 0;
            int counter = 0;
            Calendar cal = new CultureInfo("en-US").Calendar;
            int week = cal.GetWeekOfYear(e.End, CalendarWeekRule.FirstDay, DayOfWeek.Sunday);
            foreach (DueDate date in dates)
            {
                if (week == cal.GetWeekOfYear(date.EndDate, CalendarWeekRule.FirstDay, DayOfWeek.Sunday))
                {
                    num_assignments++;
                }
            }
            foreach (DueDate date in dates)
            {
                if ((date.EndDate.Month == e.End.Month) && (date.EndDate.Year == e.End.Year) && (date.EndDate.Day == e.End.Day))
                {
                    if (counter == 0)
                    {
                        tb_DueDates.Text += "Weekly Stress Level: " + num_assignments + Environment.NewLine;
                        counter++;
                    }
                    tb_DueDates.Text += date.Title + Environment.NewLine;
                }
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
		{
            tb_DueDates.Text = "";
            int num_assignments = 0;
            int counter = 0;
            Calendar cal = new CultureInfo("en-US").Calendar;
            int week = cal.GetWeekOfYear(e.End, CalendarWeekRule.FirstDay, DayOfWeek.Sunday);
            foreach (DueDate date in dates)
            {
                if (week == cal.GetWeekOfYear(date.EndDate, CalendarWeekRule.FirstDay, DayOfWeek.Sunday))
                {
                    num_assignments++;
                }
            }
            foreach (DueDate date in dates)
            {
                if ((date.EndDate.Month == e.End.Month) && (date.EndDate.Year == e.End.Year) && (date.EndDate.Day == e.End.Day))
                {
                    if (counter == 0)
                    {
                        tb_DueDates.Text += "Weekly Stress Level: " + num_assignments + Environment.NewLine;
                        counter++;
                    }
                    tb_DueDates.Text += date.Title + Environment.NewLine;
                }
            }
        }
    }
}
