using System;
using System.Windows.Forms;

namespace Barbershop_Booking_App
{
    /// <summary>
    /// Main form for the Barbershop Booking application.
    /// </summary>
    public partial class MainForm : Form
    {
        private BarberShop barberShop;
        private const string AdminPin = "1234"; // PIN for admin access

        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            barberShop = new BarberShop();
            PopulateBarberComboBox();
        }

        /// <summary>
        /// Populates the barber combo box with values from the <see cref="BarberEnum"/>.
        /// </summary>
        private void PopulateBarberComboBox()
        {
            // Populate the ComboBox with enum values
            barberComboBox.DataSource = Enum.GetValues(typeof(BarberEnum));

            // Populate the Hair Style cut ComboBox with enum values
            hairCutComboBox.DataSource = Enum.GetValues(typeof(HairCutStyle));

            // Populate the timeComboBox with 45-minute intervals, starting from 9:00 AM to 5:45 PM
            DateTime time = DateTime.Today.AddHours(9);
            while (time.Hour < 17 || (time.Hour == 17 && time.Minute == 0))
            {
                timeComboBox.Items.Add(time.ToShortTimeString());
                time = time.AddMinutes(45);
            }

            // Add all the BarberEnum values to the barberShop with different experiences
            for (int i = 0; i < Enum.GetValues(typeof(BarberEnum)).Length; i++)
            {
                barberShop.AddBarber(new Barber(Enum.GetValues(typeof(BarberEnum)).GetValue(i).ToString(), i + 1));
            }
        }

        /// <summary>
        /// Handles the Click event of the BookAppointment button.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BookAppointment_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(customerNameTextBox.Text) || barberComboBox.SelectedIndex == -1 ||
                               hairCutComboBox.SelectedIndex == -1 || timeComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all fields!", "Error");
                return;
            }

            string customerName = customerNameTextBox.Text;
            BarberEnum barberName = (BarberEnum)barberComboBox.SelectedItem;
            DateTime appointmentDate = appointmentDateTimePicker.Value;
            HairCutStyle hairCut = (HairCutStyle)hairCutComboBox.SelectedItem;
            string time = timeComboBox.SelectedItem.ToString();

            DateTime appointmentDateTime = CombineDateAndTime(appointmentDate, time);

            Appointment appointment = new Appointment(customerName, barberName, appointmentDateTime, hairCut, time);
            barberShop.AddAppointment(appointment);
            UpdateCustomerInfoListBox();
            ClearFields();

            MessageBox.Show("Appointment booked successfully!", "Booked");
        }

        /// <summary>
        /// Handles the Click event of the Update button.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(customerNameTextBox.Text) || barberComboBox.SelectedIndex == -1 ||
                               hairCutComboBox.SelectedIndex == -1 || timeComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all fields or select an appointment to update!", "Error");
                return;
            }
            if (customerInfoListBox.SelectedItem is Appointment oldAppointment)
            {
                string customerName = customerNameTextBox.Text;
                BarberEnum barberName = (BarberEnum)barberComboBox.SelectedItem;
                DateTime appointmentDate = appointmentDateTimePicker.Value;
                HairCutStyle hairCut = (HairCutStyle)hairCutComboBox.SelectedItem;
                string time = timeComboBox.SelectedItem.ToString();

                DateTime appointmentDateTime = CombineDateAndTime(appointmentDate, time);

                Appointment newAppointment = new Appointment(customerName, barberName, appointmentDateTime, hairCut, time);
                barberShop.UpdateAppointment(oldAppointment, newAppointment);
                UpdateCustomerInfoListBox();
                ClearFields();

                MessageBox.Show("Appointment updated successfully!");
            }
            else
            {
                MessageBox.Show("Select an appointment to update!");
            }
        }

        /// <summary>
        /// Handles the Click event of the Delete button.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (customerInfoListBox.SelectedItem is Appointment appointment)
            {
                barberShop.RemoveAppointment(appointment);
                UpdateCustomerInfoListBox();
                ClearFields();

                MessageBox.Show("Appointment deleted successfully!");
            }
            else
            {
                MessageBox.Show("Select an appointment to delete!");
            }
        }

        /// <summary>
        /// Handles the Click event of the Admin button.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void AdminButton_Click(object sender, EventArgs e)
        {
            string inputPin = Microsoft.VisualBasic.Interaction.InputBox("Enter Admin PIN", "Admin Authentication", "");

            if (inputPin == AdminPin)
            {
                AdminForm adminForm = new AdminForm(barberShop);
                adminForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid authorization!");
            }
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the customerInfoListBox.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void CustomerInfoListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (customerInfoListBox.SelectedItem is Appointment appointment)
            {
                customerNameTextBox.Text = appointment.CustomerName;
                barberComboBox.SelectedItem = appointment.BarberName;
                appointmentDateTimePicker.Value = appointment.AppointmentDate.Date;
                hairCutComboBox.SelectedItem = appointment.HairCut;
                timeComboBox.SelectedItem = appointment.AppointmentDate.ToShortTimeString();
            }
        }

        /// <summary>
        /// Updates the customer information list box with the current appointments.
        /// </summary>
        private void UpdateCustomerInfoListBox()
        {
            customerInfoListBox.DataSource = null;
            customerInfoListBox.DataSource = barberShop.GetAppointments();
            customerInfoListBox.DisplayMember = ""; // Use ToString method of Appointment
        }

        /// <summary>
        /// Clears the input fields on the form.
        /// </summary>
        private void ClearFields()
        {
            customerNameTextBox.Clear();
            barberComboBox.SelectedIndex = -1;
            appointmentDateTimePicker.Value = DateTime.Now;
            hairCutComboBox.SelectedIndex = -1;
            timeComboBox.SelectedIndex = -1;
        }

        /// <summary>
        /// Combines the date and time into a single DateTime object.
        /// </summary>
        /// <param name="date">The date component.</param>
        /// <param name="time">The time component.</param>
        /// <returns>The combined DateTime object.</returns>
        private DateTime CombineDateAndTime(DateTime date, string time)
        {
            DateTime timePart = DateTime.Parse(time);
            return new DateTime(date.Year, date.Month, date.Day, timePart.Hour, timePart.Minute, timePart.Second);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // No implementation required
        }

        private void datelbl_Click(object sender, EventArgs e)
        {
            // No implementation required
        }
    }
}
