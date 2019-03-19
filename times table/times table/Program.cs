using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace times_table
{
    class Program
    {
        static void Main(string[] args)
        {
            //do loop
            int number = 7;
            Console.WriteLine("************* For Loop *************");
           

            for (int i = 1; i <= 12; i++) 
            {
                Console.WriteLine($"{i}*{number} = {i * number }");


            }

                Console.WriteLine("/n***************while loop**********");
                int Counter = 1;
                /*while loop*/
                while (Counter <= 12)
            { 
                    Console.WriteLine($"{Counter}*{number} = {Counter * number }");
                Counter++;
            }        

            Console.WriteLine("/n*************** do while loop**********");
            /*while loop*/
             Counter = 1;
            do
            {
                Console.WriteLine($"{Counter}*{number} = {Counter * number }");
                Counter ++;
            }
            while (Counter <= 12);
            Console.WriteLine("end of task 2");
            Console.ReadLine();






        }
    }
}
