using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Person
    {
        private string name;
        private int age;
        public void PrintValues()
        { Console.WriteLine($"my name is {name} and my age is {age}"); }

        public Person() { }
        public Person(string name, int age)
{
        this.name =name ;
          this.age=age ;
            }
        
        public void SetName (string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return name;
        }

        public void SetAge (int age)
        {
            this.age = age;

        }
        public int GetAge ()
        {
            return age;

        }
    }
}
