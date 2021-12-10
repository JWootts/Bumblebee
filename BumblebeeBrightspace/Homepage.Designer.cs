
using BumblebeeBrightspace.Models;
using System.Windows.Forms;

namespace BumblebeeBrightspace
{
	partial class Homepage
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.logo = new System.Windows.Forms.PictureBox();
            this.l_welcome = new System.Windows.Forms.Label();
            this.b_logout = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.l_classCounter = new System.Windows.Forms.Label();
            this.b_Prev = new System.Windows.Forms.Button();
            this.b_Next = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grade = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_ClassNotes = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.l_Code = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.l_ClassName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.l_SelectedDay = new System.Windows.Forms.Label();
            this.tb_DueDates = new System.Windows.Forms.TextBox();
            this.calendar_DueDates = new System.Windows.Forms.MonthCalendar();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_NewClassNote = new System.Windows.Forms.TextBox();
            this.b_AddClassNotes = new System.Windows.Forms.Button();
            this.b_viewClassNotes = new System.Windows.Forms.Button();
            this.cb_classNames = new System.Windows.Forms.ComboBox();
            this.l_classNoteHeader = new System.Windows.Forms.Label();
            this.l_Notes = new System.Windows.Forms.TextBox();
            this.bumblebeeLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.l_Name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bumblebeeLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.Location = new System.Drawing.Point(12, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(203, 57);
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // l_welcome
            // 
            this.l_welcome.AutoSize = true;
            this.l_welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_welcome.Location = new System.Drawing.Point(688, 0);
            this.l_welcome.Name = "l_welcome";
            this.l_welcome.Size = new System.Drawing.Size(91, 24);
            this.l_welcome.TabIndex = 1;
            this.l_welcome.Text = "Welcome";
            // 
            // b_logout
            // 
            this.b_logout.Location = new System.Drawing.Point(692, 42);
            this.b_logout.Name = "b_logout";
            this.b_logout.Size = new System.Drawing.Size(96, 27);
            this.b_logout.TabIndex = 2;
            this.b_logout.Text = "Logout";
            this.b_logout.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 75);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 363);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.l_classCounter);
            this.tabPage1.Controls.Add(this.b_Prev);
            this.tabPage1.Controls.Add(this.b_Next);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 337);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Class List";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // l_classCounter
            // 
            this.l_classCounter.AutoSize = true;
            this.l_classCounter.Location = new System.Drawing.Point(326, 303);
            this.l_classCounter.Name = "l_classCounter";
            this.l_classCounter.Size = new System.Drawing.Size(24, 13);
            this.l_classCounter.TabIndex = 4;
            this.l_classCounter.Text = "0/0";
            // 
            // b_Prev
            // 
            this.b_Prev.Location = new System.Drawing.Point(183, 297);
            this.b_Prev.Name = "b_Prev";
            this.b_Prev.Size = new System.Drawing.Size(123, 23);
            this.b_Prev.TabIndex = 3;
            this.b_Prev.Text = "< Prev";
            this.b_Prev.UseVisualStyleBackColor = true;
            this.b_Prev.Click += new System.EventHandler(this.b_Prev_Click);
            // 
            // b_Next
            // 
            this.b_Next.Location = new System.Drawing.Point(378, 297);
            this.b_Next.Name = "b_Next";
            this.b_Next.Size = new System.Drawing.Size(123, 23);
            this.b_Next.TabIndex = 2;
            this.b_Next.Text = "Next >";
            this.b_Next.UseVisualStyleBackColor = true;
            this.b_Next.Click += new System.EventHandler(this.b_Next_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grade);
            this.groupBox2.Location = new System.Drawing.Point(358, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(320, 285);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Grade Book";
            // 
            // grade
            // 
            this.grade.Location = new System.Drawing.Point(6, 13);
            this.grade.Multiline = true;
            this.grade.Name = "grade";
            this.grade.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grade.Size = new System.Drawing.Size(308, 266);
            this.grade.TabIndex = 0;
            this.grade.TextChanged += new System.EventHandler(this.grade_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_ClassNotes);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.l_Code);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.l_ClassName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 285);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Basic Information";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Quick Note:";
            // 
            // tb_ClassNotes
            // 
            this.tb_ClassNotes.Location = new System.Drawing.Point(48, 158);
            this.tb_ClassNotes.Multiline = true;
            this.tb_ClassNotes.Name = "tb_ClassNotes";
            this.tb_ClassNotes.Size = new System.Drawing.Size(268, 48);
            this.tb_ClassNotes.TabIndex = 7;
            this.tb_ClassNotes.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(66, 241);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(234, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "View Class Note(s)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(66, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add Class Note";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // l_Code
            // 
            this.l_Code.AutoSize = true;
            this.l_Code.Location = new System.Drawing.Point(63, 102);
            this.l_Code.Name = "l_Code";
            this.l_Code.Size = new System.Drawing.Size(66, 13);
            this.l_Code.TabIndex = 3;
            this.l_Code.Text = "[Class Code]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Class Code";
            // 
            // l_ClassName
            // 
            this.l_ClassName.AutoSize = true;
            this.l_ClassName.Location = new System.Drawing.Point(63, 45);
            this.l_ClassName.Name = "l_ClassName";
            this.l_ClassName.Size = new System.Drawing.Size(69, 13);
            this.l_ClassName.TabIndex = 1;
            this.l_ClassName.Text = "[Class Name]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Class Name";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.l_SelectedDay);
            this.tabPage2.Controls.Add(this.tb_DueDates);
            this.tabPage2.Controls.Add(this.calendar_DueDates);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 337);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Calander";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // l_SelectedDay
            // 
            this.l_SelectedDay.AutoSize = true;
            this.l_SelectedDay.Location = new System.Drawing.Point(179, 194);
            this.l_SelectedDay.Name = "l_SelectedDay";
            this.l_SelectedDay.Size = new System.Drawing.Size(159, 13);
            this.l_SelectedDay.TabIndex = 2;
            this.l_SelectedDay.Text = "Selected Day Assignments Due:";
            // 
            // tb_DueDates
            // 
            this.tb_DueDates.Location = new System.Drawing.Point(182, 210);
            this.tb_DueDates.Multiline = true;
            this.tb_DueDates.Name = "tb_DueDates";
            this.tb_DueDates.Size = new System.Drawing.Size(367, 102);
            this.tb_DueDates.TabIndex = 1;
            // 
            // calendar_DueDates
            // 
            this.calendar_DueDates.CalendarDimensions = new System.Drawing.Size(2, 1);
            this.calendar_DueDates.Location = new System.Drawing.Point(130, 12);
            this.calendar_DueDates.Name = "calendar_DueDates";
            this.calendar_DueDates.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.calendar_DueDates.TabIndex = 0;
            this.calendar_DueDates.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.tb_NewClassNote);
            this.tabPage3.Controls.Add(this.b_AddClassNotes);
            this.tabPage3.Controls.Add(this.b_viewClassNotes);
            this.tabPage3.Controls.Add(this.cb_classNames);
            this.tabPage3.Controls.Add(this.l_classNoteHeader);
            this.tabPage3.Controls.Add(this.l_Notes);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(768, 337);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Class Notes";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Please select a class;";
            // 
            // tb_NewClassNote
            // 
            this.tb_NewClassNote.Location = new System.Drawing.Point(6, 159);
            this.tb_NewClassNote.Multiline = true;
            this.tb_NewClassNote.Name = "tb_NewClassNote";
            this.tb_NewClassNote.Size = new System.Drawing.Size(170, 98);
            this.tb_NewClassNote.TabIndex = 9;
            // 
            // b_AddClassNotes
            // 
            this.b_AddClassNotes.Location = new System.Drawing.Point(25, 129);
            this.b_AddClassNotes.Name = "b_AddClassNotes";
            this.b_AddClassNotes.Size = new System.Drawing.Size(137, 23);
            this.b_AddClassNotes.TabIndex = 8;
            this.b_AddClassNotes.Text = "Add New Note";
            this.b_AddClassNotes.UseVisualStyleBackColor = true;
            this.b_AddClassNotes.Click += new System.EventHandler(this.b_AddClassNotes_Click);
            // 
            // b_viewClassNotes
            // 
            this.b_viewClassNotes.Location = new System.Drawing.Point(25, 100);
            this.b_viewClassNotes.Name = "b_viewClassNotes";
            this.b_viewClassNotes.Size = new System.Drawing.Size(137, 23);
            this.b_viewClassNotes.TabIndex = 7;
            this.b_viewClassNotes.Text = "View Class Notes";
            this.b_viewClassNotes.UseVisualStyleBackColor = true;
            this.b_viewClassNotes.Click += new System.EventHandler(this.button3_Click);
            // 
            // cb_classNames
            // 
            this.cb_classNames.FormattingEnabled = true;
            this.cb_classNames.Location = new System.Drawing.Point(15, 73);
            this.cb_classNames.Name = "cb_classNames";
            this.cb_classNames.Size = new System.Drawing.Size(161, 21);
            this.cb_classNames.TabIndex = 6;
            this.cb_classNames.SelectedIndexChanged += new System.EventHandler(this.cb_classNames_SelectedIndexChanged);
            // 
            // l_classNoteHeader
            // 
            this.l_classNoteHeader.AutoSize = true;
            this.l_classNoteHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_classNoteHeader.Location = new System.Drawing.Point(199, 27);
            this.l_classNoteHeader.Name = "l_classNoteHeader";
            this.l_classNoteHeader.Size = new System.Drawing.Size(0, 24);
            this.l_classNoteHeader.TabIndex = 5;
            // 
            // l_Notes
            // 
            this.l_Notes.Location = new System.Drawing.Point(182, 42);
            this.l_Notes.Multiline = true;
            this.l_Notes.Name = "l_Notes";
            this.l_Notes.Size = new System.Drawing.Size(499, 272);
            this.l_Notes.TabIndex = 4;
            // 
            // bumblebeeLogo
            // 
            this.bumblebeeLogo.Location = new System.Drawing.Point(198, 0);
            this.bumblebeeLogo.Name = "bumblebeeLogo";
            this.bumblebeeLogo.Size = new System.Drawing.Size(124, 80);
            this.bumblebeeLogo.TabIndex = 4;
            this.bumblebeeLogo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(312, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "BumbleBee";
            // 
            // l_Name
            // 
            this.l_Name.AutoSize = true;
            this.l_Name.Location = new System.Drawing.Point(689, 24);
            this.l_Name.Name = "l_Name";
            this.l_Name.Size = new System.Drawing.Size(104, 13);
            this.l_Name.TabIndex = 6;
            this.l_Name.Text = "Firstname, Lastname";
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.l_Name);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.bumblebeeLogo);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.b_logout);
            this.Controls.Add(this.l_welcome);
            this.Controls.Add(this.label1);
            this.Name = "Homepage";
            this.Text = "Homepage";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bumblebeeLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox logo;
		private System.Windows.Forms.Label l_welcome;
		private System.Windows.Forms.Button b_logout;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.PictureBox bumblebeeLogo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label l_Name;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button b_Prev;
		private System.Windows.Forms.Button b_Next;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label l_Code;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label l_ClassName;
		private System.Windows.Forms.Label l_classCounter;
		private System.Windows.Forms.TextBox grade;
		private Button button2;
		private Button button1;
		private TextBox tb_ClassNotes;
		private TextBox l_Notes;
		private Label l_classNoteHeader;
		private Label label3;
		private TextBox tb_NewClassNote;
		private Button b_AddClassNotes;
		private Button b_viewClassNotes;
		private ComboBox cb_classNames;
		private Label label4;
		private MonthCalendar calendar_DueDates;
		private Label l_SelectedDay;
		private TextBox tb_DueDates;
	}
}