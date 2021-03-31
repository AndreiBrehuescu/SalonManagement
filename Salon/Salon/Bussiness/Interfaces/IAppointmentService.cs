using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Bussiness.Interfaces
{
    public interface IAppointmentService
    {
        List<Appointment> ViewAppointments();
        List<Appointment> ViewAppointmentsForClient(String clientName);
        List<Appointment> ViewAppointmentsByDate(DateTime startingDate, DateTime endDate);
        String AddAppointment(DateTime dateTime, String clientName, String clientNumber, List<Service> services);
        List<Appointment> ViewAppointmentsByDateAndHour(DateTime startingDate);
    }
}
