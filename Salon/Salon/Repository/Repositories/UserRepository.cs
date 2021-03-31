using Models;
using Salon.Repository.Interfaces;
using System;
using System.Data.SqlClient;

namespace Repository.Repositories
{
    public class UserRepository : IUserRepository
    {
        private static UserRepository _userRepository = null;
        private String _connectionString = @"Data Source=DESKTOP-3JDNQI0\SQLEXPRESS;Initial Catalog=salon;Integrated Security=True";
        SqlConnection _conn = null;

        public UserRepository()
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

        public static UserRepository getInstance()
        {
            if (_userRepository == null)
            {
                _userRepository = new UserRepository();
            }
            return _userRepository;
        }

        public User GetUser(String username, String password)
        {
            if (_conn.State == System.Data.ConnectionState.Open)
                _conn.Close();

            User u = null;
            String sql = "SELECT * FROM userTable WHERE username='" + username + "' AND password='" + password + "';";
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand(sql, _conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                    u = new User(Int32.Parse(reader["Id"].ToString()), reader["Name"].ToString(), reader["Username"].ToString(), reader["Password"].ToString(), reader["Role"].ToString());
                _conn.Close();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            return u;
        }

        public Boolean AddUser(User newUser)
        {
            if (_conn.State == System.Data.ConnectionState.Open)
                _conn.Close();
            String sql = "INSERT INTO userTable(Name,Username,Password,Role) VALUES('" + newUser.GetName() + "','" + newUser.GetUsername() + "','"
                + newUser.GetPassword() + "','" + newUser.GetRole() + "');";
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
    }
}
