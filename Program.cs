using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppNestedLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please, type a number of a task from 1 to 14: ");
            string s = Console.ReadLine();
            bool result = int.TryParse(s, out int number);

            try
            {
                if (number == 1)
                {
                    OneAppTask();
                }
                else 
                {
                    Console.WriteLine("The number of the task is not corrected. Let`s one more time");
                }
                Console.WriteLine($"The process is: {result}");
                Console.WriteLine( );
            }

            catch(Exception ex) 
            {
                Console.WriteLine($"Processing failed: {ex.Message}");
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        /// <summary>
        /// Исходное данное - натуральное число q, выражающее площадь. 
        /// Написать программу для нахождения всех таких прямоугольников, площадь которых равна q и стороны выражены натуральными числами.
        /// </summary>
        static void OneAppTask()
        {
            Console.Write("Please, type any number to 100: ");
            string s = Console.ReadLine();

            int.TryParse(s, out int anyNumber);

            try
            {                
                for (double i = 1; i <= 6; i++)
                {
                    for (double j = 1; j <= 6; j++)
                    {
                        if (anyNumber / (i * j) == 1 && i != j)
                        {
                            Console.WriteLine($"The square {anyNumber} conteins {i} и {j}");
                        }
                    }
                } 
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Processing failed: {ex.Message}");
                throw;
            }
        }
    }
}
