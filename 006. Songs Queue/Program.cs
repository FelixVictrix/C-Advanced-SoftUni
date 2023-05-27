using System;
using System.Collections.Generic;
using System.Linq;

namespace _006._Songs_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] songsNames = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None);

            Queue<string> listOfSongs = new Queue<string>(songsNames);

            while (listOfSongs.Any())
            {
                string[] input = Console.ReadLine().Split(new string[] { " " }, 2, StringSplitOptions.None);

                Player(input, listOfSongs);


            }

            Console.WriteLine("No more songs!");
        }

        static void Player(string[] input, Queue<string> listOfSongs)
        {
            string command = input[0];

            switch (command)
            {
                case "Play":
                    listOfSongs.Dequeue(); break;
                case "Add":
                    string newSong = input[1];

                    if (listOfSongs.Contains(newSong))
                    {
                        Console.WriteLine($"{newSong} is already contained!"); break;
                    }

                    listOfSongs.Enqueue(newSong); break;
                case "Show":
                    Console.WriteLine(string.Join(", ", listOfSongs)); break;
            }
        }
    }
}
