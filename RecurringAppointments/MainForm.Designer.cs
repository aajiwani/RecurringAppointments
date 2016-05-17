/*
 * Created by SharpDevelop.
 * User: aajiwani
 * Date: 5/16/2016
 * Time: 11:50 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace RecurringAppointments
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtBoxSubject;
		private System.Windows.Forms.TextBox txtBoxDescription;
		private System.Windows.Forms.ComboBox cmbBoxRoom;
		private System.Windows.Forms.ListBox lstBoxAttendees;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.MonthCalendar calStartDate;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ListBox lstBoxDay;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox txtBoxResultsPath;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.NumericUpDown numericUpDownRecurrenes;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtBoxSubject = new System.Windows.Forms.TextBox();
			this.txtBoxDescription = new System.Windows.Forms.TextBox();
			this.cmbBoxRoom = new System.Windows.Forms.ComboBox();
			this.lstBoxAttendees = new System.Windows.Forms.ListBox();
			this.label5 = new System.Windows.Forms.Label();
			this.calStartDate = new System.Windows.Forms.MonthCalendar();
			this.label6 = new System.Windows.Forms.Label();
			this.lstBoxDay = new System.Windows.Forms.ListBox();
			this.label7 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.txtBoxResultsPath = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.numericUpDownRecurrenes = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownRecurrenes)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(94, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "Subject";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 49);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(94, 18);
			this.label2.TabIndex = 1;
			this.label2.Text = "Description";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 119);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(94, 18);
			this.label3.TabIndex = 2;
			this.label3.Text = "Room";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(12, 143);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(94, 18);
			this.label4.TabIndex = 3;
			this.label4.Text = "Attendees";
			// 
			// txtBoxSubject
			// 
			this.txtBoxSubject.Location = new System.Drawing.Point(112, 18);
			this.txtBoxSubject.Name = "txtBoxSubject";
			this.txtBoxSubject.Size = new System.Drawing.Size(227, 20);
			this.txtBoxSubject.TabIndex = 4;
			// 
			// txtBoxDescription
			// 
			this.txtBoxDescription.Location = new System.Drawing.Point(112, 46);
			this.txtBoxDescription.Multiline = true;
			this.txtBoxDescription.Name = "txtBoxDescription";
			this.txtBoxDescription.Size = new System.Drawing.Size(227, 64);
			this.txtBoxDescription.TabIndex = 5;
			// 
			// cmbBoxRoom
			// 
			this.cmbBoxRoom.FormattingEnabled = true;
			this.cmbBoxRoom.Location = new System.Drawing.Point(112, 116);
			this.cmbBoxRoom.Name = "cmbBoxRoom";
			this.cmbBoxRoom.Size = new System.Drawing.Size(227, 21);
			this.cmbBoxRoom.TabIndex = 6;
			// 
			// lstBoxAttendees
			// 
			this.lstBoxAttendees.FormattingEnabled = true;
			this.lstBoxAttendees.Location = new System.Drawing.Point(112, 143);
			this.lstBoxAttendees.Name = "lstBoxAttendees";
			this.lstBoxAttendees.Size = new System.Drawing.Size(227, 95);
			this.lstBoxAttendees.TabIndex = 7;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(12, 250);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(94, 18);
			this.label5.TabIndex = 8;
			this.label5.Text = "Start Date";
			// 
			// calStartDate
			// 
			this.calStartDate.Location = new System.Drawing.Point(112, 250);
			this.calStartDate.Name = "calStartDate";
			this.calStartDate.TabIndex = 9;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(360, 21);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(94, 18);
			this.label6.TabIndex = 10;
			this.label6.Text = "Recurrences";
			// 
			// lstBoxDay
			// 
			this.lstBoxDay.FormattingEnabled = true;
			this.lstBoxDay.Location = new System.Drawing.Point(460, 46);
			this.lstBoxDay.Name = "lstBoxDay";
			this.lstBoxDay.Size = new System.Drawing.Size(227, 95);
			this.lstBoxDay.TabIndex = 13;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(360, 46);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(94, 18);
			this.label7.TabIndex = 12;
			this.label7.Text = "Day";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(612, 215);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 14;
			this.button1.Text = "Calculate";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// txtBoxResultsPath
			// 
			this.txtBoxResultsPath.Location = new System.Drawing.Point(460, 189);
			this.txtBoxResultsPath.Name = "txtBoxResultsPath";
			this.txtBoxResultsPath.Size = new System.Drawing.Size(227, 20);
			this.txtBoxResultsPath.TabIndex = 16;
			this.txtBoxResultsPath.Text = "C:\\Users\\aajiwani\\Desktop\\aa.txt";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(360, 192);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(94, 18);
			this.label8.TabIndex = 15;
			this.label8.Text = "Path to results";
			// 
			// numericUpDownRecurrenes
			// 
			this.numericUpDownRecurrenes.Location = new System.Drawing.Point(460, 19);
			this.numericUpDownRecurrenes.Name = "numericUpDownRecurrenes";
			this.numericUpDownRecurrenes.Size = new System.Drawing.Size(227, 20);
			this.numericUpDownRecurrenes.TabIndex = 17;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(699, 491);
			this.Controls.Add(this.numericUpDownRecurrenes);
			this.Controls.Add(this.txtBoxResultsPath);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.lstBoxDay);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.calStartDate);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.lstBoxAttendees);
			this.Controls.Add(this.cmbBoxRoom);
			this.Controls.Add(this.txtBoxDescription);
			this.Controls.Add(this.txtBoxSubject);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.Text = "RecurringAppointments";
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownRecurrenes)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
