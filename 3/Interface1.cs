using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    public class Worker : Human
    {
        private double weekSalary;
        private double workHoursPerDay;

        public Worker(string firstName, string lastName, double weekSalary, double workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public double WeekSalary
        {
            get { return this.weekSalary; }
            private set
            {
                if (value < 10)
                {
                    Console.WriteLine("Expected value mismatch! Argument: weekSalary");
                }

                this.weekSalary = value;
            }
        }

        public double WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            private set
            {
                if (value < 1 || value > 12)
                {
                    Console.WriteLine("Expected value mismatch! Argument: workHoursPerDay");
                }

                this.workHoursPerDay = value;
            }
        }

        private double GetSalaryPerHour()
        {
            return this.WeekSalary / (WorkHoursPerDay * 5.0);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            //Додає копію зазначеного рядка, за якою йде кінцевий знак рядка за замовчуванням
            sb.AppendLine("----------------Worker---------------");
            sb.AppendLine($"First Name: {this.FirstName}");
            sb.AppendLine($"Last Name: {this.LastName}");
            sb.AppendLine($"Week Salary: {this.WeekSalary:f2}");
            sb.AppendLine($"Hours per day: {this.WorkHoursPerDay:f2}");
            sb.AppendLine($"Salary per hour: {this.GetSalaryPerHour():f2}");
            sb.AppendLine("-------------------------------------");

            return sb.ToString();
        }
    }
}
