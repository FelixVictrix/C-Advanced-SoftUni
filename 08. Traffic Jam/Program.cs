using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Traffic_Jam
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int carsCanPass = int.Parse(Console.ReadLine());

            Queue<string> queueOfCars = new Queue<string>();

            string input = Console.ReadLine();
            int carsPassed = 0;

            while (input != "end")
            {

                if (input == "green")
                {
                    //GreenToCarsToPass(carsCanPass, queueOfCars);

                    for (int i = 0; i < carsCanPass; i++)
                    {
                        if (!queueOfCars.Any())
                        {
                            break;
                        }
                        string carPassing = queueOfCars.Dequeue();
                        Console.WriteLine($"{carPassing} passed!");
                        carsPassed++;
                    }
                }
                else
                {
                    queueOfCars.Enqueue(input);
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"{carsPassed} cars passed the crossroads.");
        }

        //static void GreenToCarsToPass(int carsCanPass, Queue<string> queueOfCars)
        //{

        //}
    }
}
