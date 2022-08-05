using System;
using System.Collections.Generic;

namespace test
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            var lenght = int.Parse(Console.ReadLine());

            Action action1 = new Action();

            for (int i = 0; i < lenght; i++)
            {
                var heroeInfo = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var name = heroeInfo[0];
                var hp = int.Parse(heroeInfo[1]);
                var mp = int.Parse(heroeInfo[2]);

                action1.Add(new Heroe(name, hp, mp));

            }

            var input = Console.ReadLine();

            while (input != "End")
            {
                var command = input.Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                var action = command[0];
                var name = command[1];

                switch (action)
                {
                    case "CastSpell":
                        var mpNeeded = int.Parse(command[2]);
                        var spellName = command[3];
                        action1.CastSpell(name, mpNeeded, spellName);
                        break;
                    case "TakeDamage":
                        var damage = int.Parse(command[2]);
                        var attacker = command[3];
                        action1.TakeDamage(name, damage, attacker);
                        break;
                    case "Recharge":
                        var amount = int.Parse(command[2]);
                        action1.Recharge(name, amount);
                        break;
                    case "Heal":
                        amount = int.Parse(command[2]);
                        action1.Heal(name, amount);
                        break;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(action1.ToString());
        }
    }
}
