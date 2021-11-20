
namespace BumblebeeBrightspace
{
	partial class Login
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
			this.tb_User = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tb_Pass = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tb_SchoolDomain = new System.Windows.Forms.TextBox();
			this.cb_FanshaweStudent = new System.Windows.Forms.CheckBox();
			this.label4 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.b_Submit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// tb_User
			// 
			this.tb_User.Location = new System.Drawing.Point(138, 73);
			this.tb_User.Name = "tb_User";
			this.tb_User.Size = new System.Drawing.Size(184, 20);
			this.tb_User.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(200, 57);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Username:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(200, 100);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Password:";
			// 
			// tb_Pass
			// 
			this.tb_Pass.Location = new System.Drawing.Point(138, 116);
			this.tb_Pass.Name = "tb_Pass";
			this.tb_Pass.Size = new System.Drawing.Size(184, 20);
			this.tb_Pass.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(172, 152);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(111, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "School Login Domain:";
			// 
			// tb_SchoolDomain
			// 
			this.tb_SchoolDomain.Location = new System.Drawing.Point(103, 168);
			this.tb_SchoolDomain.Name = "tb_SchoolDomain";
			this.tb_SchoolDomain.Size = new System.Drawing.Size(258, 20);
			this.tb_SchoolDomain.TabIndex = 5;
			// 
			// cb_FanshaweStudent
			// 
			this.cb_FanshaweStudent.AutoSize = true;
			this.cb_FanshaweStudent.Location = new System.Drawing.Point(162, 194);
			this.cb_FanshaweStudent.Name = "cb_FanshaweStudent";
			this.cb_FanshaweStudent.Size = new System.Drawing.Size(121, 17);
			this.cb_FanshaweStudent.TabIndex = 7;
			this.cb_FanshaweStudent.Text = "Fanshawe Student?";
			this.cb_FanshaweStudent.UseVisualStyleBackColor = true;
			this.cb_FanshaweStudent.CheckedChanged += new System.EventHandler(this.cb_FanshaweStudent_CheckedChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(143, 8);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(179, 25);
			this.label4.TabIndex = 8;
			this.label4.Text = "Bumblebee Login";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 233);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(92, 23);
			this.button1.TabIndex = 9;
			this.button1.Text = "Contact Help";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// b_Submit
			// 
			this.b_Submit.Location = new System.Drawing.Point(175, 221);
			this.b_Submit.Name = "b_Submit";
			this.b_Submit.Size = new System.Drawing.Size(108, 23);
			this.b_Submit.TabIndex = 10;
			this.b_Submit.Text = "Submit";
			this.b_Submit.UseVisualStyleBackColor = true;
			this.b_Submit.Click += new System.EventHandler(this.b_Submit_Click);
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(459, 268);
			this.Controls.Add(this.b_Submit);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.cb_FanshaweStudent);
			this.Controls.Add(this.tb_SchoolDomain);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tb_Pass);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tb_User);
			this.Name = "Login";
			this.Text = "Login";
			this.Activated += new System.EventHandler(this.Form1_Activated);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tb_User;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tb_Pass;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tb_SchoolDomain;
		private System.Windows.Forms.CheckBox cb_FanshaweStudent;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button b_Submit;
	}
}

