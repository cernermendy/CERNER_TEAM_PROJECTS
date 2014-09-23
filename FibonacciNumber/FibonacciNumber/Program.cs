using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FibonacciNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            Double current = 0, previous = 0, fibnum = 0, inputNumber = 0;


            Console.WriteLine("Enter a number greater than zero and press enter to find Fibonacci number");
            inputNumber = System.Convert.ToDouble(Console.ReadLine());

            if (inputNumber <= 0)
            {
                Console.WriteLine("Invalid number entry, Please enter number greater than zero!!!. Program terminating...");
                System.Threading.Thread.Sleep(1000);
                Environment.Exit(0);
            }
            Console.WriteLine("-----------------------------------------------------");

            while (fibnum <= inputNumber)
            {
                if (current == 0)
                {
                    current += 1;
                }
                else
                {
                    fibnum = current + previous;
                    previous = current;
                    current = fibnum;
                }


                if (fibnum <= inputNumber)
                    Console.WriteLine(fibnum);
                else
                    break;


                if (fibnum == 1)
                    Console.WriteLine(fibnum);
            }
            //string x = "";
            //x = null;



            //Console.WriteLine(string.Format("{0}", x).ToString().IndexOf("hi") >= 0);
            //Console.WriteLine(x.ToString().IndexOf("hi") >= 0);

        }
    }
}
