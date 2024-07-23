using System;
using System.Windows.Forms;

namespace Barbershop_Booking_App
{
    /// <summary>
    /// Admin form for managing barbers and appointments.
    /// </summary>
    public partial class AdminForm : Form
    {
        private BarberShop barberShop;

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminForm"/> class.
        /// </summary>
        /// <param name="shop">The <see cref="BarberShop"/> instance to manage.</param>
        public AdminForm(BarberShop shop)
        {
            InitializeComponent();
            barberShop = shop;
            LoadAppointments();
            LoadBarbers();
        }

        /// <summary>
        /// Loads the appointments into the appointments list box.
        /// </summary>
        private void LoadAppointments()
        {
            appointmentsListBox.DataSource = null;
            appointmentsListBox.DataSource = barberShop.GetAppointments();
            appointmentsListBox.DisplayMember = ""; // Use ToString method of Appointment
        }

        /// <summary>
        /// Loads the barbers into the barbers list box.
        /// </summary>
        private void LoadBarbers()
        {
            barbersListBox.DataSource = null;
            barbersListBox.DataSource = barberShop.GetBarbers();
        }

        /// <summary>
        /// Handles the Click event of the AddBarber button.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void AddBarberButton_Click(object sender, EventArgs e)
        {
            string name = barberNameTextBox.Text;
            int experience;

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Barber name cannot be empty!", "Error");
                return;
            }

            if (!int.TryParse(experienceTextBox.Text, out experience))
            {
                MessageBox.Show("Experience must be a valid number!", "Error");
                return;
            }

            // check if barber already exists
            if (barberShop.GetBarber(name) != null)
            {
                MessageBox.Show("Barber already exists!", "Oops");
                return;
            }

            Barber barber = new Barber(name, experience);
            barberShop.AddBarber(barber);

            MessageBox.Show("Barber added successfully!", "Message");
            LoadBarbers();
            ClearBarberFields();
        }

        /// <summary>
        /// Handles the Click event of the UpdateBarber button.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void UpdateBarberButton_Click(object sender, EventArgs e)
        {
            if (barbersListBox.SelectedItem is Barber oldBarber)
            {
                string name = barberNameTextBox.Text;
                int experience;

                if (string.IsNullOrWhiteSpace(name))
                {
                    MessageBox.Show("Barber name cannot be empty!", "Error");
                    return;
                }

                if (!int.TryParse(experienceTextBox.Text, out experience))
                {
                    MessageBox.Show("Experience must be a valid number!", "Error");
                    return;
                }

                // Update the barber details
                oldBarber.Name = name;
                oldBarber.Experience = experience;

                barberShop.UpdateBarber(oldBarber, oldBarber);

                MessageBox.Show("Barber updated successfully!", "Updated");
                LoadBarbers();
                ClearBarberFields();
            }
            else
            {
                MessageBox.Show("Select a barber to update!", "Error");
            }
        }

        /// <summary>
        /// Handles the Click event of the DeleteBarber button.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void DeleteBarberButton_Click(object sender, EventArgs e)
        {
            if (barbersListBox.SelectedItem is Barber barber)
            {
                barberShop.RemoveBarber(barber);
                MessageBox.Show("Barber deleted successfully!", "Deleted");
                LoadBarbers();
            }
            else
            {
                MessageBox.Show("Select a barber to delete!", "Error");
            }
        }

        /// <summary>
        /// Handles the Click event of the Refresh button.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void RefreshButton_Click(object sender, EventArgs e)
        {
            LoadAppointments();
            LoadBarbers();
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the barbersListBox.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BarbersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (barbersListBox.SelectedItem is Barber barber)
            {
                barberNameTextBox.Text = barber.Name;
                experienceTextBox.Text = barber.Experience.ToString();
            }
        }

        /// <summary>
        /// Clears the barber name and experience text fields.
        /// </summary>
        private void ClearBarberFields()
        {
            barberNameTextBox.Clear();
            experienceTextBox.Clear();
        }

        /// <summary>
        /// Handles the Load event of the AdminForm.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void AdminForm_Load(object sender, EventArgs e)
        {
            LoadAppointments();
            LoadBarbers();
        }
    }
}
