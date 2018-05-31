using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace control_flow_1
{

    //a simple program to display the words Hello World
    class Program
    {
        static void Main(string[] args)
        {
            int user_age;
            Console.Write("Enter your age: ");
            user_age = Convert.ToInt32(Console.ReadLine());

            if (user_age < 0 || user_age > 100)
            {
                Console.WriteLine("Invalid Age");
                Console.WriteLine("Age must be between 0 - 100");
            }

            else if (user_age < 18)
            {
                Console.WriteLine("Sorry, you are still a minor.");
            }

            else if (user_age >= 18 && user_age < 21)
            {
                Console.WriteLine("You are old enough to attend the event," +
                                  " however you will be unable to drink.");
            }

            else
            {
                Console.WriteLine("Thank you for registering! We hope you" +
                                  " enjoy the event.");
            }

        }
    }
}
