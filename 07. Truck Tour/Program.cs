using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            Queue<int[]> queue = new Queue<int[]>();

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                queue.Enqueue(input);
            }

            var startIndex = 0;
           
            while (true)
            {
                var totalLiters = 0;
                var isComplete = true;

                foreach (int[] item in queue)
                {
                    var liters = item[0];
                    var distnace = item[1];

                    totalLiters += liters;

                    if (totalLiters - distnace < 0)
                    {
                        startIndex++;
                        int[] currPump = queue.Dequeue();
                        queue.Enqueue(currPump);
                        isComplete = false;
                        break;
                    }
                    totalLiters-=distnace;
                }

                if (isComplete)
                {
                    Console.WriteLine(startIndex);
                    break;
                }
            }
        }
    }
}
