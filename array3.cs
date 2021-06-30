using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Programing
{
    class array3 //다차원 배열
    {
        class Map
        {
            int[,] tiles = {
                { 1, 1, 1, 1, 1 },
                { 1, 0, 0, 0, 1 },
                { 1, 0, 0, 0, 1 },
                { 1, 0, 0, 0, 1 },
                { 1, 1, 1, 1, 1 }
            };
            public void Render()
            {
                for (int y = 0; y < tiles.GetLength(1); y++)
                {
                    for (int x = 0; x < tiles.GetLength(0); x++)
                    {
                        if (tiles[y, x] == 1)
                            Console.ForegroundColor = ConsoleColor.Red;
                        else
                            Console.ForegroundColor = ConsoleColor.Green;

                        Console.Write("\u25cf");
                    }
                    Console.WriteLine();
                }
            }
        }
        static void Main(string[] args)
        {   /*
            int[] scores = new int[5] { 10, 30, 40, 20, 50 };

            int[,] arr = new int[2, 3] {{1,2,3},{1,2,3}};

            arr[0, 0] = 1;
            arr[1, 0] = 1;
            */

            Map map = new Map();
            map.Render();
        }
    }
}
