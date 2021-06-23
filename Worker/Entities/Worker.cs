using System;
using System.Collections.Generic;
using System.Text;
using WorkerProgram.Entities.Enums;

namespace WorkerProgram.Entities
{
    class Worker
    {
        public string name { get; set; }
        public WorkerLevel level { get; set; }
        public double BaseSalary { get; set; }
        public Department department { get; set; }

        public List<HourContract> Contracts { get; set; } = new List<HourContract>();


        public Worker() { }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            this.name = name;
            this.level = level;
            BaseSalary = baseSalary;
            this.department = department;
        }



        public void addContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void removeContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach(HourContract contract in Contracts)
            {
                if(contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }

            return sum;

        }



    }
}
