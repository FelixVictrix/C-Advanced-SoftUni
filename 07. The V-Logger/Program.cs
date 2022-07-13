using System;
using System.Collections.Generic;

namespace _07._The_V_Logger
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, Dictionary<string, int>> vLog = new Dictionary<string, Dictionary<string, int>>();

            var input = Console.ReadLine();

            while (input != "Statistics")
            {
                var info = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var name = info[0];
                var action = info[1];

                if (action == "joined" && !vLog.ContainsKey(name))
                {
                    vLog.Add(name, new Dictionary<string, int>());
                }
                else if (action == "followed")
                {
                    var follower = name;
                    var followed = info[2];

                    if (follower != followed && vLog.ContainsKey(follower) && vLog.ContainsKey(followed))
                    {
                        if (!vLog[followed].ContainsKey(follower))
                        {
                            vLog[followed].Add(follower, 0);
                        }
                    }

                }


                input = Console.ReadLine();
            }

        }
    }
}
