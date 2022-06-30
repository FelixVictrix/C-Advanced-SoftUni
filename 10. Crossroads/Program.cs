using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {

            var greenLight = int.Parse(Console.ReadLine());
            var freeWindow = int.Parse(Console.ReadLine());

            Queue<string> queue = new Queue<string>();

            var input = Console.ReadLine();
            var count = 0;

            while (input != "END")
            {
                var time = greenLight;

                if (input != "green")
                {
                    queue.Enqueue(input);
                    input = Console.ReadLine();
                    continue;
                }
                while (time > 0 && queue.Count > 0)
                {
                    var car = queue.Dequeue();

                    if (time - car.Length >= 0)
                    {
                        count++;
                        time -= car.Length;
                        continue;
                    }
                    if (time + freeWindow - car.Length >= 0)
                    {
                        time = 0;
                        count++;
                        continue;
                    }
                    var crash = time + freeWindow;

                    Console.WriteLine("A crash happened!");
                    Console.WriteLine($"{car} was hit at {car[crash]}.");

                    Environment.Exit(0);
                }
                
                input = Console.ReadLine();
            }
            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{count} total cars passed the crossroads.");
        }
    }
}
