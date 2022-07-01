using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._Key_Revolver
{
    class Program
    {
        static void Main(string[] args)
        {

            int bulletPrice = int.Parse(Console.ReadLine());
            int barrelSize = int.Parse(Console.ReadLine());
            int[] bullets = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] locks = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int valueOfIntelligence = int.Parse(Console.ReadLine());

            Stack<int> bulletStack = new Stack<int>(bullets);
            Queue<int> locksQueue = new Queue<int>(locks);

            int bulletsSum = 0;
            int count = barrelSize;

            while (bulletStack.Any() && locksQueue.Any())
            {


                int bullet = bulletStack.Pop();
                int locker = locksQueue.Peek();
                bulletsSum += bulletPrice;
                count--;

                if (bullet <= locker)
                {

                    locksQueue.Dequeue();
                    Console.WriteLine("Bang!");
                }
                else
                {
                    Console.WriteLine("Ping!");
                }


                if (count == 0 && bulletStack.Any())
                {
                    Console.WriteLine("Reloading!");
                    count = barrelSize;
                }

            }

            int earning = valueOfIntelligence - bulletsSum;

            if (locksQueue.Any())
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locksQueue.Count}");
            }
            else
            {
                Console.WriteLine($"{bulletStack.Count} bullets left. Earned ${earning}");
            }
        }
    }
}
