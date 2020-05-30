using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
     class Person
    {
        private int _age = 28; //fields - a data within the class

        public int getAge() //method
        {
            return _age;
        }

        public void setAge(int newAge)
        {
            _age = newAge;
        }

        public static void greet()
        {
            Console.WriteLine("Hello!");
        }
    }
}
