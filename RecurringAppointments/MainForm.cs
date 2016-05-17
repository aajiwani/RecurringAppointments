/*
 * Created by SharpDevelop.
 * User: aajiwani
 * Date: 5/16/2016
 * Time: 11:50 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using RecurringAppointments.AppCode;

namespace RecurringAppointments
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			this.LoadDataSources();
		}
		
		private void LoadDataSources()
		{
			int[] rooms = new int[] { 1, 2, 3};
			this.cmbBoxRoom.DataSource = rooms;
			this.cmbBoxRoom.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.cmbBoxRoom.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.cmbBoxRoom.DropDownStyle = ComboBoxStyle.DropDownList;
			
			this.numericUpDownRecurrenes.Maximum = 99;
			this.numericUpDownRecurrenes.Minimum = 1;
			
			char[] attendees = new char[] { 'A', 'B', 'C' };
			this.lstBoxAttendees.DataSource = attendees;
			this.lstBoxAttendees.SelectionMode = SelectionMode.MultiSimple;
			
			Tuple<string, DayOfWeek>[] days = new Tuple<string, DayOfWeek>[] {
				new Tuple<string, DayOfWeek>("Monday", DayOfWeek.Monday),
				new Tuple<string, DayOfWeek>("Tuesday", DayOfWeek.Tuesday),
				new Tuple<string, DayOfWeek>("Wednesday", DayOfWeek.Wednesday),
				new Tuple<string, DayOfWeek>("Thursday", DayOfWeek.Thursday),
				new Tuple<string, DayOfWeek>("Friday", DayOfWeek.Friday)
			};
			this.lstBoxDay.DataSource = days;
			this.lstBoxDay.DisplayMember = "Item1";
			this.lstBoxDay.ValueMember = "Item2";
			this.lstBoxDay.SelectionMode = SelectionMode.MultiSimple;
			
			this.calStartDate.MaxSelectionCount = 1;
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			if (this.lstBoxDay.SelectedItems.Count == 0 || this.lstBoxAttendees.SelectedItems.Count == 0)
			{
				MessageBox.Show("You must select atleast 1 day and attendee to continue");
			}
			
			List<DayOfWeek> selectedDays = new List<DayOfWeek>();
			foreach (var item in this.lstBoxDay.SelectedItems)
			{
				selectedDays.Add(((Tuple<string, DayOfWeek>)item).Item2);
			}
			
			try
			{
				this.GenerateAppointments(this.calStartDate.SelectionRange.Start, selectedDays.ToArray(), Decimal.ToInt32(this.numericUpDownRecurrenes.Value));
			}
			catch (Exception)
			{
				MessageBox.Show("There was some error generating appointments for you, please try again later");
			}
		}
		
		private void GenerateAppointments(DateTime selectedDate, DayOfWeek[] selectedDays, int recurrences)
		{
			Appointment[] appoitnments = RecurrencesCalculator.GenerateAppointments(selectedDate, selectedDays, recurrences);
			List<String> attendees = new List<string>();
			
			foreach (var item in this.lstBoxAttendees.SelectedItems)
			{
				attendees.Add((char)item + "");
			}
			
			for (int i = 0; i < appoitnments.Length; i++)
			{
				appoitnments[i].Description = this.txtBoxDescription.Text;
				appoitnments[i].Room = (int)this.cmbBoxRoom.SelectedValue;
				appoitnments[i].Subject = this.txtBoxSubject.Text;
				appoitnments[i].Attendees = attendees.ToArray();
			}
			
			AppointmentFileWriter.WriteResults(this.txtBoxResultsPath.Text, appoitnments);
		}
	}
}
