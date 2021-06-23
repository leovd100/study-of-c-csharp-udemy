using System;
using System.Collections.Generic;
using Empresa.Entities;
using System.Globalization;
namespace Empresa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> employee = new List<Employee>();

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced (y/n) ? ");
                char c = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hour = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double Valuehour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(c == 'y')
                {
                    Console.Write("Additional Charge: ");
                    double additional = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    employee.Add(new OutsourcedEmployee(name, hour, Valuehour, additional)); 
                    
                }
                else
                {
                    employee.Add(new Employee(name, hour, Valuehour));
                }
            }
            Console.WriteLine("");
            Console.WriteLine("PAYMENTS:");
            foreach(Employee e in employee)
            {
                Console.WriteLine($"{e.Name} - $ {e.PayMent().ToString("F2", CultureInfo.InvariantCulture )}");
            }


        }
    }
}
