using System;

namespace Barbershop_Booking_App
{
    /// <summary>
    /// Represents an appointment in the barbershop.
    /// </summary>
    public class Appointment
    {
        /// <summary>
        /// Gets or sets the customer's name.
        /// </summary>
        public string CustomerName { get; set; }

        /// <summary>
        /// Gets or sets the name of the barber.
        /// </summary>
        public BarberEnum BarberName { get; set; }

        /// <summary>
        /// Gets or sets the date and time of the appointment.
        /// </summary>
        public DateTime AppointmentDate { get; set; }

        /// <summary>
        /// Gets or sets the style of haircut.
        /// </summary>
        public HairCutStyle HairCut { get; set; }

        /// <summary>
        /// Gets or sets the time of the appointment.
        /// </summary>
        public string Time { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Appointment"/> class.
        /// </summary>
        /// <param name="customerName">The name of the customer.</param>
        /// <param name="barberName">The name of the barber.</param>
        /// <param name="appointmentDate">The date and time of the appointment.</param>
        /// <param name="hairCut">The style of haircut.</param>
        /// <param name="time">The time of the appointment.</param>
        public Appointment(string customerName, BarberEnum barberName, DateTime appointmentDate, HairCutStyle hairCut, string time)
        {
            CustomerName = customerName;
            BarberName = barberName;
            AppointmentDate = appointmentDate;
            HairCut = hairCut;
            Time = time;
        }

        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>A string that represents the current object.</returns>
        public override string ToString()
        {
            return
                $"{CustomerName.PadRight(16)}" +
                $" {BarberName.ToString().PadRight(18)} " +
                $"{HairCut.ToString().PadRight(15)}" +
                $" {AppointmentDate.ToString("MM/dd/yyyy").PadRight(15)} " +
                $"{AppointmentDate.ToString("HH:mm")}";
        }
    }
}
