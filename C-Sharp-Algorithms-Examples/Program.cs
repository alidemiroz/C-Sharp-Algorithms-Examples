using System;
using System.Collections.Generic;

namespace C_Sharp_Algorithms_Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
        }

        static void FactorialCalculationDay1()
        {
            // I did it in 7 minutes on day 1.
            while (true)
            {
                Console.Write("Faktöriyelini hesaplamak istediğiniz sayıyı giriniz: ");
                int number = int.Parse(Console.ReadLine());
                int sum = number;

                for (int i = number - 1; i > 0; i--)
                {
                    sum = sum * i;
                }

                Console.WriteLine(number + " sayısının faktöriyeli : " + sum);
            }
        }

        static void FindingPrimeNumberDay1()
        {
            // I did it in 13 minutes on day 1.
            while (true)
            {
                Console.Write("Hangi sayıya kadar olan asal sayıları bulmak istiyorsunz: ");
                int number = int.Parse(Console.ReadLine());

                Console.Write(number + "sayısına kadar olan asal sayılar: ");

                for (int i = 2; i < number; i++)
                {
                    int count = 0;
                    for (int j = 2; j < i + 1; j++)
                    {
                        if (i % j == 0)
                        {
                            count++;
                        }
                    }
                    if (count == 1)
                    {
                        Console.Write(i + ",");
                    }
                }
            }
        }

        static void CreatingFibonacciArrayDay1()
        {
            // I did it in 12 minutes on day 1.
            while (true)
            {
                Console.Write("Kaç sayılı Fibonacci dizisi istiyorsunuz: ");
                int number = int.Parse(Console.ReadLine());
                List<int> numbers = new List<int>();
                int temp1 = 0;
                int temp2 = 1;
                int newTemp = 0;

                for (int i = 0; i < number; i++)
                {
                    if (i == 0)
                    {
                        numbers.Add(temp1);
                    }
                    else if (i == 1)
                    {
                        numbers.Add(temp2);
                    }
                    else
                    {
                        newTemp = temp1 + temp2;
                        numbers.Add(newTemp);
                        temp1 = temp2;
                        temp2 = newTemp;
                    }
                }
                Console.Write(number + " tane sayılı Fibonacci dizisi: ");
                foreach (var item in numbers)
                {
                    Console.Write(item + ",");
                }
                Console.WriteLine();
            }
        }

        static void FactorialCalculationDay2()
        {
            // I did it in 4 minutes on day 2.
            while (true)
            {
                Console.Write("Sayı giriniz :");
                int number = int.Parse(Console.ReadLine());

                int temp = number;

                for (int i = number - 1; i > 0; i--)
                {
                    temp = temp * i;
                }

                Console.WriteLine(number + " sayısının faktöriyeli: " + temp);
            }
        }

        static void FindingPrimeNumberDay2()
        {
            // I did it in 6 minutes on day 2.
            while (true)
            {
                Console.Write("Hangi sayıya kadar olan asal sayıları görmek istiyorsunuz: ");
                int number = int.Parse(Console.ReadLine());

                Console.Write(number + " sayısına kadar olan asal sayılar: ");

                for (int i = 2; i < number; i++)
                {
                    int count = 0;
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            count++;
                        }
                    }
                    if (count == 0)
                    {
                        Console.Write(i + ",");
                    }
                }
            }
        }

        static void CreatingFibonacciArrayDay2()
        {
            // I did it in 5 minutes on day 2.
            while (true)
            {
                Console.Write("Kaç adetli Fibonacci dizisi istiyorsunuz: ");
                int number = int.Parse(Console.ReadLine());

                List<int> fibonacci = new List<int>();
                fibonacci.Add(0);
                fibonacci.Add(1);

                int temp = 0;
                int temp1 = 0;
                int temp2 = 1;

                for (int i = 0; i < number - 2; i++)
                {
                    temp = temp1 + temp2;
                    fibonacci.Add(temp);
                    temp1 = temp2;
                    temp2 = temp;
                }

                Console.Write("Fibonacci dizisi: ");

                foreach (var item in fibonacci)
                {
                    Console.Write("(" + item + ")");
                }
                Console.WriteLine();
            }
        }

    }
}

