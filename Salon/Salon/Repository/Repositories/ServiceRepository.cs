using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Salon.Repository.Interfaces;

namespace Salon.Repository.Repositories
{
    public class ServiceRepository : IServicesRepository
    {
        private static ServiceRepository _serviceRepository = null;
        private String _connectionString = @"Data Source=DESKTOP-3JDNQI0\SQLEXPRESS;Initial Catalog=salon;Integrated Security=True";
        SqlConnection _conn = null;

        public ServiceRepository()
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

        public static ServiceRepository getInstance()
        {
            if (_serviceRepository == null)
            {
                _serviceRepository = new ServiceRepository();
            }
            return _serviceRepository;
        }

        public bool AddService(Service newService)
        {
            if (_conn.State == System.Data.ConnectionState.Open)
                _conn.Close();
            String sql = "INSERT INTO serviceTable(Name,Price) VALUES('" + newService.GetName() + "','" + newService.GetPrice() + "');";
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand(sql, _conn);
                cmd.CommandType = System.Data.CommandType.Text;
                int rowsAdded = cmd.ExecuteNonQuery();
                _conn.Close();
                if (rowsAdded > 0)
                    return true;
                else
                    return false;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

        }

        public int GetServiceIdByName(string serviceName)
        {
            if (_conn.State == System.Data.ConnectionState.Open)
                _conn.Close();
            int serviceId;
            String sql = "SELECT * FROM serviceTable WHERE Name='" + serviceName + "'";
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand(sql, _conn);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                serviceId = Int32.Parse(reader["Id"].ToString());
                _conn.Close();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
            return serviceId;
        }

        public bool RemoveService(String serviceName)
        {
            if (_conn.State == System.Data.ConnectionState.Open)
                _conn.Close();
            int serviceId = this.GetServiceIdByName(serviceName);
            if(serviceId == 0)
            {
                Console.WriteLine("No service with this name / id");
                return false;
            }

            String sql = "DELETE FROM serviceTable WHERE Id='" + serviceId + "'";
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand(sql, _conn);
                cmd.CommandType = System.Data.CommandType.Text;
                int rowsAdded = cmd.ExecuteNonQuery();
                _conn.Close();
                if (rowsAdded > 0)
                    return true;
                else
                    return false;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool UpdateService(String serviceName, Service newService)
        {
            if (_conn.State == System.Data.ConnectionState.Open)
                _conn.Close();

            int serviceId = this.GetServiceIdByName(serviceName);
            if (serviceId == 0)
            {
                Console.WriteLine("No service with this name / id");
                return false;
            }
            String sql = "UPDATE serviceTable SET Name='" + newService.GetName() +"', Price='" + newService.GetPrice() + "'"  + " WHERE Id='" + serviceId + "'";
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand(sql, _conn);
                cmd.CommandType = System.Data.CommandType.Text;
                int rowsAdded = cmd.ExecuteNonQuery();
                _conn.Close();
                if (rowsAdded > 0)
                    return true;
                else
                    return false;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

        }

        public Service ViewService(String serviceName)
        {
            if (_conn.State == System.Data.ConnectionState.Open)
                _conn.Close();

            int serviceId = this.GetServiceIdByName(serviceName);
            if (serviceId == 0)
            {
                Console.WriteLine("No service with this name / id");
                return null;
            }
            Service service = null;
            String sql = "SELECT * FROM serviceTable WHERE Id='" + serviceId + "'";
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand(sql, _conn);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                service = new Service(Int32.Parse(reader["Id"].ToString()), reader["Name"].ToString(), float.Parse(reader["Price"].ToString()));
                _conn.Close();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            return service;

        }

        public Boolean DeleteService(String serviceName)
        {
            if (_conn.State == System.Data.ConnectionState.Open)
                _conn.Close();

            int serviceId = this.GetServiceIdByName(serviceName);
            if (serviceId == 0)
            {
                Console.WriteLine("No service with this name / id");
                return false;
            }
            String sql = "DELETE FROM serviceTable WHERE Id='" + serviceId + "'";
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand(sql, _conn);
                int rowsAdded = cmd.ExecuteNonQuery();
                _conn.Close();
                if (rowsAdded > 0)
                    return true;
                else
                    return false;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public Service ViewServiceById(int serviceId)
        {
            if (_conn.State == System.Data.ConnectionState.Open)
                _conn.Close();

            Service service = null;
            String sql = "SELECT * FROM serviceTable WHERE Id='" + serviceId + "'";
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand(sql, _conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    service = new Service(Int32.Parse(reader["Id"].ToString()), reader["Name"].ToString(), float.Parse(reader["Price"].ToString()));

                }
                _conn.Close();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            return service;

        }

        public List<Service> ViewAllServices()
        {
            if (_conn.State == System.Data.ConnectionState.Open)
                _conn.Close();

            List<Service> services = new List<Service>();

            String sql = "SELECT * FROM serviceTable";
            try
            {
                SqlCommand cmd = new SqlCommand(sql, _conn);
                _conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    Service service = new Service(Int32.Parse(reader["Id"].ToString()), reader["Name"].ToString(), float.Parse(reader["Price"].ToString()));
                    services.Add(service);
                }
                _conn.Close();
                return services;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }


        public static void test()
        {
            ServiceRepository serviceRepository = ServiceRepository.getInstance();
            //serviceRepository.AddService(new Service(5, "Masaj", 12.5f));
            //serviceRepository.RemoveService("Masaj");
            //serviceRepository.UpdateService("Masaj", new Service(5, "MMMMasaj", 13.5f));
            //Service service = serviceRepository.ViewService("MMMMAsaj");
            //Console.WriteLine(service.GetName() + service.GetPrice().ToString());
            serviceRepository.ViewAllServices();
        }
    }
}
