﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    for (int k = start; k <= end; k++)
                    {
                        for (int l = start; l <= end; l++)
                        {
                            if ((i % 2 == 0 && l % 2 == 1) || (i % 2 == 1 && l % 2 == 0))
                            {
                                if (i > l && ((j + k) % 2 == 0))
                                {
                                    Console.Write($"{i}{j}{k}{l} ");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}