﻿using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var age = 18;

            if (age >= 18)
            {
                Console.WriteLine("Du får dricka.");
            }
            else
            {
                Console.WriteLine("Du är för ung för att dricka.");
            }

            

            for (var i = 0; i <= 10; i++) //räknar upp till 10 och börjar vid 0
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            var tal = 10; 
            while (tal > 0) // medans talet som börjar på 10 är över 10 så ska den ta bort 1 varje gång den loopas tills den blir lika stor som 0
            {
                Console.WriteLine(tal);
                tal--;
            }

            var dag = 2;
            switch (dag)
            {
                case 1:
                    Console.WriteLine("Du kommer fan aldrig se detta medelandet");
                    break;

                case 2:
                    Console.WriteLine(" \n:)");
                    break;
            }
        }
    }
}
