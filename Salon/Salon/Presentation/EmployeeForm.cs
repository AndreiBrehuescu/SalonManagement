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
using Models;
using Salon.Bussiness.Interfaces;
using Salon.Repository.Interfaces;
using Salon.Utility;

namespace Salon.Presentation
{
    public partial class EmployeeForm : Form
    {
        private IAppointmentService appointmentService;
        private IServicesService servicesService;
        private IUserService userService;

        private IAppointmentRepository appointmentRepository;
        private IServicesRepository servicesRepository;
        private IUserRepository userRepository;

        private LoginForm loginForm;

        public EmployeeForm(LoginForm loginForm, IAppointmentService appointmentService, IServicesService servicesService, IUserService userService,
            IAppointmentRepository appointmentRepository, IServicesRepository servicesRepository, IUserRepository userRepository)
        {
            this.appointmentService = appointmentService;
            this.servicesService = servicesService;
            this.userService = userService;

            this.appointmentRepository = appointmentRepository;
            this.servicesRepository = servicesRepository;
            this.userRepository = userRepository;

            this.loginForm = loginForm;

            InitializeComponent();

            HideUi();
        }

        public void HideUi()
        {
            clientAppointmentGrid.Hide();
  
            servicesGrid.Hide();
            createAppointmentButton.Hide();
            appointmentDateTextBox.Hide();
            appointmentHourTextBox.Hide();
            clientNameTextBox.Hide();
            clientNumberTextBox.Hide();

        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HideUi();


            List<Appointment> appointments = appointmentService.ViewAppointments();

            clientAppointmentGrid.Show();
            clientAppointmentGrid.Rows.Clear();
            clientAppointmentGrid.Refresh();
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
                    else if( service != null)
                        s += service.GetName() + ", ";
                }
                s = s.Remove(s.Length - 2);
                row[3] = s;

                row[4] = appointment.GetTotalPrice().ToString();
                clientAppointmentGrid.Rows.Add(row);
            }
        }

        private void addAppointmentButton_Click(object sender, EventArgs e)
        {
            HideUi();
            servicesGrid.Show();

            createAppointmentButton.Show();
            appointmentDateTextBox.Show();
            appointmentHourTextBox.Show();
            clientNameTextBox.Show();
            clientNumberTextBox.Show();

            List<Service> services = servicesService.ViewAllServices();

            servicesGrid.Rows.Clear();
            servicesGrid.Refresh();
            servicesGrid.ColumnCount = 2;

            servicesGrid.Location = new Point(13, 128);
            servicesGrid.Size = new Size(500, 250);
            servicesGrid.DefaultCellStyle.ForeColor = Color.Black;
            servicesGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            servicesGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            servicesGrid.CellBorderStyle = DataGridViewCellBorderStyle.None;
            servicesGrid.BorderStyle = BorderStyle.None;
            servicesGrid.GridColor = Color.FromArgb(34, 36, 49);
            servicesGrid.RowHeadersVisible = false;
            servicesGrid.BackgroundColor = Color.FromArgb(34, 36, 49);


            servicesGrid.Columns[0].Name = "Service Name";
            servicesGrid.Columns[1].Name = "Price";


            servicesGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            servicesGrid.MultiSelect = true;

            foreach (Service service in services)
            {
                string[] row = new string[2];
                row[0] = service.GetName();
                row[1] = service.GetPrice().ToString();
                servicesGrid.Rows.Add(row);
            }

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
            loginForm.Show();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void clientNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void createAppointmentButton_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount = servicesGrid.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if(selectedRowCount == 0)
            {
                MessageBox.Show("No services selected!");
                return;
            }


            var servicesName = servicesGrid.SelectedRows.Cast<DataGridViewRow>()
                           .Select(x => Convert.ToString(x.Cells[0].Value));

            List<Service> services = new List<Service>();
            foreach(String s in servicesName)
            {
                services.Add(servicesService.ViewServiceByName(s));
            }

            String hour = appointmentHourTextBox.Text;
            String date = appointmentDateTextBox.Text;

            String fullDate = date + " " + hour + ":00";

            var cultureInfo = new CultureInfo("de-DE");
            DateTime myDate = new DateTime();
            try
            {
                myDate = DateTime.ParseExact(fullDate, "dd/MM/yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid format, try dd/MM/yyyy and HH:mm");
                return;
                
            }
            String clientName = clientNameTextBox.Text;
            String clientNumber = clientNumberTextBox.Text;

            String conflicts = appointmentService.AddAppointment(myDate, clientName, clientNumber, services);


            if(conflicts.Length == 0)
            {
                MessageBox.Show("Appointment created!");
            }
            else
            {
                MessageBox.Show("Can not create the appointmet \n Conflicts" + conflicts);
            }

            return;

        }
    }
}
