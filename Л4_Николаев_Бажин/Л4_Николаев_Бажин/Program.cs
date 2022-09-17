using System;
using System.Collections.Specialized;
using System.Runtime.InteropServices;

namespace Л4_Николаев_Бажин
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Задание 1
            int[] num = new int[10];
            int j=-1,count=0;
            Random rnd = new Random();

            for (int i = 0; i < num.Length; i++)
            {
                num[i] = rnd.Next(-7, 8);
                Console.Write(num[i]+" ");

            }
            Console.WriteLine("\nВведите любю цифру в диапазоне от -7 до 7");
            var n =Console.ReadLine();
            int.TryParse(n, out int result);
            for (int i = 0; i < num.Length; i++)
            {
                if(result==num[i])
                {
                    j=i;
                }
                if (result > num[i])
                {
                    count++;
                }
            }
            if (j == -1)
            {
                Console.WriteLine("Числа нет или не входит в диапозон!");
            }
            else
            {
                Console.WriteLine($"Последнее место нахождение :{j} \nКолличество элементов меньше указанного:{count}");
            }
         */
            /*Задание 2
             var n =Console.ReadLine();
            int.TryParse(n, out int result);
            int[] num = new int[result];
            int max = -11;
            Random rnd = new Random();
            e
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = rnd.Next(-10, 11);
                Console.Write(num[i] + " ");

                if (max < num[i])
                {

                    max = num[i];

                }
            }
            
            Console.WriteLine($"\nМаксимальное число :{max}");*/

            /*
            int[,] num = new int[4, 4];
            int[,] num2 = new int[4, 4];
            int min1 = 10,min2 = 20;
            Random rnd = new Random();

            for (int i = 0; i < 4; i++)
            {

                for (int j = 0; j < 4; j++)
                {
                    num[i, j] = rnd.Next(-5,6);
                    Console.Write(num[i, j] + " ");

                    if (min1 > num[i, j])
                    {
                        min1 = num[i, j];
                    }
                    if (num[i, j] % 2 == 0)
                    {
                        num2[i, j] = num[i, j] * 2;
                    }
                    else
                    {
                        num2[i, j] = num[i, j] * 3;
                    }

                    if (min2 > num2[i, j])
                    {
                        min2 = num2[i, j];
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine($"\nМинимальное число старого массива :{min1}\n");
            for (int i = 0; i < 4; i++)
            {

                for (int j = 0; j < 4; j++)
                {
                    Console.Write(num2[i, j] + " ");
                }
                Console.WriteLine();
            }
                    
            Console.WriteLine($"\nМинимальное число нового массива :{min2}");
            */
            /*Задание 4
            Console.WriteLine("Введите размерность: ");
            var num = Console.ReadLine();
            int n = int.Parse(num);
            int sum = 0;
            int[] numbers = new int[n];
            Random rnd = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(-13,12);
                Console.Write(numbers[i] + " ");
                sum += numbers[i];
            }

            Console.WriteLine($"Сумма массива: {sum}");

            */
            /*Задание 5
            Console.WriteLine("Введите размерность: ");
            var num = Console.ReadLine();
            int n = int.Parse(num);
            int proiz = 1;
            int[] numbers = new int[n];
            Random rnd = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(-19, 27);
                Console.Write(numbers[i] + " ");
                if (numbers[i] % 2 != 0)
                {
                    proiz *= numbers[i];
                }
                
            }
            if(proiz == 1)
            {
                Console.WriteLine("Нет нечетных номеров!");
            }
            else
            {
                Console.WriteLine($"Произведение нечетных номеров массива: {proiz}");
            }
            */
            /*Задание 6
            Console.Write("Введите числа через пробел: ");
            var num = Console.ReadLine();
            string[] number = num.Split(new Char[] { ' ' });
            int result = 0;
            int count = 0;
            foreach (string n in number)
            {
                int qua = int.Parse(n);
                do
                {
                    result = qua % 10;
                    if (result == 0)
                    {
                        count++;
                    }
                    qua /= 10;
                }
                while (qua > 0);
                Console.WriteLine(count);
            }
            */

            Console.WriteLine("Введите размерность n*n массива: ");
            var num = Console.ReadLine();
            int n = int.Parse(num);
            int[,] number = new int[n, n];
            int[,] number2 = new int[n, n];
            double a = 0d;
            double a1 = 0d;
            Random rnd = new Random();  
            
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    number[i, j] = rnd.Next(-3, 4);
                    number2[i, j] = number[i, j];
                    Console.Write(number[i,j] + " "); 
                    if (number2[i,j] < 0)
                    {
                        number2[i, j] = -number2[i, j];
                      
                    }
                    if (i == j)
                    {
                        a += number[i, j];
                        a1 += number2[i, j];
                    }
                   
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Среднее арифметическое главной диагонали старого массива: {a/n}\n");


            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(number2[i, j] + " ");
                    
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Среднее арифметическое главной диагонали нового массива: {a1 / n}\n");

        }
    }
}
