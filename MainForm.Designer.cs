namespace Barbershop_Booking_App
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            barberComboBox = new ComboBox();
            customerNameTextBox = new TextBox();
            customerNamelbl = new Label();
            SelectBarberlbl = new Label();
            appointmentDateTimePicker = new DateTimePicker();
            selectDatelbl = new Label();
            AdminButton = new Button();
            BookAppointment = new Button();
            UpdateButton = new Button();
            DeleteButton = new Button();
            customerInfoListBox = new ListBox();
            customerName = new Label();
            barberNamelbl = new Label();
            datelbl = new Label();
            label2 = new Label();
            hairCutComboBox = new ComboBox();
            label1 = new Label();
            timelbl = new Label();
            timeComboBox = new ComboBox();
            timelabel = new Label();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // barberComboBox
            // 
            barberComboBox.FormattingEnabled = true;
            barberComboBox.Location = new Point(6, 139);
            barberComboBox.Name = "barberComboBox";
            barberComboBox.Size = new Size(184, 33);
            barberComboBox.TabIndex = 0;
            // 
            // customerNameTextBox
            // 
            customerNameTextBox.Location = new Point(6, 67);
            customerNameTextBox.Name = "customerNameTextBox";
            customerNameTextBox.Size = new Size(150, 31);
            customerNameTextBox.TabIndex = 1;
            // 
            // customerNamelbl
            // 
            customerNamelbl.AutoSize = true;
            customerNamelbl.Location = new Point(6, 39);
            customerNamelbl.Name = "customerNamelbl";
            customerNamelbl.Size = new Size(104, 25);
            customerNamelbl.TabIndex = 2;
            customerNamelbl.Text = "Enter Name";
            // 
            // SelectBarberlbl
            // 
            SelectBarberlbl.AutoSize = true;
            SelectBarberlbl.Location = new Point(6, 111);
            SelectBarberlbl.Name = "SelectBarberlbl";
            SelectBarberlbl.Size = new Size(114, 25);
            SelectBarberlbl.TabIndex = 3;
            SelectBarberlbl.Text = "Select Barber";
            // 
            // appointmentDateTimePicker
            // 
            appointmentDateTimePicker.Location = new Point(6, 355);
            appointmentDateTimePicker.Name = "appointmentDateTimePicker";
            appointmentDateTimePicker.Size = new Size(300, 31);
            appointmentDateTimePicker.TabIndex = 4;
            // 
            // selectDatelbl
            // 
            selectDatelbl.AutoSize = true;
            selectDatelbl.Location = new Point(6, 321);
            selectDatelbl.Name = "selectDatelbl";
            selectDatelbl.Size = new Size(100, 25);
            selectDatelbl.TabIndex = 5;
            selectDatelbl.Text = "Select Date";
            // 
            // AdminButton
            // 
            AdminButton.Location = new Point(811, 439);
            AdminButton.Name = "AdminButton";
            AdminButton.Size = new Size(84, 38);
            AdminButton.TabIndex = 7;
            AdminButton.Text = "Admin";
            AdminButton.UseVisualStyleBackColor = true;
            AdminButton.Click += AdminButton_Click;
            // 
            // BookAppointment
            // 
            BookAppointment.Location = new Point(30, 443);
            BookAppointment.Name = "BookAppointment";
            BookAppointment.Size = new Size(112, 34);
            BookAppointment.TabIndex = 8;
            BookAppointment.Text = "Book";
            BookAppointment.UseVisualStyleBackColor = true;
            BookAppointment.Click += BookAppointment_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.Location = new Point(222, 443);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(112, 34);
            UpdateButton.TabIndex = 9;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(414, 443);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(112, 34);
            DeleteButton.TabIndex = 10;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // customerInfoListBox
            // 
            customerInfoListBox.FormattingEnabled = true;
            customerInfoListBox.ItemHeight = 25;
            customerInfoListBox.Location = new Point(364, 93);
            customerInfoListBox.Name = "customerInfoListBox";
            customerInfoListBox.Size = new Size(539, 329);
            customerInfoListBox.TabIndex = 11;
            customerInfoListBox.SelectedIndexChanged += CustomerInfoListBox_SelectedIndexChanged;
            // 
            // customerName
            // 
            customerName.AutoSize = true;
            customerName.Location = new Point(364, 52);
            customerName.Name = "customerName";
            customerName.Size = new Size(59, 25);
            customerName.TabIndex = 13;
            customerName.Text = "Name";
            // 
            // barberNamelbl
            // 
            barberNamelbl.AutoSize = true;
            barberNamelbl.Location = new Point(472, 52);
            barberNamelbl.Name = "barberNamelbl";
            barberNamelbl.Size = new Size(63, 25);
            barberNamelbl.TabIndex = 14;
            barberNamelbl.Text = "Barber";
            // 
            // datelbl
            // 
            datelbl.AutoSize = true;
            datelbl.Location = new Point(698, 52);
            datelbl.Name = "datelbl";
            datelbl.Size = new Size(73, 25);
            datelbl.TabIndex = 15;
            datelbl.Text = "Booked";
            datelbl.Click += datelbl_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 184);
            label2.Name = "label2";
            label2.Size = new Size(136, 25);
            label2.TabIndex = 16;
            label2.Text = "Select Hair style";
            // 
            // hairCutComboBox
            // 
            hairCutComboBox.FormattingEnabled = true;
            hairCutComboBox.Location = new Point(6, 212);
            hairCutComboBox.Name = "hairCutComboBox";
            hairCutComboBox.Size = new Size(180, 33);
            hairCutComboBox.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(582, 52);
            label1.Name = "label1";
            label1.Size = new Size(76, 25);
            label1.TabIndex = 18;
            label1.Text = "Hair Cut";
            label1.Click += label1_Click;
            // 
            // timelbl
            // 
            timelbl.AutoSize = true;
            timelbl.Location = new Point(6, 257);
            timelbl.Name = "timelbl";
            timelbl.Size = new Size(101, 25);
            timelbl.TabIndex = 19;
            timelbl.Text = "Select Time";
            // 
            // timeComboBox
            // 
            timeComboBox.FormattingEnabled = true;
            timeComboBox.Location = new Point(6, 285);
            timeComboBox.Name = "timeComboBox";
            timeComboBox.Size = new Size(182, 33);
            timeComboBox.TabIndex = 20;
            // 
            // timelabel
            // 
            timelabel.AutoSize = true;
            timelabel.Location = new Point(811, 52);
            timelabel.Name = "timelabel";
            timelabel.Size = new Size(50, 25);
            timelabel.TabIndex = 21;
            timelabel.Text = "Time";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(customerNameTextBox);
            groupBox1.Controls.Add(barberComboBox);
            groupBox1.Controls.Add(timeComboBox);
            groupBox1.Controls.Add(customerNamelbl);
            groupBox1.Controls.Add(timelbl);
            groupBox1.Controls.Add(SelectBarberlbl);
            groupBox1.Controls.Add(appointmentDateTimePicker);
            groupBox1.Controls.Add(hairCutComboBox);
            groupBox1.Controls.Add(selectDatelbl);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 35);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(346, 402);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Appointment";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(907, 512);
            Controls.Add(groupBox1);
            Controls.Add(timelabel);
            Controls.Add(label1);
            Controls.Add(datelbl);
            Controls.Add(barberNamelbl);
            Controls.Add(customerName);
            Controls.Add(customerInfoListBox);
            Controls.Add(DeleteButton);
            Controls.Add(UpdateButton);
            Controls.Add(BookAppointment);
            Controls.Add(AdminButton);
            Name = "MainForm";
            Text = "BarbershopBookingApp By Abshir Muhumed";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox barberComboBox;
        private TextBox customerNameTextBox;
        private Label customerNamelbl;
        private Label SelectBarberlbl;
        private DateTimePicker appointmentDateTimePicker;
        private Label selectDatelbl;
        private Button AdminButton;
        private Button BookAppointment;
        private Button UpdateButton;
        private Button DeleteButton;
        private ListBox customerInfoListBox;
        private Label customerName;
        private Label barberNamelbl;
        private Label datelbl;
        private Label label2;
        private ComboBox hairCutComboBox;
        private Label label1;
        private Label timelbl;
        private ComboBox timeComboBox;
        private Label timelabel;
        private GroupBox groupBox1;
    }
}
