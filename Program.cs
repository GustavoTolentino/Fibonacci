﻿using System;

namespace Fibonacci
{
   class Program
    {
        static void Main(string[] args)
        {

// ChatBot = Personagem que interage pelo chat

            Console.Write("Digite um numero :");
                int num;
                int x=1, y=0, z=0;
                num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++){
                z = x + y;
                Console.Write( z + " ,");

                    y = x;
                    x = z;
                }
            Console.ReadLine();
        }
    }
}
