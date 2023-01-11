using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    public class Student : Human
    {
        private string facultyNumber;

        public Student(string firstName, string lastName, string facultyNumber)
            : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get { return this.facultyNumber; }
            private set
            {
                value.ToCharArray();
                for (int i = 0; i < value.Length; i++)
                {
                    //Якщо в номері є літера, кількість цифр в номері менша за 5 або більше за 10 - виняток
                    if (char.IsLetter(value[i]) || value.Length < 5 || value.Length > 10)
                    {
                        throw new ArgumentException("Invalid faculty number!");
                    }
                }
                this.facultyNumber = value;
            }
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("----------------Student---------------");
            sb.AppendLine($"First Name: {this.FirstName}");
            sb.AppendLine($"Last Name: {this.LastName}");
            sb.AppendLine($"Faculty number: {this.FacultyNumber}");
            sb.AppendLine("--------------------------------------");
            return sb.ToString();
        }
    }
}
