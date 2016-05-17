/*
 * Created by SharpDevelop.
 * User: aajiwani
 * Date: 5/17/2016
 * Time: 12:10 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;
using System.Collections.Generic;

namespace RecurringAppointments.AppCode
{
	/// <summary>
	/// Description of RecurrencesCalculator.
	/// </summary>
	public class RecurrencesCalculator
	{
		public RecurrencesCalculator()
		{
		}
		
		public static Appointment[] GenerateAppointments(DateTime startDate, DayOfWeek[] selectedDays, int recurrences)
		{
			List<Appointment> appointments = new List<Appointment>();
			
			while (recurrences != 0)
			{
				foreach (DayOfWeek day in selectedDays)
				{
					if (recurrences > 0)
					{
						Appointment app = new Appointment();
						app.AppointmentDate = GetNextWeekday(startDate, day);
						
						startDate = app.AppointmentDate;
						
						appointments.Add(app);
						recurrences--;
					}
				}
			}
			
			return appointments.ToArray();
		}
		
		private static DateTime GetNextWeekday(DateTime start, DayOfWeek day)
		{
    		// The (... + 7) % 7 ensures we end up with a value in the range [0, 6]
    		int daysToAdd = ((int) day - (int) start.DayOfWeek + 7) % 7;
    		return start.AddDays(daysToAdd);
		}
	}
}
