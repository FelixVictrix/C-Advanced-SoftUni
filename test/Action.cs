using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test
{
    public class Action
    {
        private List<Heroe> heroes = new List<Heroe>();

        public void Add(Heroe heroe)
        {
            heroes.Add(heroe);
        }
        public void CastSpell(string name, int mpNeeded, string spellName)
        {
            var currHeroe = heroes.FirstOrDefault(n => n.Name == name);
            if (currHeroe.MP >= mpNeeded)
            {
                currHeroe.MP -= mpNeeded;
                Console.WriteLine($"{currHeroe.Name} has successfully cast {spellName} and now has {currHeroe.MP} MP!");
            }
            else
            {
                Console.WriteLine($"{currHeroe.Name} does not have enough MP to cast {spellName}!");
            }

        }
        public void TakeDamage(string name, int damage, string attacker)
        {
            var currHeroe = heroes.FirstOrDefault(n => n.Name == name);
            if (currHeroe.HP - damage > 0)
            {
                currHeroe.HP -= damage;
                Console.WriteLine($"{currHeroe.Name} was hit for {damage} HP by {attacker} and now has {currHeroe.HP} HP left!");
            }
            else
            {
                Console.WriteLine($"{currHeroe.Name} has been killed by {attacker}!");
                heroes.Remove(currHeroe);
            }
        }
        public void Recharge(string name, int amount)
        {
            var currHeroe = heroes.FirstOrDefault(n => n.Name == name);
            if (currHeroe.MP + amount <= 200)
            {
                currHeroe.MP += amount;
                Console.WriteLine($"{currHeroe.Name} recharged for {amount} MP!");
            }
            else
            {
                amount = 200 - currHeroe.MP;
                currHeroe.MP = 200;
                Console.WriteLine($"{currHeroe.Name} recharged for {amount} MP!");
            }
        }
        public void Heal(string name, int amount)
        {
            var currHeroe = heroes.FirstOrDefault(n => n.Name == name);
            if (currHeroe.HP + amount <= 100)
            {
                currHeroe.HP += amount;
                Console.WriteLine($"{currHeroe.Name} healed for {amount} HP!");
            }
            else
            {
                amount = 100 - currHeroe.HP;
                currHeroe.HP=100;
                Console.WriteLine($"{currHeroe.Name} healed for {amount} HP!");
            }
        }
        public override string ToString()
        {
           StringBuilder sb = new StringBuilder();
            foreach (var item in heroes)
            {
                sb.AppendLine(item.Name);
                sb.AppendLine($" HP: {item.HP}");
                sb.AppendLine($" MP: {item.MP}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
