using Repository.Repositories;
using Salon.Bussiness;
using Salon.Bussiness.Interfaces;
using Salon.Bussiness.Services;
using Salon.Presentation;
using Salon.Repository.Interfaces;
using Salon.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salon
{
    class Program
    {
        static void Main(string[] args)
        {
            Type obj = Type.GetType(ConfigurationManager.AppSettings["AppointmentRepository"]);
            ConstructorInfo constructor = obj.GetConstructor(new Type[] { });
            IAppointmentRepository appointmentRepository = (IAppointmentRepository)constructor.Invoke(null);

            obj = Type.GetType(ConfigurationManager.AppSettings["ServiceRepository"]);
            constructor = obj.GetConstructor(new Type[] { });
            IServicesRepository servicesRepository = ServiceRepository.getInstance();

            obj = Type.GetType(ConfigurationManager.AppSettings["UserRepository"]);
            constructor = obj.GetConstructor(new Type[] { });
            IUserRepository userRepository = UserRepository.getInstance();

            //IAppointmentRepository appointmentRepository = AppointmentRepository.getInstance();
            //IServicesRepository servicesRepository = ServiceRepository.getInstance();
            //IUserRepository userRepository = UserRepository.getInstance();

            IAppointmentService appointmentService = new AppointmentService(appointmentRepository);
            IServicesService servicesService = new ServicesService(servicesRepository);
            IUserService userService = new UserService(userRepository);

            //Console.WriteLine(getMd5Hash("admin"));
            //ServiceRepository.test();
            Application.EnableVisualStyles();
            Application.Run(new LoginForm(appointmentService, servicesService, userService));
        }

        private static string getMd5Hash(string input)
        {
            // Create a new instance of the MD5CryptoServiceProvider object. 
            MD5 md5Hasher = MD5.Create();

            // Convert the input string to a byte array and compute the hash. 
            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes 
            // and create a string. 
            StringBuilder sBuilder = new StringBuilder();
            // Loop through each byte of the hashed data  
            // and format each one as a hexadecimal string. 
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            // Return the hexadecimal string. 
            return sBuilder.ToString();
        }
    }
}
