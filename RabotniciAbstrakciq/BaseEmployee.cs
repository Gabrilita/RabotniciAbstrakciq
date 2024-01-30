using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabotniciAbstrakciq
{
    public abstract class BaseEmployee
    {
        protected string employeeID;
        protected string employeeName;
        protected string employeeAdress;

        public BaseEmployee(string emloyeeID, string employeeName, string employeeAdress) 
        { 
            this.employeeID = emloyeeID;
            this.employeeName = employeeName;
            this.employeeAdress = employeeAdress;
        }

        public virtual void Show()
        {
            Console.WriteLine($"ID: {this.employeeID}\nName: {this.employeeName}\nAdress: {this.employeeAdress}");
        }

        public abstract double CalculateSalary(int workingHours);
        public abstract string GetDepartment();
    }
}
