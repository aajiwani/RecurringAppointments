/*
 * Created by SharpDevelop.
 * User: aajiwani
 * Date: 5/17/2016
 * Time: 12:36 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace RecurringAppointments.AppCode
{
	/// <summary>
	/// Description of Appointment.
	/// </summary>
	public class Appointment
	{
		private DateTime _appointentDate;
		public DateTime AppointmentDate
		{
			get
			{
				return this._appointentDate;
			}
			set
			{
				this._appointentDate = value;
				this.AppointmentDay = value.DayOfWeek;
			}
		}
		
		public DayOfWeek AppointmentDay
		{
			get;
			set;
		}
		
		public String Subject
		{
			get;
			set;
		}
		
		public Int32 Room
		{
			get;
			set;
		}
		
		public String Description
		{
			get;
			set;
		}
		
		public String[] Attendees
		{
			get;
			set;
		}
		
		public Appointment()
		{
		}
	}
}
