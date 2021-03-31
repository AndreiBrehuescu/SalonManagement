
namespace Salon.Presentation
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
            this.backButton = new System.Windows.Forms.Button();
            this.addUserMenuButton = new System.Windows.Forms.Button();
            this.serviceListButton = new System.Windows.Forms.Button();
            this.appointmentDatesButton = new System.Windows.Forms.Button();
            this.clientAppointmentsButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.addUserButton = new System.Windows.Forms.Button();
            this.serviceListGrid = new System.Windows.Forms.DataGridView();
            this.serviceNameTextBox = new System.Windows.Forms.TextBox();
            this.servicePriceTextBox = new System.Windows.Forms.TextBox();
            this.addNewServiceButton = new System.Windows.Forms.Button();
            this.appointmentsDatesGrid = new System.Windows.Forms.DataGridView();
            this.startingDateTextBox = new System.Windows.Forms.TextBox();
            this.endDateTextBox = new System.Windows.Forms.TextBox();
            this.searchBetweenButton = new System.Windows.Forms.Button();
            this.clientAppointmentGrid = new System.Windows.Forms.DataGridView();
            this.clientNameTextBox = new System.Windows.Forms.TextBox();
            this.searchAppointmentsForClientButton = new System.Windows.Forms.Button();
            this.roleComboBox = new System.Windows.Forms.ComboBox();
            this.serviceUpdateButton = new System.Windows.Forms.Button();
            this.serviceDeleteButton = new System.Windows.Forms.Button();
            this.newServiceNameTextBox = new System.Windows.Forms.TextBox();
            this.newServicePriceTextField = new System.Windows.Forms.TextBox();
            this.updateServiceDataButton = new System.Windows.Forms.Button();
            this.exportBetweenDatesButton = new System.Windows.Forms.Button();
            this.exportClientLogButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.serviceListGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsDatesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientAppointmentGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.backButton.Location = new System.Drawing.Point(781, 489);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(87, 21);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // addUserMenuButton
            // 
            this.addUserMenuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.addUserMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addUserMenuButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.addUserMenuButton.Location = new System.Drawing.Point(12, 12);
            this.addUserMenuButton.Name = "addUserMenuButton";
            this.addUserMenuButton.Size = new System.Drawing.Size(106, 30);
            this.addUserMenuButton.TabIndex = 5;
            this.addUserMenuButton.Text = "Add User";
            this.addUserMenuButton.UseVisualStyleBackColor = false;
            this.addUserMenuButton.Click += new System.EventHandler(this.addUserMenuButton_Click);
            // 
            // serviceListButton
            // 
            this.serviceListButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.serviceListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.serviceListButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.serviceListButton.Location = new System.Drawing.Point(257, 12);
            this.serviceListButton.Name = "serviceListButton";
            this.serviceListButton.Size = new System.Drawing.Size(106, 30);
            this.serviceListButton.TabIndex = 6;
            this.serviceListButton.Text = "Service List";
            this.serviceListButton.UseVisualStyleBackColor = false;
            this.serviceListButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // appointmentDatesButton
            // 
            this.appointmentDatesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.appointmentDatesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.appointmentDatesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.appointmentDatesButton.Location = new System.Drawing.Point(505, 12);
            this.appointmentDatesButton.Name = "appointmentDatesButton";
            this.appointmentDatesButton.Size = new System.Drawing.Size(106, 30);
            this.appointmentDatesButton.TabIndex = 7;
            this.appointmentDatesButton.Text = "Appointment Date";
            this.appointmentDatesButton.UseVisualStyleBackColor = false;
            this.appointmentDatesButton.Click += new System.EventHandler(this.appointmentDatesButton_Click);
            // 
            // clientAppointmentsButton
            // 
            this.clientAppointmentsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.clientAppointmentsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientAppointmentsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.clientAppointmentsButton.Location = new System.Drawing.Point(729, 13);
            this.clientAppointmentsButton.Name = "clientAppointmentsButton";
            this.clientAppointmentsButton.Size = new System.Drawing.Size(139, 30);
            this.clientAppointmentsButton.TabIndex = 8;
            this.clientAppointmentsButton.Text = "Client Appointments";
            this.clientAppointmentsButton.UseVisualStyleBackColor = false;
            this.clientAppointmentsButton.Click += new System.EventHandler(this.clientAppointmentsButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameTextBox.ForeColor = System.Drawing.Color.White;
            this.nameTextBox.Location = new System.Drawing.Point(12, 166);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(227, 13);
            this.nameTextBox.TabIndex = 11;
            this.nameTextBox.Text = "Name";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.usernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameTextBox.ForeColor = System.Drawing.Color.White;
            this.usernameTextBox.Location = new System.Drawing.Point(12, 200);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(227, 13);
            this.usernameTextBox.TabIndex = 12;
            this.usernameTextBox.Text = "Username";
            this.usernameTextBox.TextChanged += new System.EventHandler(this.usernameTextBox_TextChanged);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextBox.ForeColor = System.Drawing.Color.White;
            this.passwordTextBox.Location = new System.Drawing.Point(12, 233);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(227, 13);
            this.passwordTextBox.TabIndex = 13;
            this.passwordTextBox.Text = "Password";
            this.passwordTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // addUserButton
            // 
            this.addUserButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.addUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addUserButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.addUserButton.Location = new System.Drawing.Point(12, 310);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(106, 30);
            this.addUserButton.TabIndex = 14;
            this.addUserButton.Text = "Create User";
            this.addUserButton.UseVisualStyleBackColor = false;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click_1);
            // 
            // serviceListGrid
            // 
            this.serviceListGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.serviceListGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.serviceListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.serviceListGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.serviceListGrid.Location = new System.Drawing.Point(13, 128);
            this.serviceListGrid.Name = "serviceListGrid";
            this.serviceListGrid.Size = new System.Drawing.Size(526, 259);
            this.serviceListGrid.TabIndex = 15;
            // 
            // serviceNameTextBox
            // 
            this.serviceNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.serviceNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.serviceNameTextBox.ForeColor = System.Drawing.Color.White;
            this.serviceNameTextBox.Location = new System.Drawing.Point(641, 128);
            this.serviceNameTextBox.Name = "serviceNameTextBox";
            this.serviceNameTextBox.Size = new System.Drawing.Size(227, 13);
            this.serviceNameTextBox.TabIndex = 16;
            this.serviceNameTextBox.Text = "Service Name";
            this.serviceNameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // servicePriceTextBox
            // 
            this.servicePriceTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.servicePriceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.servicePriceTextBox.ForeColor = System.Drawing.Color.White;
            this.servicePriceTextBox.Location = new System.Drawing.Point(641, 166);
            this.servicePriceTextBox.Name = "servicePriceTextBox";
            this.servicePriceTextBox.Size = new System.Drawing.Size(227, 13);
            this.servicePriceTextBox.TabIndex = 17;
            this.servicePriceTextBox.Text = "Service Price";
            // 
            // addNewServiceButton
            // 
            this.addNewServiceButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.addNewServiceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewServiceButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.addNewServiceButton.Location = new System.Drawing.Point(762, 216);
            this.addNewServiceButton.Name = "addNewServiceButton";
            this.addNewServiceButton.Size = new System.Drawing.Size(106, 30);
            this.addNewServiceButton.TabIndex = 18;
            this.addNewServiceButton.Text = "Add Service";
            this.addNewServiceButton.UseVisualStyleBackColor = false;
            this.addNewServiceButton.Click += new System.EventHandler(this.addNewServiceButton_Click);
            // 
            // appointmentsDatesGrid
            // 
            this.appointmentsDatesGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.appointmentsDatesGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.appointmentsDatesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentsDatesGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.appointmentsDatesGrid.Location = new System.Drawing.Point(12, 128);
            this.appointmentsDatesGrid.Name = "appointmentsDatesGrid";
            this.appointmentsDatesGrid.Size = new System.Drawing.Size(526, 259);
            this.appointmentsDatesGrid.TabIndex = 19;
            // 
            // startingDateTextBox
            // 
            this.startingDateTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.startingDateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.startingDateTextBox.ForeColor = System.Drawing.Color.White;
            this.startingDateTextBox.Location = new System.Drawing.Point(641, 128);
            this.startingDateTextBox.Name = "startingDateTextBox";
            this.startingDateTextBox.Size = new System.Drawing.Size(227, 13);
            this.startingDateTextBox.TabIndex = 20;
            this.startingDateTextBox.Text = "Starting Date";
            // 
            // endDateTextBox
            // 
            this.endDateTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.endDateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.endDateTextBox.ForeColor = System.Drawing.Color.White;
            this.endDateTextBox.Location = new System.Drawing.Point(641, 166);
            this.endDateTextBox.Name = "endDateTextBox";
            this.endDateTextBox.Size = new System.Drawing.Size(227, 13);
            this.endDateTextBox.TabIndex = 21;
            this.endDateTextBox.Text = "End Date";
            // 
            // searchBetweenButton
            // 
            this.searchBetweenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.searchBetweenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBetweenButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.searchBetweenButton.Location = new System.Drawing.Point(729, 216);
            this.searchBetweenButton.Name = "searchBetweenButton";
            this.searchBetweenButton.Size = new System.Drawing.Size(139, 30);
            this.searchBetweenButton.TabIndex = 22;
            this.searchBetweenButton.Text = "Search Appointments";
            this.searchBetweenButton.UseVisualStyleBackColor = false;
            this.searchBetweenButton.Click += new System.EventHandler(this.searchBetweenButton_Click);
            // 
            // clientAppointmentGrid
            // 
            this.clientAppointmentGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.clientAppointmentGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clientAppointmentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientAppointmentGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.clientAppointmentGrid.Location = new System.Drawing.Point(12, 128);
            this.clientAppointmentGrid.Name = "clientAppointmentGrid";
            this.clientAppointmentGrid.Size = new System.Drawing.Size(526, 259);
            this.clientAppointmentGrid.TabIndex = 23;
            // 
            // clientNameTextBox
            // 
            this.clientNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.clientNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clientNameTextBox.ForeColor = System.Drawing.Color.White;
            this.clientNameTextBox.Location = new System.Drawing.Point(641, 166);
            this.clientNameTextBox.Name = "clientNameTextBox";
            this.clientNameTextBox.Size = new System.Drawing.Size(227, 13);
            this.clientNameTextBox.TabIndex = 24;
            this.clientNameTextBox.Text = "Client Name";
            // 
            // searchAppointmentsForClientButton
            // 
            this.searchAppointmentsForClientButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.searchAppointmentsForClientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchAppointmentsForClientButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.searchAppointmentsForClientButton.Location = new System.Drawing.Point(729, 216);
            this.searchAppointmentsForClientButton.Name = "searchAppointmentsForClientButton";
            this.searchAppointmentsForClientButton.Size = new System.Drawing.Size(139, 30);
            this.searchAppointmentsForClientButton.TabIndex = 25;
            this.searchAppointmentsForClientButton.Text = "Search Appointments";
            this.searchAppointmentsForClientButton.UseVisualStyleBackColor = false;
            this.searchAppointmentsForClientButton.Click += new System.EventHandler(this.searchAppointmentsForClientButton_Click);
            // 
            // roleComboBox
            // 
            this.roleComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.roleComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roleComboBox.ForeColor = System.Drawing.Color.White;
            this.roleComboBox.FormattingEnabled = true;
            this.roleComboBox.Items.AddRange(new object[] {
            "Admin",
            "Employee"});
            this.roleComboBox.Location = new System.Drawing.Point(13, 263);
            this.roleComboBox.Name = "roleComboBox";
            this.roleComboBox.Size = new System.Drawing.Size(90, 21);
            this.roleComboBox.Sorted = true;
            this.roleComboBox.TabIndex = 26;
            // 
            // serviceUpdateButton
            // 
            this.serviceUpdateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.serviceUpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.serviceUpdateButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.serviceUpdateButton.Location = new System.Drawing.Point(12, 454);
            this.serviceUpdateButton.Name = "serviceUpdateButton";
            this.serviceUpdateButton.Size = new System.Drawing.Size(106, 30);
            this.serviceUpdateButton.TabIndex = 27;
            this.serviceUpdateButton.Text = "Update Service";
            this.serviceUpdateButton.UseVisualStyleBackColor = false;
            this.serviceUpdateButton.Click += new System.EventHandler(this.serviceUpdateButton_Click);
            // 
            // serviceDeleteButton
            // 
            this.serviceDeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.serviceDeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.serviceDeleteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.serviceDeleteButton.Location = new System.Drawing.Point(257, 454);
            this.serviceDeleteButton.Name = "serviceDeleteButton";
            this.serviceDeleteButton.Size = new System.Drawing.Size(106, 30);
            this.serviceDeleteButton.TabIndex = 28;
            this.serviceDeleteButton.Text = "Delete";
            this.serviceDeleteButton.UseVisualStyleBackColor = false;
            this.serviceDeleteButton.Click += new System.EventHandler(this.deleteServiceButton_Click);
            // 
            // newServiceNameTextBox
            // 
            this.newServiceNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.newServiceNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newServiceNameTextBox.ForeColor = System.Drawing.Color.White;
            this.newServiceNameTextBox.Location = new System.Drawing.Point(119, 147);
            this.newServiceNameTextBox.Name = "newServiceNameTextBox";
            this.newServiceNameTextBox.Size = new System.Drawing.Size(227, 13);
            this.newServiceNameTextBox.TabIndex = 29;
            this.newServiceNameTextBox.Text = "Starting Date";
            // 
            // newServicePriceTextField
            // 
            this.newServicePriceTextField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.newServicePriceTextField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newServicePriceTextField.ForeColor = System.Drawing.Color.White;
            this.newServicePriceTextField.Location = new System.Drawing.Point(119, 185);
            this.newServicePriceTextField.Name = "newServicePriceTextField";
            this.newServicePriceTextField.Size = new System.Drawing.Size(227, 13);
            this.newServicePriceTextField.TabIndex = 30;
            this.newServicePriceTextField.Text = "Starting Date";
            // 
            // updateServiceDataButton
            // 
            this.updateServiceDataButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.updateServiceDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateServiceDataButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.updateServiceDataButton.Location = new System.Drawing.Point(352, 157);
            this.updateServiceDataButton.Name = "updateServiceDataButton";
            this.updateServiceDataButton.Size = new System.Drawing.Size(106, 30);
            this.updateServiceDataButton.TabIndex = 31;
            this.updateServiceDataButton.Text = "Update";
            this.updateServiceDataButton.UseVisualStyleBackColor = false;
            this.updateServiceDataButton.Click += new System.EventHandler(this.updateServiceDataButton_Click);
            // 
            // exportBetweenDatesButton
            // 
            this.exportBetweenDatesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.exportBetweenDatesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportBetweenDatesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.exportBetweenDatesButton.Location = new System.Drawing.Point(257, 454);
            this.exportBetweenDatesButton.Name = "exportBetweenDatesButton";
            this.exportBetweenDatesButton.Size = new System.Drawing.Size(106, 30);
            this.exportBetweenDatesButton.TabIndex = 32;
            this.exportBetweenDatesButton.Text = "Export Log";
            this.exportBetweenDatesButton.UseVisualStyleBackColor = false;
            this.exportBetweenDatesButton.Click += new System.EventHandler(this.exportBetweenDatesButton_Click);
            // 
            // exportClientLogButton
            // 
            this.exportClientLogButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.exportClientLogButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportClientLogButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.exportClientLogButton.Location = new System.Drawing.Point(257, 454);
            this.exportClientLogButton.Name = "exportClientLogButton";
            this.exportClientLogButton.Size = new System.Drawing.Size(106, 30);
            this.exportClientLogButton.TabIndex = 33;
            this.exportClientLogButton.Text = "Export Log";
            this.exportClientLogButton.UseVisualStyleBackColor = false;
            this.exportClientLogButton.Click += new System.EventHandler(this.exportClientLogButton_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(880, 522);
            this.Controls.Add(this.exportClientLogButton);
            this.Controls.Add(this.exportBetweenDatesButton);
            this.Controls.Add(this.updateServiceDataButton);
            this.Controls.Add(this.newServicePriceTextField);
            this.Controls.Add(this.newServiceNameTextBox);
            this.Controls.Add(this.serviceDeleteButton);
            this.Controls.Add(this.serviceUpdateButton);
            this.Controls.Add(this.roleComboBox);
            this.Controls.Add(this.searchAppointmentsForClientButton);
            this.Controls.Add(this.clientNameTextBox);
            this.Controls.Add(this.clientAppointmentGrid);
            this.Controls.Add(this.searchBetweenButton);
            this.Controls.Add(this.endDateTextBox);
            this.Controls.Add(this.startingDateTextBox);
            this.Controls.Add(this.appointmentsDatesGrid);
            this.Controls.Add(this.addNewServiceButton);
            this.Controls.Add(this.servicePriceTextBox);
            this.Controls.Add(this.serviceNameTextBox);
            this.Controls.Add(this.serviceListGrid);
            this.Controls.Add(this.addUserButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.clientAppointmentsButton);
            this.Controls.Add(this.appointmentDatesButton);
            this.Controls.Add(this.serviceListButton);
            this.Controls.Add(this.addUserMenuButton);
            this.Controls.Add(this.backButton);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.serviceListGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsDatesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientAppointmentGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button addUserMenuButton;
        private System.Windows.Forms.Button serviceListButton;
        private System.Windows.Forms.Button appointmentDatesButton;
        private System.Windows.Forms.Button clientAppointmentsButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.DataGridView serviceListGrid;
        private System.Windows.Forms.TextBox serviceNameTextBox;
        private System.Windows.Forms.TextBox servicePriceTextBox;
        private System.Windows.Forms.Button addNewServiceButton;
        private System.Windows.Forms.DataGridView appointmentsDatesGrid;
        private System.Windows.Forms.TextBox startingDateTextBox;
        private System.Windows.Forms.TextBox endDateTextBox;
        private System.Windows.Forms.Button searchBetweenButton;
        private System.Windows.Forms.DataGridView clientAppointmentGrid;
        private System.Windows.Forms.TextBox clientNameTextBox;
        private System.Windows.Forms.Button searchAppointmentsForClientButton;
        private System.Windows.Forms.ComboBox roleComboBox;
        private System.Windows.Forms.Button serviceUpdateButton;
        private System.Windows.Forms.Button serviceDeleteButton;
        private System.Windows.Forms.TextBox newServiceNameTextBox;
        private System.Windows.Forms.TextBox newServicePriceTextField;
        private System.Windows.Forms.Button updateServiceDataButton;
        private System.Windows.Forms.Button exportBetweenDatesButton;
        private System.Windows.Forms.Button exportClientLogButton;
    }
}