using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Salon.Repository.Interfaces
{
    public interface IUserRepository
    {
        User GetUser(String username, String password);
        Boolean AddUser(User newUser);
    }
}
