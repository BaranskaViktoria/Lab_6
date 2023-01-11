using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    public class Human
    {
        private string firstName;
        private string lastName;

        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public string FirstName
        {
            get { return firstName; }
            protected set
            {
                // Якщо перша буква імені не велика - виняток
                if (!char.IsUpper(value[0]))
                {
                    Console.WriteLine("Expected upper case letter! Argument: firstName");
                }

                if (value.Length <= 3)
                {
                    Console.WriteLine("Expected length at least 4 symbols! Argument: firstName");

                }
                this.firstName = value;
            }
        }
        public string LastName
        {
            get { return lastName; }
            protected set
            {
                if (!char.IsUpper(value[0]))
                {
                    Console.WriteLine("Expected upper case letter! Argument: lastName");
                }

                if (value.Length <= 2)
                {
                    Console.WriteLine("Expected length at least 3 symbols! Argument: lastName)");
                }
                this.lastName = value;
            }
        }
    }
}
