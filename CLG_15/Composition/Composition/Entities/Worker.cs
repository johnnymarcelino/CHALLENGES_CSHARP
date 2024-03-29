﻿using Composition.Entities.Enums;
using System.Collections.Generic;

namespace Composition.Entities
{
    internal class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HourContract contract)  // Do tipo HourContract -> Argumento de entrada
        {
            Contracts.Add(contract);  // lista de "itens"
        }

        public void RemoveContract(HourContract contract)  // Do tipo HourContract -> Argumento de entrada
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double sum = BaseSalary;

            foreach (HourContract contract in Contracts)
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
