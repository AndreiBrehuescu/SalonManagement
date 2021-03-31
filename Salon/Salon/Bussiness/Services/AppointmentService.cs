using Models;
using Salon.Bussiness.Interfaces;
using Salon.Repository.Interfaces;
using Salon.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Bussiness.Services
{
    public class AppointmentService : IAppointmentService
    {
        private IAppointmentRepository appointmentRepository;
    
        public AppointmentService(IAppointmentRepository appointmentRepository)
        {
            this.appointmentRepository = appointmentRepository;
        }

        public List<Appointment> ViewAppointments()
        {
            return appointmentRepository.ViewAppointments();
        }

        public List<Appointment> ViewAppointmentsForClient(String clientName)
        {
            return appointmentRepository.ViewAppointmentForClient(clientName);
        }
    
        public List<Appointment> ViewAppointmentsByDate(DateTime startingDate, DateTime endDate)
        {
            return appointmentRepository.ViewAppointmentsByDate(startingDate, endDate);
        }

        public List<Appointment> ViewAppointmentsByDateAndHour(DateTime startingDate)
        {
            return appointmentRepository.ViewAppointmentsByDateAndHour(startingDate);
        }

        public String AddAppointment(DateTime dateTime, String clientName, String clientNumber, List<Service> services)
        {
            Appointment newAppointment = new Appointment(0, dateTime, clientName, clientNumber, services, AppointmentUtility.GetTotalPrice(services));

            List<Appointment> existingAppointments = ViewAppointmentsByDateAndHour(dateTime);

            String conflicts = "";

            foreach(Appointment appointment in existingAppointments)
            {
                foreach(Service existingService in appointment.GetServices())
                {
                    foreach(Service service in newAppointment.GetServices())
                    {
                        if(existingService != null)
                        {
                            if (service.GetName().Equals(existingService.GetName()))
                            {
                                conflicts += service.GetName() + ", ";
                            }
                        }

                    }
                }
                         
            }
            if(conflicts.Length > 0)
                conflicts = conflicts.Remove(conflicts.Length - 2);
            else
            {
                appointmentRepository.AddAppointment(newAppointment);
            }
            

            return conflicts;
        }

    }
}
