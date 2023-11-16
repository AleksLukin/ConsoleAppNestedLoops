using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
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
                else if (number == 2)
                {
                    SecondTaskApp();
                }
                else if (number == 3)
                {
                    ThreeTaskApp();
                }
                else 
                {
                    Console.WriteLine("The number of the task is not corrected. Let`s one more time");
                }
                
                Console.WriteLine( );
            }

            catch(FormatException ex) 
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
                      
            for (double i = 1; i <= 6; i++)
            {
                for (double j = 1; j <= 6; j++)
                {
                    if (anyNumber / (i * j) == 1 && i != j)
                    {
                        Console.WriteLine($"The square {anyNumber} conteins {i} и {j}");
                    }
                    else
                    {
                        Console.WriteLine($"The number {anyNumber} isn`t convinient for this task");
                        break;
                    }
                }                
            }   
        }
        /// <summary>
        /// Составить программу для графического изображения делимости чисел от 1 до n (n - исходное данное). 
        /// В каждой строке надо печатать число и сколько плюсов, сколько делителей у этого числа. 
        /// Например, если исходное данное - число 4, то на экране должно быть напечатано: 
        ///    1+
        ///    2++
        ///    3++
        ///    4+++
        /// </summary>
        static void SecondTaskApp()
        {
            Console.Write("Please, type any natural number: ");
            string s = Console.ReadLine();

            int.TryParse(s, out int result);

            if (result > 0)
            {
                for (int i = 1; i <= result; i++)
                {
                    for (int j = 1; j <= result; j++)
                    {
                        if (i % j == 0)
                        {
                            Console.WriteLine($"{i}+");
                            

                            break;
                        }                    
                    }                    
                }
            }
            else
            {
                Console.WriteLine($"The number didn`t type");
            }
        }
        /// <summary>
        /// Составить программу получения всех совершенных чисел, меньших заданного числа n. Число называется совершенным, если равно сумме всех
        /// своих положительных делителей, кроме самого этого числа. Например, 28 - совершенноe, так как 28=1+2+4+7+14. 
        /// </summary>
        static void ThreeTaskApp()
        {
            Console.Write("Please, type any natural number: ");
            string s = Console.ReadLine();
            
            int count = 0;
            int.TryParse(s, out int result);

            if (result > 0)
            {
                for (int j = 1; j < result; j++)
                {
                    if (result % j == 0)
                    {
                        count += j;
                    }
                }                    
                if (result == count)
                {
                    Console.WriteLine($"{result} - совершенное число!");
                }
                else
                {
                    Console.WriteLine($"{result} - несовершенное число!");
                }
                
            }
            else
            {
                Console.WriteLine($"The number didn`t type");
            }
        }
    }
}
