using Models;
using Salon.Bussiness.Interfaces;
using Salon.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salon.Presentation
{
    public partial class LoginForm : Form
    {
        private IAppointmentService appointmentService;
        private IServicesService servicesService;
        private IUserService userService;

        private IAppointmentRepository appointmentRepository;
        private IServicesRepository servicesRepository;
        private IUserRepository userRepository;

        private AdminForm adminForm;
        private EmployeeForm employeeForm;
        public LoginForm()
        {
            InitializeComponent( );
        } 

        public LoginForm(IAppointmentService appointmentService, IServicesService servicesService, IUserService userService,
            IAppointmentRepository appointmentRepository, IServicesRepository servicesRepository, IUserRepository userRepository)
        {
            this.appointmentService = appointmentService;
            this.servicesService = servicesService;
            this.userService = userService;

            this.appointmentRepository = appointmentRepository;
            this.servicesRepository = servicesRepository;
            this.userRepository = userRepository;

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            User loginUser = userService.Login(usernameTextBox.Text, passwordTextBox.Text);
            if (loginUser != null)
            {
                if (loginUser.GetRole().Equals("Admin"))
                {
                    adminForm = new AdminForm(this, appointmentService, servicesService, userService,
                 appointmentRepository, servicesRepository, userRepository);
                    adminForm.Show();
                    this.Hide();
                }
                else
                {
                    employeeForm = new EmployeeForm(this, appointmentService, servicesService, userService,
                 appointmentRepository, servicesRepository, userRepository);
                    employeeForm.Show();
                    this.Hide();
                }
            }

        }
    }
}
