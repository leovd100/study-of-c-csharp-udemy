using System;
using System.Collections.Generic;
using System.Text;

namespace Empresa.Entities
{
    class Employee
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }
        
        public Employee() { }

        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            this.ValuePerHour = valuePerHour;
        }

        public virtual double PayMent()
        {
            return Hours * ValuePerHour;
        }





    }
}
