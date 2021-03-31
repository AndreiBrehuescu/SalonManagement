using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Bussiness.Interfaces
{
    public interface IServicesService
    {
        Boolean RemoveServiceByName(String serviceName);
        Boolean AddService(String name, float price);
        Boolean UpdateServiceByName(String serviceName, String newServiceName, float newServicePrice);
        Service ViewServiceByName(String serviceName);
        List<Service> ViewAllServices();
        Boolean DeleteService(String serviceName);
    }
}
