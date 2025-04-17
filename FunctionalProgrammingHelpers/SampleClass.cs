using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgrammingHelpers
{
    public class SampleClass
    {
        public void SayHello(string Name)
        {
            Console.WriteLine($"Say Hello, {Name}");
        }

        public void SayGoodbye(string Name, int Time)
        {
            Console.WriteLine($"Say Goodbye, {Name} till {Time}");
        }

        public void Goodnight()
        {
            Console.WriteLine("Goodnight! Sleep well!");
        }

        public string GetName()
        {
            Console.WriteLine("GetName was called");
            return "Joshua";
        }

        public int GetTime(int Time)
        {
            Console.WriteLine($"The time is {Time}");
            return Time;
        }

        public bool IsInThePast(int Year)
        {
            if (Year > DateTime.Now.Year)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        public void EnterAge(Func<int, int> getAge, int Age)
        {
            int age = getAge(Age);
            Console.WriteLine($"Your age is {age}");
        }

    }
}
