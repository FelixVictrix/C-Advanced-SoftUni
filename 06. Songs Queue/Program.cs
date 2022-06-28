using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {

            var songs = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            Queue<string> queueSongs = new Queue<string>();

            foreach (var item in songs)
            {
                queueSongs.Enqueue(item);
            }

            while (queueSongs.Count > 0)
            {

                var input = Console.ReadLine().Split().ToList();
                var command = input[0];
 
                switch (command)
                {
                    case "Play":
                        queueSongs.Dequeue();
                        break;
                    case "Add":
                        input.Remove(command);
                        var name = string.Join(" ",input);
                        var contains = queueSongs.Contains(name);
                        if (!contains)
                        {
                            queueSongs.Enqueue(name);
                            continue;
                        }
                        Console.WriteLine($"{name} is already contained!");
                        break;
                    case "Show":
                        Console.WriteLine(string.Join(", ", queueSongs));
                        break;
                }

            }
            Console.WriteLine("No more songs!");
        }
    }
}
