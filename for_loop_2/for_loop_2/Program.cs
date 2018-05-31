using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_loop_2
{

    //a simple program to display the words Hello World
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string> { "christian", "zachery", "chantel", "jj" };
            //Console.WriteLine(names[count]);

            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }


        }
    }
}