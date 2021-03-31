using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Utility
{
    public static class AppointmentUtility
    {
        public static float GetTotalPrice(List<Service> services)
        {
            float total = 0.0f;
            foreach(Service service in services)
            {
                total += service.GetPrice();
            }

            return total;
        }
    }
}
