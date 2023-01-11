using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
        public class Person
        {
            private int age;
            private string name;

            public Person(string name, int age)
            {
                this.Name = name;
                this.Age = age;
            }
        //віртуальний метод( які ми хочемо зробити доступними для перевизначення, у базовому класі .)
        public virtual int Age
            {
                get
            {
                // get доступу явно обмежено шляхом застосування модифікатора доступу protected до самого засобу доступу.publicset
                return this.age;
            }
                protected set
                {
                    if (value < 0)
                    {
                    //метод, хотя бы один из переданных аргументов не соответствует спецификации параметра вызываемого метода. 
                    Console.WriteLine("Age must be positive!");
                    }

                    this.age = value;
                }
            }

            public virtual string Name
            {
                get { return this.name; }
                protected set
                {
                           // чи є вказаний рядок nullчи порожнім ("").
                if (value.Length < 3 || string.IsNullOrEmpty(value))
                    {
                    Console.WriteLine("Name's length should not be less than 3 symbols!");
                    }

                    this.name = value;
                }
            }

            public override string ToString()
            {
                var stringBuilder = new StringBuilder();
                stringBuilder.Append($"Name: {this.Name}, Age: {this.Age}");

                return stringBuilder.ToString();
            }

        }
}
