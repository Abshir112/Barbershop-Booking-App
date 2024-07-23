namespace Barbershop_Booking_App
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            appointmentsListBox = new ListBox();
            barbersListBox = new ListBox();
            barberNameTextBox = new TextBox();
            barberNamelbl = new Label();
            experienceTextBox = new TextBox();
            experiencelbl = new Label();
            RefreshButton = new Button();
            DeleteBarberButton = new Button();
            UpdateBarberButton = new Button();
            AddBarberButton = new Button();
            timelabel = new Label();
            label1 = new Label();
            datelbl = new Label();
            label2 = new Label();
            customerName = new Label();
            barberlblName = new Label();
            barberexperiencelbl = new Label();
            adminPanel = new GroupBox();
            groupBox2 = new GroupBox();
            adminPanel.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // appointmentsListBox
            // 
            appointmentsListBox.FormattingEnabled = true;
            appointmentsListBox.ItemHeight = 25;
            appointmentsListBox.Location = new Point(17, 65);
            appointmentsListBox.Name = "appointmentsListBox";
            appointmentsListBox.Size = new Size(455, 254);
            appointmentsListBox.TabIndex = 0;
            // 
            // barbersListBox
            // 
            barbersListBox.FormattingEnabled = true;
            barbersListBox.ItemHeight = 25;
            barbersListBox.Location = new Point(176, 65);
            barbersListBox.Name = "barbersListBox";
            barbersListBox.Size = new Size(225, 179);
            barbersListBox.TabIndex = 1;
            barbersListBox.SelectedIndexChanged += BarbersListBox_SelectedIndexChanged;
            // 
            // barberNameTextBox
            // 
            barberNameTextBox.Location = new Point(6, 91);
            barberNameTextBox.Name = "barberNameTextBox";
            barberNameTextBox.Size = new Size(150, 31);
            barberNameTextBox.TabIndex = 2;
            // 
            // barberNamelbl
            // 
            barberNamelbl.AutoSize = true;
            barberNamelbl.Location = new Point(6, 46);
            barberNamelbl.Name = "barberNamelbl";
            barberNamelbl.Size = new Size(115, 25);
            barberNamelbl.TabIndex = 3;
            barberNamelbl.Text = "Barber Name";
            // 
            // experienceTextBox
            // 
            experienceTextBox.Location = new Point(6, 191);
            experienceTextBox.Name = "experienceTextBox";
            experienceTextBox.Size = new Size(150, 31);
            experienceTextBox.TabIndex = 4;
            // 
            // experiencelbl
            // 
            experiencelbl.AutoSize = true;
            experiencelbl.Location = new Point(6, 146);
            experiencelbl.Name = "experiencelbl";
            experiencelbl.Size = new Size(151, 25);
            experiencelbl.TabIndex = 5;
            experiencelbl.Text = "Experience (years)";
            // 
            // RefreshButton
            // 
            RefreshButton.Location = new Point(800, 12);
            RefreshButton.Name = "RefreshButton";
            RefreshButton.Size = new Size(112, 34);
            RefreshButton.TabIndex = 6;
            RefreshButton.Text = "refresh";
            RefreshButton.UseVisualStyleBackColor = true;
            RefreshButton.Click += RefreshButton_Click;
            // 
            // DeleteBarberButton
            // 
            DeleteBarberButton.Location = new Point(274, 309);
            DeleteBarberButton.Name = "DeleteBarberButton";
            DeleteBarberButton.Size = new Size(112, 34);
            DeleteBarberButton.TabIndex = 7;
            DeleteBarberButton.Text = "Delete";
            DeleteBarberButton.UseVisualStyleBackColor = true;
            DeleteBarberButton.Click += DeleteBarberButton_Click;
            // 
            // UpdateBarberButton
            // 
            UpdateBarberButton.Location = new Point(145, 309);
            UpdateBarberButton.Name = "UpdateBarberButton";
            UpdateBarberButton.Size = new Size(112, 34);
            UpdateBarberButton.TabIndex = 8;
            UpdateBarberButton.Text = "Edit";
            UpdateBarberButton.UseVisualStyleBackColor = true;
            UpdateBarberButton.Click += UpdateBarberButton_Click;
            // 
            // AddBarberButton
            // 
            AddBarberButton.Location = new Point(14, 309);
            AddBarberButton.Name = "AddBarberButton";
            AddBarberButton.Size = new Size(112, 34);
            AddBarberButton.TabIndex = 9;
            AddBarberButton.Text = "Add";
            AddBarberButton.UseVisualStyleBackColor = true;
            AddBarberButton.Click += AddBarberButton_Click;
            // 
            // timelabel
            // 
            timelabel.AutoSize = true;
            timelabel.Location = new Point(399, 29);
            timelabel.Name = "timelabel";
            timelabel.Size = new Size(50, 25);
            timelabel.TabIndex = 26;
            timelabel.Text = "Time";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(199, 29);
            label1.Name = "label1";
            label1.Size = new Size(76, 25);
            label1.TabIndex = 25;
            label1.Text = "Hair Cut";
            // 
            // datelbl
            // 
            datelbl.AutoSize = true;
            datelbl.Location = new Point(297, 29);
            datelbl.Name = "datelbl";
            datelbl.Size = new Size(73, 25);
            datelbl.TabIndex = 24;
            datelbl.Text = "Booked";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(110, 29);
            label2.Name = "label2";
            label2.Size = new Size(63, 25);
            label2.TabIndex = 23;
            label2.Text = "Barber";
            // 
            // customerName
            // 
            customerName.AutoSize = true;
            customerName.Location = new Point(17, 29);
            customerName.Name = "customerName";
            customerName.Size = new Size(59, 25);
            customerName.TabIndex = 22;
            customerName.Text = "Name";
            // 
            // barberlblName
            // 
            barberlblName.AutoSize = true;
            barberlblName.Location = new Point(176, 29);
            barberlblName.Name = "barberlblName";
            barberlblName.Size = new Size(59, 25);
            barberlblName.TabIndex = 27;
            barberlblName.Text = "Name";
            // 
            // barberexperiencelbl
            // 
            barberexperiencelbl.AutoSize = true;
            barberexperiencelbl.Location = new Point(306, 29);
            barberexperiencelbl.Name = "barberexperiencelbl";
            barberexperiencelbl.Size = new Size(95, 25);
            barberexperiencelbl.TabIndex = 28;
            barberexperiencelbl.Text = "Experience";
            // 
            // adminPanel
            // 
            adminPanel.Controls.Add(experiencelbl);
            adminPanel.Controls.Add(barberexperiencelbl);
            adminPanel.Controls.Add(barbersListBox);
            adminPanel.Controls.Add(barberlblName);
            adminPanel.Controls.Add(barberNameTextBox);
            adminPanel.Controls.Add(barberNamelbl);
            adminPanel.Controls.Add(experienceTextBox);
            adminPanel.Controls.Add(DeleteBarberButton);
            adminPanel.Controls.Add(UpdateBarberButton);
            adminPanel.Controls.Add(AddBarberButton);
            adminPanel.Location = new Point(12, 70);
            adminPanel.Name = "adminPanel";
            adminPanel.Size = new Size(422, 357);
            adminPanel.TabIndex = 29;
            adminPanel.TabStop = false;
            adminPanel.Text = "Admin Panel";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(appointmentsListBox);
            groupBox2.Controls.Add(timelabel);
            groupBox2.Controls.Add(customerName);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(datelbl);
            groupBox2.Location = new Point(440, 70);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(484, 357);
            groupBox2.TabIndex = 30;
            groupBox2.TabStop = false;
            groupBox2.Text = "Booked Appointments";
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(936, 473);
            Controls.Add(groupBox2);
            Controls.Add(adminPanel);
            Controls.Add(RefreshButton);
            Name = "AdminForm";
            Text = "Administration Panel";
            Load += AdminForm_Load;
            adminPanel.ResumeLayout(false);
            adminPanel.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox appointmentsListBox;
        private ListBox barbersListBox;
        private TextBox barberNameTextBox;
        private Label barberNamelbl;
        private TextBox experienceTextBox;
        private Label experiencelbl;
        private Button RefreshButton;
        private Button DeleteBarberButton;
        private Button UpdateBarberButton;
        private Button AddBarberButton;
        private Label timelabel;
        private Label label1;
        private Label datelbl;
        private Label label2;
        private Label customerName;
        private Label barberlblName;
        private Label barberexperiencelbl;
        private GroupBox adminPanel;
        private GroupBox groupBox2;
    }
}