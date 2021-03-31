using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Repository.Interfaces
{
    public interface IServicesRepository
    {
        Boolean AddService(Service newService);
        Boolean RemoveService(String serviceName);
        Boolean UpdateService(String serviceName, Service newService);
        Service ViewService(String serviceName);
        Service ViewServiceById(int idService);
        int GetServiceIdByName(String serviceName);
        List<Service> ViewAllServices();

        Boolean DeleteService(String serviceName);
    }
}
