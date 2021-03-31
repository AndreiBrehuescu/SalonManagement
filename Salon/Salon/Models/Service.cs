using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Service
    {
        private int Id;
        private string Name;
        private float Price;

        public Service()
        {

        }

        public Service(int id, String name, float price)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
        }

        public int GetId()
        {
            return this.Id;
        }

        public string GetName()
        {
            return this.Name;
        }

        public float GetPrice()
        {
            return this.Price;
        }

        public void SetPrice(float price)
        {
            this.Price = price;
        }

        public void SetName(String name)
        {
            this.Name = name;
        }
    }
}
