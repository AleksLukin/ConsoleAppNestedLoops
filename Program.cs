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
            _=int.TryParse(s, out int number);

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
                else if (number == 4)
                {
                    FourAppTask();
                }
                else if(number == 5)
                {
                    FiveAppTask();
                }
                else if (number == 6)
                {
                    SixAppTask();
                }
                else if (number == 7)
                {
                    SevenAppTask();
                }
                else if (number == 8)
                {
                    EightAppTask();
                }
                else if (number == 9)
                {
                    NineAppTask();
                }
                else if (number == 10)
                {
                    TenAppTask();
                }
                else if (number == 11)
                {
                    ElevenTaskApp();
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
            Console.ReadKey();
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
                    int count = 0;
                    for (int j = 1; j <= result; j++)
                    {
                        if (i % j == 0)
                        {
                            count ++;                            
                        }
                    }

                    Console.WriteLine($"У числа {i} количество делителей равно {count}");
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
                        
            int.TryParse(s, out int result);

            if (result > 0)
            {
                for (int i = 1; i < result; i++)
                {   
                    int count = 0; 
                    
                    for (int j = 1; j <= result; j++)
                    {
                        if (i % j == 0 & i!= j)
                        {
                            count += j; 
                        }
                    }                    
                    if (i == count)
                    {
                        Console.WriteLine($"{i} - совершенное число!");
                    } 
                }    
            }
            else
            {
                Console.WriteLine($"The number didn`t type");
            }
        }
        /// <summary>
        /// Дано натуральное число  n. Можно его представить в виде суммы трёх квадратов натуральных чисел?
        /// Если можно, то: a. Указать тройку x, y, z, таких натуральных чисел, что x2 + y2 + z2 = n;
        ///                 b. Указать все тройки x, y, z таких натуральных чисел, что x2 + y2 + z2 = n.
        /// </summary>
        static void FourAppTask()
        {
            Console.Write("Введите натуральное число: ");
            int result = int.Parse(Console.ReadLine());
            int length = result + 1;
            for (int i = 1; i <= length; i++)
            {
                for (int j = 1; j <= length; j++)
                {
                    for (int k = 1; k <= length; k++)
                    {
                        double number = Math.Pow(i, 2) + Math.Pow(j, 2) + Math.Pow(k, 2);

                        if (result == number)
                        {
                            Console.WriteLine($"Число, равное сумме квадратов - {result}");
                            Console.WriteLine($"Первое слагаемое - {i}");
                            Console.WriteLine($"Второе слагаемое - {j}");
                            Console.WriteLine($"Третье слагаемое - {k}");

                        }
                    }
                }
            }
        }
        /// <summary>
        /// Найти натуральное число от 1 до 10000 с максимальной суммой делителей.
        /// </summary>
        static void FiveAppTask()
        {
            for (int i = 1; i < 10000; i++)
            {
                int count = 1;
                for (int j = 1; j < 10000; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }
                }                        
                if (count >= 63)
                {
                    Console.WriteLine($"Число {i} имеет максимальное количество делителей - {count}");
                }
            }
        }
        /// <summary>
        /// Даны натуральные числа a, b (a < b). Получить все простые числа p, удовлетворяющие неравенствам: a<=p<=b.
        /// </summary>
        static void SixAppTask()
        {
            Console.Write("Введите число а: ");
            int a = int.Parse( Console.ReadLine() );
            Console.Write("Введите число b. Оно должно быть больше предыдущего числа: ");
            int b = int.Parse(Console.ReadLine());

            if (a < b)
            {
                for (int p = a; a<=p & p<=b; p++)
                {
                    Console.WriteLine(p);
                }
            }
        }
        /// <summary>
        /// Даны натуральные числа n, m. Получить все меньшие n натуральные числа, квадрат суммы цифр которых равен m.
        /// </summary>
        static void SevenAppTask()
        {
            Console.Write("Введите число n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Введите число m: ");
            int m = int.Parse(Console.ReadLine());
            

            for (int i = 1; i < n; i++)
            {
                for(int j = 1;j < n; j++)
                {
                    if (Math.Pow(j += i, 2) == m)
                    {
                        Console.WriteLine($"Ответ: {j}");                        
                    }
                }
            }
        }
        /// <summary>
        /// Даны натуральные числа n и m. Найти все пары дружественных* чисел, лежащих в диапазоне от n до m. К примеру - 220 и 284.
        /// ---------------------------------------------------------------------------------------------------------------
        /// *Два числа называются дружественными, если каждое из них равно сумме всех делителей другого (само число в качестве делителя не рассматривается). 
        /// </summary>
        static void EightAppTask()
        {
            Console.Write("Введите число n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Введите число m: ");
            int m = int.Parse(Console.ReadLine());

            for (int i = n; i < m; i++)
            {
                for (int j = n; j < m; j++)
                {
                    if (i % j == 0 & j % i == 0)
                    {
                        int k = i + i;
                        int l = j + j;

                        if (k == l)
                        {
                            Console.WriteLine(k+" и "+l);
                        }
                        
                    }
                }
            }     
        }
        /// <summary>
        /// В данном натуральном числе переставить цифры таким образом, чтобы образовалось наименьшее число, записанное этими же цифрами.
        /// </summary>
        static void NineAppTask()
        {
            Console.Write("Введите число больше 10 но меньше 1000: ");
            int number = int.Parse(Console.ReadLine());

            if (number > 10 & number < 100)
            {
                int numberOne = number % 10;
                int numberTwo = number / 10;
                numberTwo %= 10;

                if (numberTwo>numberOne)
                {
                    Console.WriteLine($"Наименьшее число равно: {numberOne}{numberTwo}");
                }
                else
                {
                    Console.WriteLine($"Наименьшее число равно: {numberTwo}{numberOne}");
                }
            }                
            if (number > 100 & number < 1000)
            {
                int numberOne = number / 100;
                int numberTwo = number / 10;
                numberTwo %= 10;
                int numberThree = number % 10;

                if (numberTwo > numberOne & numberTwo > numberThree & numberThree>numberOne)
                {
                    Console.WriteLine($"Наименьшее число равно: {numberOne}{numberTwo}{numberThree}");
                }
                if (numberTwo > numberOne & numberTwo > numberThree & numberThree < numberOne)
                {
                    Console.WriteLine($"Наименьшее число равно: {numberThree}{numberOne}{numberTwo}");
                }
                if (numberThree > numberOne & numberThree > numberTwo & numberTwo < numberOne)
                {
                    Console.WriteLine($"Наименьшее число равно: {numberTwo}{numberOne}{numberThree}");
                }
                if (numberThree < numberOne & numberThree < numberTwo & numberTwo > numberOne)
                {
                    Console.WriteLine($"Наименьшее число равно: {numberThree}{numberOne}{numberTwo}");
                }
                if (numberThree < numberOne & numberThree < numberTwo & numberTwo < numberOne)
                {
                    Console.WriteLine($"Наименьшее число равно: {numberThree}{numberTwo}{numberOne}");
                }
                if (numberTwo < numberOne & numberTwo < numberThree & numberThree < numberOne)
                {
                    Console.WriteLine($"Наименьшее число равно: {numberTwo}{numberThree}{numberOne}");
                }
            }
            if (number >= 1000)
            {
                Console.WriteLine($"Число {number} больше 1000");
            }
            else if (number < 10)
            {
                Console.WriteLine("Введено число меньше 10");
            }

        }
        /// <summary>
        /// Составить программу, печатающую для данного натурального числа k-ю цифру последовательности: 
        /// a. 12345678910..., в которой выписаны подряд все натуральные числа; 
        /// b. 14916253649..., в которой выписаны подряд квадраты всех натуральных чисел;
        /// c. 1123581321..., в которой выписаны подряд все числа Фибоначчи.
        /// </summary>
        static void TenAppTask()
        {
            Console.Write("Введите число: ");
            int anyNumber = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine($"Выписаны подряд все натуральные числа: ");
            for (int i = 1; i <= anyNumber; i++)
            {
                Console.Write(i);                                
            }
            Console.WriteLine();
            Console.WriteLine($"Выписаны подряд все квадраты натуральных чисел: ");          
            for (int k = 1; k <= anyNumber ;k ++)
            {
                Console.Write(Math.Pow(k, 2));                
            }
            Console.WriteLine();
            Console.WriteLine($"Выписаны подряд все числа Фибоначчи начиная с 2: ");
            int prevNumber = 0;
            int nextNumber = 1;

            for (int j = 1; j < anyNumber; j++)
            {
                int fibonacchi = prevNumber + nextNumber;
                prevNumber = nextNumber;
                nextNumber = fibonacchi; 
                Console.Write(fibonacchi);                         
            }  
            
        }
        /// <summary>
        /// Составить программу возведения заданного числа в третью степень, используя следующую закономерность: 
        //1^3 = 1     //2^3 = 3 + 5       //3^3 = 7 + 9 + 11 
        //4^3 = 13 + 15 + 17 + 19        //5^3 = 21 + 23 + 25 + 27 + 29
        /// </summary>
        static void ElevenTaskApp()
        {
            Console.Write("Введите число для возведения в куб: ");
            int.TryParse(Console.ReadLine(), out int number); //ввод исходного числа
            int count = number * (number - 1) + 1;   //первое число в последовательности
            int result = 0;                         //переменная для накопления суммы

            for (int i = 0; i < number; i++)
            {                                
                result += count;
                count += 2;
            }
            Console.WriteLine(result);
        }
    }
}
