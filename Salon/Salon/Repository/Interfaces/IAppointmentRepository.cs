using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Repository.Interfaces
{
    public interface IAppointmentRepository
    {
        Boolean AddAppointment(Appointment newAppointment);
        List<Appointment> ViewAppointments();
        List<Appointment> ViewAppointmentsByDate(DateTime startingDate, DateTime endDat);
        List<Appointment> ViewAppointmentForClient(String name);
        List<Appointment> ViewAppointmentsByDateAndHour(DateTime startingDate);

    }
}
