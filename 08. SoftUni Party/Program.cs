using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {

            HashSet<string> guestsVip = new HashSet<string>();
            HashSet<string> guests = new HashSet<string>();

            var input = Console.ReadLine();

            while (input != "PARTY")
            {
                if (input.Length>8)
                {
                    input = Console.ReadLine();
                    continue;
                }
                if (char.IsDigit(input[0]))
                {
                    guestsVip.Add(input);
                }
                else
                {
                    guests.Add(input);
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "END")
            {
                if (input.Length > 8)
                {
                    input = Console.ReadLine();
                    continue;
                }

                var contains = guestsVip.Contains(input)
                    ? guestsVip.Remove(input)
                    : guests.Remove(input);

                input = Console.ReadLine();
            }

            Console.WriteLine(guests.Count + guestsVip.Count);
            //Console.WriteLine(string.Join("\n", guestsVip));
            //Console.WriteLine(string.Join("\n",guests));
            foreach (var item in guestsVip)
            {
                Console.WriteLine(item);
            }
            foreach (var item in guests)
            {
                Console.WriteLine(item);
            }
        }
    }
}
