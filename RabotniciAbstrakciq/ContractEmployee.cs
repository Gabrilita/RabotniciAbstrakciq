using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabotniciAbstrakciq
{
    public class ContractEmployee:BaseEmployee
    {
        protected string employeeTask;
        protected string employeeDepartment;

        public ContractEmployee(string employeeID, string employeeName, string employeeAdress, string employeeTask, string employeeDepartment)
            : base(employeeID, employeeName, employeeAdress)
        {
            this.employeeTask = employeeTask;
            this.employeeDepartment = employeeDepartment;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Task: {this.employeeTask}\nDepartment: {this.employeeDepartment}");
        }
        public override double CalculateSalary(int workingHours)
        {
            return 250 + workingHours * 20;
        }
        public override string GetDepartment()
        {
            return $"Department: {this.employeeDepartment}";
        }
    }
}

