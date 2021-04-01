using Models;
using Salon.Bussiness.Interfaces;
using Salon.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salon.Presentation
{
    public partial class AdminForm : Form
    {
        private IAppointmentService appointmentService;
        private IServicesService servicesService;
        private IUserService userService;


        private LoginForm loginForm;
        public AdminForm(LoginForm loginForm, IAppointmentService appointmentService, IServicesService servicesService, IUserService userService)
        {
            this.appointmentService = appointmentService;
            this.servicesService = servicesService;
            this.userService = userService;

            this.loginForm = loginForm;

            InitializeComponent();
            
            HideUi();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
            loginForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HideUi();
            serviceNameTextBox.Show();
            servicePriceTextBox.Show();
            serviceListGrid.Show();
            addNewServiceButton.Show();
            serviceUpdateButton.Show();
            serviceDeleteButton.Show();


            DisplayServicesGrid();
  
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void HideUi()
        {
            nameTextBox.Hide();
            usernameTextBox.Hide();
            passwordTextBox.Hide();
            addUserButton.Hide();
            roleComboBox.Hide();

            serviceNameTextBox.Hide();
            servicePriceTextBox.Hide();
            serviceListGrid.Hide();
            addNewServiceButton.Hide();
            serviceUpdateButton.Hide();
            serviceDeleteButton.Hide();

            appointmentsDatesGrid.Hide();
            startingDateTextBox.Hide();
            endDateTextBox.Hide();
            searchBetweenButton.Hide();
            exportBetweenDatesButton.Hide();

            searchAppointmentsForClientButton.Hide();
            clientAppointmentGrid.Hide();
            clientNameTextBox.Hide();
            exportClientLogButton.Hide();

            newServiceNameTextBox.Hide();
            newServicePriceTextField.Hide();
            updateServiceDataButton.Hide();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void addUserMenuButton_Click(object sender, EventArgs e)
        {
            HideUi();
            nameTextBox.Show();
            usernameTextBox.Show();
            passwordTextBox.Show();
            addUserButton.Show();
            roleComboBox.Show();
        }

        private void appointmentDatesButton_Click(object sender, EventArgs e)
        {
            HideUi();
            appointmentsDatesGrid.Show();
            startingDateTextBox.Show();
            endDateTextBox.Show();
            searchBetweenButton.Show();
            exportBetweenDatesButton.Show();
        }

        private void clientAppointmentsButton_Click(object sender, EventArgs e)
        {
            HideUi();
            searchAppointmentsForClientButton.Show();
            clientAppointmentGrid.Show();
            clientNameTextBox.Show();
            exportClientLogButton.Show();

        }


        private void addUserButton_Click_1(object sender, EventArgs e)
        {
            String name = nameTextBox.Text;
            String username = usernameTextBox.Text;
            String password = passwordTextBox.Text;
            String role = roleComboBox.Text;

            if(name.Equals("") || username.Equals("") || password.Equals("") ||
                name.Equals("Name") || username.Equals("Username") || password.Equals("Password") ||
                role.Equals(""))
            {
                MessageBox.Show("Empty fields not allowed");
            }
            else
            {
                userService.AddUser(name, username, password, role);
                MessageBox.Show("User added!");
            }
        }

        private void searchAppointmentsForClientButton_Click(object sender, EventArgs e)
        {
            String clientName = clientNameTextBox.Text;
            if (clientName.Equals("Client Name") || clientName.Equals(""))
            {
                MessageBox.Show("Empty fields not allowed");
                return;
            }

            List<Appointment> appointments = appointmentService.ViewAppointmentsForClient(clientName);
            
            
            serviceListGrid.Rows.Clear();
            serviceListGrid.Refresh();
            clientAppointmentGrid.ColumnCount = 5;

            clientAppointmentGrid.Location = new Point(13, 128);
            clientAppointmentGrid.Size = new Size(500, 250);
            clientAppointmentGrid.DefaultCellStyle.ForeColor = Color.Black;
            clientAppointmentGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            clientAppointmentGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            clientAppointmentGrid.CellBorderStyle = DataGridViewCellBorderStyle.None;
            clientAppointmentGrid.BorderStyle = BorderStyle.None;
            clientAppointmentGrid.GridColor = Color.FromArgb(34, 36, 49);
            clientAppointmentGrid.RowHeadersVisible = false;

            clientAppointmentGrid.Columns[0].Name = "Date";
            clientAppointmentGrid.Columns[1].Name = "Name";
            clientAppointmentGrid.Columns[2].Name = "Number";
            clientAppointmentGrid.Columns[3].Name = "Services";
            clientAppointmentGrid.Columns[4].Name = "Total";

            clientAppointmentGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            clientAppointmentGrid.MultiSelect = false;


            foreach (Appointment appointment in appointments)
            {
                string[] row = new string[5];
                row[0] = appointment.GetDateTime().ToString();
                row[1] = appointment.GetClientName();
                row[2] = appointment.GetClientNumber();

                String s = "";
                int i = 1;
                foreach (Service service in appointment.GetServices())
                {
                    if (i % 3 == 0)
                        s += service.GetName() + "\n";
                    else
                        s += service.GetName() + ", ";
                }
                s = s.Remove(s.Length - 2);
                row[3] = s;

                row[4] = appointment.GetTotalPrice().ToString();
                clientAppointmentGrid.Rows.Add(row);
            }
        }

        private void searchBetweenButton_Click(object sender, EventArgs e)
        {
            appointmentsDatesGrid.Show();
            startingDateTextBox.Show();
            endDateTextBox.Show();
            searchBetweenButton.Show();

            String starting = startingDateTextBox.Text;
            String end = endDateTextBox.Text;

            if (starting.Equals("Starting Date") || end.Equals("End Date") ||
                starting.Equals("") || end.Equals(""))
            {
                MessageBox.Show("Empty fields not allowed");
                return;
            }
            var cultureInfo = new CultureInfo("de-DE");
            DateTime dateTime1 = DateTime.Parse(starting.ToString(), cultureInfo);
            DateTime dateTime2 = DateTime.Parse(end.ToString(), cultureInfo);

            List<Appointment> appointments = appointmentService.ViewAppointmentsByDate(dateTime1, dateTime2);

            serviceListGrid.Rows.Clear();
            serviceListGrid.Refresh();
            appointmentsDatesGrid.ColumnCount = 5;

            appointmentsDatesGrid.Location = new Point(13, 128);
            appointmentsDatesGrid.Size = new Size(500, 250);
            appointmentsDatesGrid.DefaultCellStyle.ForeColor = Color.Black;
            appointmentsDatesGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            appointmentsDatesGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            appointmentsDatesGrid.CellBorderStyle = DataGridViewCellBorderStyle.None;
            appointmentsDatesGrid.BorderStyle = BorderStyle.None;
            appointmentsDatesGrid.GridColor = Color.FromArgb(34, 36, 49);
            appointmentsDatesGrid.RowHeadersVisible = false;

            appointmentsDatesGrid.Columns[0].Name = "Date";
            appointmentsDatesGrid.Columns[1].Name = "Name";
            appointmentsDatesGrid.Columns[2].Name = "Number";
            appointmentsDatesGrid.Columns[3].Name = "Services";
            appointmentsDatesGrid.Columns[4].Name = "Total";

            appointmentsDatesGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            appointmentsDatesGrid.MultiSelect = false;


            foreach (Appointment appointment in appointments)
            {
                string[] row = new string[5];
                row[0] = appointment.GetDateTime().ToString();
                row[1] = appointment.GetClientName();
                row[2] = appointment.GetClientNumber();

                String s = "";
                int i = 1;
                foreach (Service service in appointment.GetServices())
                {
                    if (i % 3 == 0)
                        s += service.GetName() + "\n";
                    else
                        s += service.GetName() + ", ";
                }
                s = s.Remove(s.Length - 2);
                row[3] = s;

                row[4] = appointment.GetTotalPrice().ToString();
                appointmentsDatesGrid.Rows.Add(row);
            }

        }

        private void serviceUpdateButton_Click(object sender, EventArgs e)
        {
            serviceListGrid.Hide();
            
            string serviceNameOriginal = serviceListGrid.SelectedCells[0].Value.ToString();
            float servicePriceOriginal = float.Parse(serviceListGrid.SelectedCells[1].Value.ToString());

            newServiceNameTextBox.Text = serviceNameOriginal;
            newServicePriceTextField.Text = servicePriceOriginal.ToString();

            newServiceNameTextBox.Show();
            newServicePriceTextField.Show();
            updateServiceDataButton.Show();

            if (serviceListGrid.SelectedCells.Count == 0)
            {
                MessageBox.Show("No service selected!");
                return;
            }
        }

        private void deleteServiceButton_Click(object sender, EventArgs e)
        {
            if(serviceListGrid.SelectedCells.Count == 0)
            {
                MessageBox.Show("No service selected!");
                return;
            }

            string serviceName = serviceListGrid.SelectedCells[0].Value.ToString();
            
            if(servicesService.DeleteService(serviceName) == false)
            {
                MessageBox.Show("Could not delete the service!");
                return;
            }

            DisplayServicesGrid();
        }

        private void DisplayServicesGrid()
        {
            List<Service> services = servicesService.ViewAllServices();

            serviceListGrid.Rows.Clear();
            serviceListGrid.Refresh();
            serviceListGrid.ColumnCount = 2;

            serviceListGrid.Location = new Point(13, 128);
            serviceListGrid.Size = new Size(500, 250);
            serviceListGrid.DefaultCellStyle.ForeColor = Color.Black;
            serviceListGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            serviceListGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            serviceListGrid.CellBorderStyle = DataGridViewCellBorderStyle.None;
            serviceListGrid.BorderStyle = BorderStyle.None;
            serviceListGrid.GridColor = Color.FromArgb(34, 36, 49);
            serviceListGrid.RowHeadersVisible = false;
            serviceListGrid.BackgroundColor = Color.FromArgb(34, 36, 49);


            serviceListGrid.Columns[0].Name = "Service Name";
            serviceListGrid.Columns[1].Name = "Price";


            serviceListGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            serviceListGrid.MultiSelect = false;

            foreach (Service service in services)
            {
                string[] row = new string[2];
                row[0] = service.GetName();
                row[1] = service.GetPrice().ToString();
                serviceListGrid.Rows.Add(row);
            }
        }

        private void updateServiceDataButton_Click(object sender, EventArgs e)
        {
            string serviceNameOriginal = serviceListGrid.SelectedCells[0].Value.ToString();
            float servicePriceOriginal = float.Parse(serviceListGrid.SelectedCells[1].Value.ToString());

            if (serviceListGrid.SelectedCells.Count == 0)
            {
                MessageBox.Show("No service selected!");
                return;
            }

            string newServiceName = newServiceNameTextBox.Text;
            string newServicePrice = newServicePriceTextField.Text;
            if (newServicePrice.Equals(""))
                newServicePrice = "0.0";


            bool succesful = servicesService.UpdateServiceByName(serviceNameOriginal, newServiceName, float.Parse(newServicePrice));
        
            if(succesful == false)
            {
                MessageBox.Show("No service updated!");
                return;
            }

            HideUi();
            serviceNameTextBox.Show();
            servicePriceTextBox.Show();
            serviceListGrid.Show();
            addNewServiceButton.Show();
            serviceUpdateButton.Show();
            serviceDeleteButton.Show();

            DisplayServicesGrid();
        }

        private void exportClientLogButton_Click(object sender, EventArgs e)
        {

        }

        private void exportBetweenDatesButton_Click(object sender, EventArgs e)
        {

        }

        private void addNewServiceButton_Click(object sender, EventArgs e)
        {
            String serviceName = serviceNameTextBox.Text;
            String servicePrice = servicePriceTextBox.Text;

            if(serviceName.Equals("Service Name") || serviceName.Equals("") || servicePrice.Equals("Service Price") || servicePrice.Equals("") )
            {
                MessageBox.Show("Fields can not be empty!");
                return;
            }

            float servicePric = float.Parse(servicePrice);

            if(servicesService.AddService(serviceName, servicePric))
            {
                MessageBox.Show("Success!");
                DisplayServicesGrid();
                return;
            }
            else
            {
                MessageBox.Show("Error adding the service!");
                return;
            }
        }
    }
}
