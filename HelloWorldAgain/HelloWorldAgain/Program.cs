using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldAgain
{

    //a simple program to display the words Hello World
    class WeeWoo
    {
        static void Main(string[] args)
        {
            string username = "";
            int user_age = 0;
            int current_year = 0;

            Console.Write("Please enter your name: ");
            username = Console.ReadLine();

            Console.Write("Please enter your age: ");
            user_age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter the current year: ");
            current_year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello World! My name is {0} and I am {1} years old. I was born in {2}.",
                              username, user_age, current_year - user_age);

        }
    }
}
