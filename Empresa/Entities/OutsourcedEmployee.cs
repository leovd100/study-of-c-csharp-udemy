using System;
using System.Collections.Generic;
using System.Text;

namespace Empresa.Entities
{
    class OutsourcedEmployee : Employee
    {

        public double AdditionlCharge { get; set; }

        public OutsourcedEmployee() { }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionlCharge) : base(name,hours,valuePerHour)
        {
            AdditionlCharge = additionlCharge;
        }

        public override double PayMent()
        {
            double salary = base.PayMent() + 1.1 * AdditionlCharge;
            return salary;
        }


    }
}
