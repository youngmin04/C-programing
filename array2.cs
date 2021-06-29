using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Programing
{
    class array2
    {
        static int GetHighestScore(int[] scores)
        {
            int max = 0;
            for(int i = 0; i < 5; i++)
            {
                if (max < scores[i])
                {
                    max = scores[i];
                }
            }
            return max;
        }
        static int GetAverageScore(int[] scores)
        {
            int sum=0;
            for(int i = 0; i < 5; i++)
            {
                sum += scores[i];
            }
            return sum / 5;
        }
        static int GetIndexOf(int[] scores, int value)
        {
            for(int i = 0; i < 5; i++)
            {
                if (value == scores[i])
                {
                    return i;
                }
            }
            return -1;
        }
        static void Sort(int[] scores)
        {
            int temp;
            for(int i = 0; i < 5; i++)
            {
                for(int j = i + 1; j < 5; j++)
                {
                    if (scores[i] > scores[j])
                    {
                        temp = scores[i];
                        scores[i] = scores[j];
                        scores[j] = temp;
                    }
                }
                Write(scores[i] );
            }
        }
        static void Main()
        {
            int[] scores = new int[] { 10, 30, 40, 20, 50 };
            int highestScore = GetHighestScore(scores);
            Console.WriteLine(highestScore);

            int averageScore = GetAverageScore(scores);
            Console.WriteLine(averageScore);

            int index = GetIndexOf(scores, 20); //3반환해야 정상~
            Console.WriteLine(index);

            Sort(scores);
        }
    }
}
