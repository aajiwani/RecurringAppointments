/*
 * Created by SharpDevelop.
 * User: aajiwani
 * Date: 5/17/2016
 * Time: 12:49 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using Newtonsoft.Json;

namespace RecurringAppointments.AppCode
{
	/// <summary>
	/// Description of Appointment.
	/// </summary>
	public class AppointmentFileWriter
	{	
		public AppointmentFileWriter()
		{
			
		}
		
		public static void WriteResults(string path, Appointment[] appointments)
		{
			string json = JsonConvert.SerializeObject(appointments);
			System.IO.File.WriteAllText (path, json);
		}
	}
}
