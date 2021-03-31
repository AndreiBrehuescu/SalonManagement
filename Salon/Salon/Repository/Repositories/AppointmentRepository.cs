using Models;
using Salon.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Repository.Repositories
{
    public class AppointmentRepository : IAppointmentRepository
    {
        private static AppointmentRepository _appointmentRepository = null;
        private String _connectionString = @"Data Source=DESKTOP-3JDNQI0\SQLEXPRESS;Initial Catalog=salon;Integrated Security=True";
        SqlConnection _conn = null;


        public AppointmentRepository()
        {
            try
            {
                _conn = new SqlConnection(_connectionString);
            }

            catch (SqlException)
            {
                Console.WriteLine("Failed to connect to the database");
                _conn = null;
            }
        }
        public static AppointmentRepository getInstance()
        {
            if (_appointmentRepository == null)
            {
                _appointmentRepository = new AppointmentRepository();
            }
            return _appointmentRepository;
        }

        public bool AddAppointment(Appointment newAppointment)
        {
            if (_conn.State == System.Data.ConnectionState.Open)
                _conn.Close();

            try
            { 
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandText = "INSERT INTO appointmentTable(DateTime,ClientName,ClientNumber,TotalPrice) VALUES( @datee, @clientName ,@clientNumber, @totalPrice);" + "SELECT CAST(scope_identity() AS int)";
                cmd.Parameters.AddWithValue("@datee", newAppointment.GetDateTime().ToString("yyyy-MM-dd HH:mm:ss"));
                cmd.Parameters.AddWithValue("@clientName", newAppointment.GetClientName());
                cmd.Parameters.AddWithValue("@clientNumber", newAppointment.GetClientNumber());
                cmd.Parameters.AddWithValue("@totalPrice", newAppointment.GetTotalPrice());

                _conn.Open();
                int idAdded = Convert.ToInt32(cmd.ExecuteScalar());
                newAppointment.SetId(idAdded);
                AppointmentServiceRepository.getInstance().AddServicesToAppointment(newAppointment);
                _conn.Close();
                return true;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public List<Appointment> ViewAppointmentForClient(string name)
        {
            if (_conn.State == System.Data.ConnectionState.Open)
                _conn.Close();
            List<Appointment> appointments = new List<Appointment>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandText = "SELECT * FROM appointmentTable WHERE ClientName=@name;";
                cmd.Parameters.AddWithValue("@name", name);
                _conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int idAppointment = Int32.Parse(reader["Id"].ToString());

                    DateTime dateTime = Convert.ToDateTime(reader["DateTime"].ToString());

                    List<Service> services = AppointmentServiceRepository.getInstance().FindServiceForAppointment(idAppointment);
                    Appointment appointment = new Appointment(Int32.Parse(reader["Id"].ToString()), dateTime, reader["ClientName"].ToString(), reader["ClientNumber"].ToString(), services, float.Parse(reader["TotalPrice"].ToString()) );

                    appointments.Add(appointment);
                }
                
                _conn.Close();
                return appointments;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public List<Appointment> ViewAppointments()
        {
            if (_conn.State == System.Data.ConnectionState.Open)
                _conn.Close();
            //SELECT * FROM table where DATE(date)=CURDATE()
            List<Appointment> appointments = new List<Appointment>();
            try
            {
                String today = DateTime.Now.ToString("yyyy-MM-dd");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandText = "SELECT * FROM appointmentTable where CAST( GETDATE() AS Date )=CAST( appointmentTable.DateTime as DATE);";
                _conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int idAppointment = Int32.Parse(reader["Id"].ToString());

                    DateTime dateTime = Convert.ToDateTime(reader["DateTime"].ToString());

                    List<Service> services = AppointmentServiceRepository.getInstance().FindServiceForAppointment(idAppointment);
                    Appointment appointment = new Appointment(Int32.Parse(reader["Id"].ToString()), dateTime, reader["ClientName"].ToString(), reader["ClientNumber"].ToString(), services, float.Parse(reader["TotalPrice"].ToString()));

                    appointments.Add(appointment);
                }

                _conn.Close();
                return appointments;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public List<Appointment> ViewAppointmentsByDate(DateTime startingDate, DateTime endDat)
        {
            if (_conn.State == System.Data.ConnectionState.Open)
                _conn.Close();
            List<Appointment> appointments = new List<Appointment>();
            try
            {
                String first = startingDate.ToString("yyyy-MM-dd");
                String second = endDat.ToString("yyyy-MM-dd");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandText = "SELECT * FROM appointmentTable where CAST( DateTime AS Date )>='" + first + "' AND CAST( DateTime AS Date )<='" + second +"';";
                _conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int idAppointment = Int32.Parse(reader["Id"].ToString());

                    DateTime dateTime = Convert.ToDateTime(reader["DateTime"].ToString());

                    List<Service> services = AppointmentServiceRepository.getInstance().FindServiceForAppointment(idAppointment);
                    Appointment appointment = new Appointment(Int32.Parse(reader["Id"].ToString()), dateTime, reader["ClientName"].ToString(), reader["ClientNumber"].ToString(), services, float.Parse(reader["TotalPrice"].ToString()));

                    appointments.Add(appointment);
                }

                _conn.Close();
                return appointments;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public List<Appointment> ViewAppointmentsByDateAndHour(DateTime startingDate)
        {
            if (_conn.State == System.Data.ConnectionState.Open)
                _conn.Close();
            List<Appointment> appointments = new List<Appointment>();
            try
            {
                String first = startingDate.ToString("yyyy-MM-dd HH:mm:ss");
                
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandText = "SELECT * FROM appointmentTable where appointmentTable.DateTime ='" + first + "';";
                _conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int idAppointment = Int32.Parse(reader["Id"].ToString());

                    DateTime dateTime = Convert.ToDateTime(reader["DateTime"].ToString());

                    List<Service> services = AppointmentServiceRepository.getInstance().FindServiceForAppointment(idAppointment);
                    Appointment appointment = new Appointment(Int32.Parse(reader["Id"].ToString()), dateTime, reader["ClientName"].ToString(), reader["ClientNumber"].ToString(), services, float.Parse(reader["TotalPrice"].ToString()));

                    appointments.Add(appointment);
                }

                _conn.Close();
                return appointments;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public static void test()
        {
            
            List<Service> services = new List<Service>() { new Service(2, "MMMMasaj", 13.5f),
            new Service(3, "Mere", 12.5f), new Service(4, "Pere", 2.5f), new Service(6, "Alune", 2.2f)};
            DateTime dateTime = new DateTime(2011, 8, 18, 16, 32, 0);
            DateTime dateTime2 = new DateTime(2021, 3, 29, 16, 32, 0);
            Console.WriteLine(dateTime.ToString("mm/dd/yyyy hh:mm:ss"));
            Appointment appointment = new Appointment(1, dateTime, "Malin", "0743567506", services, 100.0f);
            //AppointmentRepository.getInstance().AddAppointment(appointment);
            //AppointmentRepository.getInstance().ViewAppointmentForClient("Malin");
            //AppointmentRepository.getInstance().ViewAppointments();
            AppointmentRepository.getInstance().ViewAppointmentsByDate(dateTime, dateTime2);
        }
    }
}
