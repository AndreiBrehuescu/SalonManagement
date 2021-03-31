using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Appointment
    {
        public int Id;
        public DateTime DateTime;
        public string ClientName;
        public string ClientNumber;

        private List<Service> Services;
        private float TotalPrice;

        public Appointment() { }

        public Appointment(int id, DateTime dateTime, String clientName, String clientNumber, List<Service> services, float totalPrice)
        {
            this.Id = id;
            this.DateTime = dateTime;
            this.ClientName = clientName;
            this.ClientNumber = clientNumber;
            this.Services = services;
            this.TotalPrice = totalPrice;
        }
    
        public int GetId()
        {
            return this.Id;
        }

        public void SetId(int Id)
        {
            this.Id = Id;
        }

        public DateTime GetDateTime()
        {
            return this.DateTime;
        }
    
        public string GetClientName()
        {
            return this.ClientName;
        }

        public string GetClientNumber()
        {
            return this.ClientNumber;
        }

        public List<Service> GetServices()
        {
            return this.Services;
        }

        public float GetTotalPrice()
        {
            return this.TotalPrice;
        }
    }
}
