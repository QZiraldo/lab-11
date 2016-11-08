using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11
{
    class Program
    {
        static void Main(string[] args)
        {
        Person Joe = new Person("Joe", "555 Here st");
            Student Mike = new Student("Mike Jones", "333 Back Then", "Computer Science", 3, 32);
            Staff Shanna = new Staff("Shanna Cash", "360 They Didnt want Me", "Grand Circus", 50000);

            Console.WriteLine(Joe.ToString());
            Console.WriteLine(Mike.ToString());
            Console.WriteLine(Shanna.ToString());
        }
    }
}
