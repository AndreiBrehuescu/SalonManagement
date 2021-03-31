
namespace Salon.Presentation
{
    partial class EmployeeForm
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
            this.components = new System.ComponentModel.Container();
            this.addAppointmentButton = new System.Windows.Forms.Button();
            this.viewTodayAppointmentsButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.clientAppointmentGrid = new System.Windows.Forms.DataGridView();
            this.servicesGrid = new System.Windows.Forms.DataGridView();
            this.createAppointmentButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.appointmentDateTextBox = new System.Windows.Forms.TextBox();
            this.clientNameTextBox = new System.Windows.Forms.TextBox();
            this.clientNumberTextBox = new System.Windows.Forms.TextBox();
            this.appointmentHourTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.clientAppointmentGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // addAppointmentButton
            // 
            this.addAppointmentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.addAppointmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAppointmentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.addAppointmentButton.Location = new System.Drawing.Point(12, 12);
            this.addAppointmentButton.Name = "addAppointmentButton";
            this.addAppointmentButton.Size = new System.Drawing.Size(124, 30);
            this.addAppointmentButton.TabIndex = 6;
            this.addAppointmentButton.Text = "Add Appointment";
            this.addAppointmentButton.UseVisualStyleBackColor = false;
            this.addAppointmentButton.Click += new System.EventHandler(this.addAppointmentButton_Click);
            // 
            // viewTodayAppointmentsButton
            // 
            this.viewTodayAppointmentsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.viewTodayAppointmentsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewTodayAppointmentsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.viewTodayAppointmentsButton.Location = new System.Drawing.Point(734, 12);
            this.viewTodayAppointmentsButton.Name = "viewTodayAppointmentsButton";
            this.viewTodayAppointmentsButton.Size = new System.Drawing.Size(134, 30);
            this.viewTodayAppointmentsButton.TabIndex = 7;
            this.viewTodayAppointmentsButton.Text = "Today Appointments";
            this.viewTodayAppointmentsButton.UseVisualStyleBackColor = false;
            this.viewTodayAppointmentsButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.backButton.Location = new System.Drawing.Point(781, 489);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(87, 21);
            this.backButton.TabIndex = 8;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // clientAppointmentGrid
            // 
            this.clientAppointmentGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.clientAppointmentGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clientAppointmentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientAppointmentGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.clientAppointmentGrid.Location = new System.Drawing.Point(12, 116);
            this.clientAppointmentGrid.Name = "clientAppointmentGrid";
            this.clientAppointmentGrid.Size = new System.Drawing.Size(526, 259);
            this.clientAppointmentGrid.TabIndex = 24;
            // 
            // servicesGrid
            // 
            this.servicesGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.servicesGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.servicesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.servicesGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.servicesGrid.Location = new System.Drawing.Point(12, 116);
            this.servicesGrid.Name = "servicesGrid";
            this.servicesGrid.Size = new System.Drawing.Size(526, 259);
            this.servicesGrid.TabIndex = 25;
            // 
            // createAppointmentButton
            // 
            this.createAppointmentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.createAppointmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createAppointmentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.createAppointmentButton.Location = new System.Drawing.Point(734, 376);
            this.createAppointmentButton.Name = "createAppointmentButton";
            this.createAppointmentButton.Size = new System.Drawing.Size(124, 30);
            this.createAppointmentButton.TabIndex = 26;
            this.createAppointmentButton.Text = "Create Appointment";
            this.createAppointmentButton.UseVisualStyleBackColor = false;
            this.createAppointmentButton.Click += new System.EventHandler(this.createAppointmentButton_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // appointmentDateTextBox
            // 
            this.appointmentDateTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.appointmentDateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.appointmentDateTextBox.ForeColor = System.Drawing.Color.White;
            this.appointmentDateTextBox.Location = new System.Drawing.Point(641, 140);
            this.appointmentDateTextBox.Name = "appointmentDateTextBox";
            this.appointmentDateTextBox.Size = new System.Drawing.Size(227, 13);
            this.appointmentDateTextBox.TabIndex = 30;
            this.appointmentDateTextBox.Text = "Appointment Date";
            // 
            // clientNameTextBox
            // 
            this.clientNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.clientNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clientNameTextBox.ForeColor = System.Drawing.Color.White;
            this.clientNameTextBox.Location = new System.Drawing.Point(641, 216);
            this.clientNameTextBox.Name = "clientNameTextBox";
            this.clientNameTextBox.Size = new System.Drawing.Size(227, 13);
            this.clientNameTextBox.TabIndex = 31;
            this.clientNameTextBox.Text = "Client Name";
            this.clientNameTextBox.TextChanged += new System.EventHandler(this.clientNameTextBox_TextChanged);
            // 
            // clientNumberTextBox
            // 
            this.clientNumberTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.clientNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clientNumberTextBox.ForeColor = System.Drawing.Color.White;
            this.clientNumberTextBox.Location = new System.Drawing.Point(641, 253);
            this.clientNumberTextBox.Name = "clientNumberTextBox";
            this.clientNumberTextBox.Size = new System.Drawing.Size(227, 13);
            this.clientNumberTextBox.TabIndex = 32;
            this.clientNumberTextBox.Text = "Client Number";
            // 
            // appointmentHourTextBox
            // 
            this.appointmentHourTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.appointmentHourTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.appointmentHourTextBox.ForeColor = System.Drawing.Color.White;
            this.appointmentHourTextBox.Location = new System.Drawing.Point(641, 175);
            this.appointmentHourTextBox.Name = "appointmentHourTextBox";
            this.appointmentHourTextBox.Size = new System.Drawing.Size(227, 13);
            this.appointmentHourTextBox.TabIndex = 34;
            this.appointmentHourTextBox.Text = "Appointment Hour";
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(880, 522);
            this.Controls.Add(this.appointmentHourTextBox);
            this.Controls.Add(this.clientNumberTextBox);
            this.Controls.Add(this.clientNameTextBox);
            this.Controls.Add(this.appointmentDateTextBox);
            this.Controls.Add(this.createAppointmentButton);
            this.Controls.Add(this.servicesGrid);
            this.Controls.Add(this.clientAppointmentGrid);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.viewTodayAppointmentsButton);
            this.Controls.Add(this.addAppointmentButton);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientAppointmentGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addAppointmentButton;
        private System.Windows.Forms.Button viewTodayAppointmentsButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DataGridView clientAppointmentGrid;
        private System.Windows.Forms.DataGridView servicesGrid;
        private System.Windows.Forms.Button createAppointmentButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox appointmentDateTextBox;
        private System.Windows.Forms.TextBox clientNameTextBox;
        private System.Windows.Forms.TextBox clientNumberTextBox;
        private System.Windows.Forms.TextBox appointmentHourTextBox;
    }
}