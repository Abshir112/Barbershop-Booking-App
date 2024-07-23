using System;
using System.Collections.Generic;
using System.Linq;

namespace Barbershop_Booking_App
{
    /// <summary>
    /// Represents a barbershop with a list of barbers and appointments.
    /// </summary>
    public class BarberShop
    {
        private List<Barber> barbers;
        private List<Appointment> appointments;

        /// <summary>
        /// Initializes a new instance of the <see cref="BarberShop"/> class.
        /// </summary>
        public BarberShop()
        {
            barbers = new List<Barber>();
            appointments = new List<Appointment>();
        }

        // Barber Methods

        /// <summary>
        /// Adds a new barber to the list of barbers.
        /// </summary>
        /// <param name="barber">The barber to add.</param>
        public void AddBarber(Barber barber) => barbers.Add(barber);

        /// <summary>
        /// Removes a barber from the list of barbers.
        /// </summary>
        /// <param name="barber">The barber to remove.</param>
        public void RemoveBarber(Barber barber) => barbers.Remove(barber);

        /// <summary>
        /// Gets a barber by name.
        /// </summary>
        /// <param name="name">The name of the barber to get.</param>
        /// <returns>The barber with the specified name, or null if not found.</returns>
        public Barber GetBarber(string name) => barbers.FirstOrDefault(b => b.Name.ToString() == name);

        /// <summary>
        /// Updates the details of an existing barber.
        /// </summary>
        /// <param name="oldBarber">The existing barber to update.</param>
        /// <param name="newBarber">The new barber details.</param>
        public void UpdateBarber(Barber oldBarber, Barber newBarber)
        {
            int index = barbers.IndexOf(oldBarber);
            if (index != -1)
            {
                barbers[index] = newBarber;
            }
        }

        /// <summary>
        /// Gets the list of all barbers.
        /// </summary>
        /// <returns>The list of all barbers.</returns>
        public List<Barber> GetBarbers() => barbers;

        // Appointment Methods

        /// <summary>
        /// Adds a new appointment to the list of appointments.
        /// </summary>
        /// <param name="appointment">The appointment to add.</param>
        public void AddAppointment(Appointment appointment) => appointments.Add(appointment);

        /// <summary>
        /// Removes an appointment from the list of appointments.
        /// </summary>
        /// <param name="appointment">The appointment to remove.</param>
        public void RemoveAppointment(Appointment appointment) => appointments.Remove(appointment);

        /// <summary>
        /// Gets an appointment by customer name and appointment date.
        /// </summary>
        /// <param name="customerName">The name of the customer.</param>
        /// <param name="appointmentDate">The date of the appointment.</param>
        /// <returns>The appointment that matches the specified customer name and appointment date, or null if not found.</returns>
        public Appointment GetAppointment(string customerName, DateTime appointmentDate) =>
            appointments.FirstOrDefault(a => a.CustomerName == customerName && a.AppointmentDate == appointmentDate);

        /// <summary>
        /// Updates the details of an existing appointment.
        /// </summary>
        /// <param name="oldAppointment">The existing appointment to update.</param>
        /// <param name="newAppointment">The new appointment details.</param>
        public void UpdateAppointment(Appointment oldAppointment, Appointment newAppointment)
        {
            int index = appointments.IndexOf(oldAppointment);
            if (index != -1)
            {
                appointments[index] = newAppointment;
            }
        }

        /// <summary>
        /// Gets the list of all appointments.
        /// </summary>
        /// <returns>The list of all appointments.</returns>
        public List<Appointment> GetAppointments() => appointments;
    }
}
