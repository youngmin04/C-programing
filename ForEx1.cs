using System;
using System.Collections.Generic;
using System.Text;

namespace Programing
{
    class ForEx1
    {
        static void Main()
        {
            //for(int i = 1; i <= 5; i++)
            //{
            //    for(int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //for(int i=1;i<=5;i++)
            //{
            //    for(int j = 5; j >= i; j--)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //int i = 1;
            //int j;
            //while (i <= 5)
            //{
            //    j = 1;
            //    while (j<=i)
            //    {
            //        Console.Write("*");
            //        j++;
            //    }
            //    Console.WriteLine();
            //    i++;
            //}
            //int i = 1;
            //int j;
            //while (i <= 5)
            //{
            //    j = 5;
            //    while (j >= i)
            //    {
            //        Console.Write("*");
            //        j--;
            //    }
            //    Console.WriteLine();
            //    i++;
            //}
            //int i = 1;
            //int j;
            //do
            //{
            //    j = 1;
            //    do
            //    {
            //        Console.Write("*");
            //        j++;
            //    } while (j <= i);
            //    Console.WriteLine();
            //    i++;
            //} while (i <= 5);
            //int i = 1;
            //int j;
            //do
            //{
            //    j = 5;
            //    do
            //    {
            //        Console.Write("*");
            //        j--;
            //    } while (j >= i);
            //    Console.WriteLine();
            //    i++;
            //} while (i <= 5);

            Console.Write("반복 횟수를 입력하세요 : ");

            int input1 = int.Parse(Console.ReadLine());

            if (input1 <= 0)
            {
                Console.WriteLine("0보다 작거나 같은 수는 입력할 수 없습니다.");
            }
            else
            {
                for (int i = 1; i <= input1; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }

            
        }
    }
}
