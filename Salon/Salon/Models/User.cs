using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class User
    {
        private int Id;
        private string Name;
        private string Username;
        private string Password;
        private string Role;

        public User()
        {

        }

        public User(int id,String name, String username, String password, String role)
        {
            this.Id = id;
            this.Name = name;
            this.Username = username;
            this.Password = password;
            this.Role = role;
        }

        public int GetId()
        {
            return this.Id;
        }

        public string GetUsername()
        {
            return this.Username;
        }

        public string GetPassword()
        {
            return this.Password;
        }

        public string GetRole()
        {
            return this.Role;
        }

        public string GetName()
        {
            return this.Name;
        }

        public void SetName(String name)
        {
            this.Name = name;
        }
    }
}
