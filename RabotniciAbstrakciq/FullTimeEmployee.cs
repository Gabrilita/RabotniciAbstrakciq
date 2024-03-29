﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabotniciAbstrakciq
{
    public class FullTimeEmployee : BaseEmployee
    {
        protected string employeePosition;
        protected string employeeDepartment;

        public FullTimeEmployee(string employeeID, string employeeName, string employeeAdress, string employeePosition, string employeeDepartment)
            : base(employeeID, employeeName, employeeAdress)
        {
            this.employeePosition = employeePosition;
            this.employeeDepartment = employeeDepartment;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Position: {this.employeePosition}\nDepartment: {this.employeeDepartment}");
        }
        public override double CalculateSalary(int workingHours)
        {
            return 250 + workingHours * 10.80;
        }
        public override string GetDepartment()
        { 
            return $"Department: {this.employeeDepartment}";
        }
    }
}
