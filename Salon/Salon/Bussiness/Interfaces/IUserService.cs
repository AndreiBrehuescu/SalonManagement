using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Bussiness.Interfaces
{
    public interface IUserService
    {
        User Login(String username, String password);
        void AddUser(String name, String username, String password, String role);

    }
}
