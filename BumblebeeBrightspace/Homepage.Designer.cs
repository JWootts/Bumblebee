
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
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.bumblebeeLogo = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.l_Name = new System.Windows.Forms.Label();
			this.l_Notes = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.b_Next = new System.Windows.Forms.Button();
			this.b_Prev = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.l_ClassName = new System.Windows.Forms.Label();
			this.l_Code = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.l_classCounter = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bumblebeeLogo)).BeginInit();
			this.groupBox1.SuspendLayout();
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
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(768, 337);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Calander";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// tabPage3
			// 
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(768, 337);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Class Notes";
			this.tabPage3.UseVisualStyleBackColor = true;
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
			// groupBox1
			// 
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
			// groupBox2
			// 
			this.groupBox2.Location = new System.Drawing.Point(358, 6);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(320, 285);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Grade Book";
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
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(16, 20);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Class Name";
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
			// l_Code
			// 
			this.l_Code.AutoSize = true;
			this.l_Code.Location = new System.Drawing.Point(63, 102);
			this.l_Code.Name = "l_Code";
			this.l_Code.Size = new System.Drawing.Size(66, 13);
			this.l_Code.TabIndex = 3;
			this.l_Code.Text = "[Class Code]";
			// 
			// l_Notes
			// 
			this.l_Notes.AutoSize = true;
			this.l_Notes.Location = new System.Drawing.Point(63, 102);
			this.l_Notes.Name = "l_Notes";
			this.l_Notes.Size = new System.Drawing.Size(66, 13);
			this.l_Notes.TabIndex = 3;
			this.l_Notes.Text = "[Class Notes]";
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
			// l_classCounter
			// 
			this.l_classCounter.AutoSize = true;
			this.l_classCounter.Location = new System.Drawing.Point(326, 303);
			this.l_classCounter.Name = "l_classCounter";
			this.l_classCounter.Size = new System.Drawing.Size(24, 13);
			this.l_classCounter.TabIndex = 4;
			this.l_classCounter.Text = "0/0";
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
			this.tabPage3.Controls.Add(this.l_Notes);
			((System.ComponentModel.ISupportInitialize)(this.bumblebeeLogo)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
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
		private System.Windows.Forms.Label l_Notes;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label l_ClassName;
		private System.Windows.Forms.Label l_classCounter;
	}
}