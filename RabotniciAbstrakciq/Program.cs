using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabotniciAbstrakciq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Working hours: ");
            int workingHours = int.Parse(Console.ReadLine());

            Console.WriteLine("Employee1:");
            BaseEmployee employee1 = new FullTimeEmployee(Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine());
            employee1.Show();
            Console.WriteLine($"Salary: {employee1.CalculateSalary(workingHours)}");
            Console.WriteLine($"Department: {employee1.GetDepartment()}");

            Console.WriteLine("Employee2:");
            BaseEmployee employee2 = new ContractEmployee(Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine());
            employee2.Show();
            Console.WriteLine($"Salary: {employee2.CalculateSalary(workingHours)}");
            Console.WriteLine($"Department: {employee2.GetDepartment()}");
        }
    }
}
