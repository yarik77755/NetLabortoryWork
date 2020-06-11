using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_1_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 0, y=0, result;
            bool Value = false;


            Console.WriteLine("Enter your 1 number\n");

            do
            {
                try
                {
                    x = double.Parse(Console.ReadLine());
                    Value = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка!");
                }
            } while (!Value);

            Console.WriteLine("Enter your 2 number \n");
            Value = false;
            do { 
                try
                {
                    y = double.Parse(Console.ReadLine());
                    Value = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка!");
                }
            } while (!Value) ;

            Console.Clear();
            

            result = x + y;
            Console.WriteLine("Your result =  " + result);
            Console.ReadKey();
        }
    }
}