using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GROUPING
{
    class Program
    {
        public class Person 
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; private set; }

            public Person(string fName, string lName, int age)
            {
                FirstName = fName;
                LastName = lName;
                Age = age;
            }

            public string GetFullNmae()
            {
                string fullname = FirstName + " " + LastName;
                return fullname;
            }
            public void DisplayInfo()
            {
                string fullname = GetFullNmae();
                Console.WriteLine($"Full Name: {fullname}, Age: {Age}");
            }

            public bool IsAdult()
            {
                return Age >= 18;
            }
            public void HaveBirthday()
            {
                Age += 1;
               
            }

        }

        static void Main(string[] args)
        {
            Person p = new Person("John", "Rinel", 19);
            p.GetFullNmae();
            p.DisplayInfo();
            p.IsAdult();
            p.HaveBirthday();
        }
    }
}
