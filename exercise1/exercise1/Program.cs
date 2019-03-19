using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = 3;
            int finish = 7;
            for (int i = start; i <= finish; i++) ;
            {
                Console.WriteLine();
                Console.WriteLine("${i}/t{i*10}/t{i*100}/t{i*1000}");
            }
            Console.WriteLine("/n>>>>while lop>>>>");
            while(start<=finish)
            {
                Console.WriteLine("${start}/t{start*10}/t{start*100}/t{start*1000}");
                start++;
            }

            Console.WriteLine("/n>>>>>>>>do while loop>>>>>>");
            start = 3;
            do
            {
                Console.WriteLine("${start}/t{start*10}/t{start*100}/t{start*1000}");
            }
            while (start <= finish);
            Console.ReadLine();



        }
    }
}
