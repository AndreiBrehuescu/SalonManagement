using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Repository.Repositories
{
    public class AppointmentServiceRepository
    {
        private static AppointmentServiceRepository _appointmentServiceRepository = null;
        private String _connectionString = @"Data Source=DESKTOP-3JDNQI0\SQLEXPRESS;Initial Catalog=salon;Integrated Security=True";
        SqlConnection _conn = null;

        public AppointmentServiceRepository()
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

        public static AppointmentServiceRepository getInstance()
        {
            if (_appointmentServiceRepository == null)
            {
                _appointmentServiceRepository = new AppointmentServiceRepository();
            }
            return _appointmentServiceRepository;
        }

        public bool AddServicesToAppointment(Appointment newAppointment)
        {
            if (_conn.State == System.Data.ConnectionState.Open)
                _conn.Close();

            List<Service> services = newAppointment.GetServices();
            foreach( Service service in services)
            {
                try
                {
                    _conn.Open();
                    String sql = "INSERT INTO appointmentServiceTable(IdAppointment, IdService) VALUES ('" + newAppointment.GetId() + "','" + service.GetId() + "');";
                    SqlCommand cmd = new SqlCommand(sql, _conn);
                    cmd.CommandType = System.Data.CommandType.Text;
                    int rowsAdded = cmd.ExecuteNonQuery();
                    _conn.Close();
                }catch (SqlException e)
                {
                    Console.WriteLine(e.Message);
                    return false;
                }
            }

            return true;
        }

        public List<Service> FindServiceForAppointment(int appointmentId)
        {
            if (_conn.State == System.Data.ConnectionState.Open)
                _conn.Close();

            List<Service> services = new List<Service>();
            String sql = "SELECT * from appointmentServiceTable where IdAppointment='" + appointmentId + "';";
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand(sql, _conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    int idAppointment = Int32.Parse(reader["IdAppointment"].ToString());
                    int idService = Int32.Parse(reader["IdService"].ToString());

                    Service service =  ServiceRepository.getInstance().ViewServiceById(idService);
                    
                    services.Add(service);
                }
                return services;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

    }
}
