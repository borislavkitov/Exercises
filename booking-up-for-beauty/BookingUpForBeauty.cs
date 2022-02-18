using System;
using System.Globalization;

static class Appointment
{
    //public static DateTime Schedule(string appointmentDateDescription)
    //{
    //    string[] formats = new string[] { "M/dd/yyyy HH:mm:ss", "MMMM d, yyyy HH:mm:ss", "dddd, MMMM d, yyyy HH:mm:ss" };
    //    return DateTime.ParseExact(appointmentDateDescription, formats, System.Globalization.CultureInfo.InvariantCulture);
    //}

    public static DateTime Schedule(string appointmentDateDescription) => DateTime.Parse(appointmentDateDescription, CultureInfo.InvariantCulture);

    public static bool HasPassed(DateTime appointmentDate) => DateTime.Now > appointmentDate;

    public static bool IsAfternoonAppointment(DateTime appointmentDate) => appointmentDate.ToString("tt") == "PM" && appointmentDate.Hour < 18 ;

    public static string Description(DateTime appointmentDate) => $"You have an appointment on {appointmentDate.ToString("M'/'d'/'yyyy h:mm:ss tt")}.";

    public static DateTime AnniversaryDate() => new DateTime(DateTime.Now.Year, 9, 15, 0, 0, 0);
}
