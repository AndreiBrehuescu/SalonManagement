using Models;
using Salon.Bussiness.Interfaces;
using Salon.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Bussiness.Services
{
    public class ServicesService : IServicesService
    {
        private IServicesRepository servicesRepository;
    
        public ServicesService(IServicesRepository servicesRepository)
        {
            this.servicesRepository = servicesRepository;
        }

        public Boolean AddService(String name, float price)
        {
            Service newService = new Service();
            newService.SetPrice(price);
            newService.SetName(name);
            return servicesRepository.AddService(newService);
        }

        public Boolean RemoveServiceByName(String serviceName)
        {
            return servicesRepository.RemoveService(serviceName);
        }

        public Boolean UpdateServiceByName(String serviceName, String newServiceName, float newServicePrice)
        {
            Service currentService = servicesRepository.ViewService(serviceName);
            if (currentService == null)
                return false;

            Service newService = new Service();
            if (newServiceName != null)
                newService.SetName(newServiceName);
            else
                newService.SetName(currentService.GetName());

            if (newServicePrice <= 0)
                newService.SetPrice(currentService.GetPrice());
            else
                newService.SetPrice(newServicePrice);

            return servicesRepository.UpdateService(serviceName, newService);
        }

        public Service ViewServiceByName(String serviceName)
        {
            return servicesRepository.ViewService(serviceName);
        }

        public List<Service> ViewAllServices()
        {
            return servicesRepository.ViewAllServices();
        }

        private int GetServiceIdByName(String serviceName)
        {
            int id = servicesRepository.GetServiceIdByName(serviceName);
            if (id == 0)
                Console.WriteLine("Serviciu inexistent");

            return id;
        }
        public Boolean DeleteService(String serviceName)
        {
            return servicesRepository.DeleteService(serviceName);
        }

    }
}
