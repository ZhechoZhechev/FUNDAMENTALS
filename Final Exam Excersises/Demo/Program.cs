using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3___Heroes_of_Code_and_Logic_VII
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfHeroes = int.Parse(Console.ReadLine());
            Dictionary<string, KeyValuePair<int, int>> heroes = new Dictionary<string, KeyValuePair<int, int>>();

            for (int i = 0; i < numberOfHeroes; i++)
            {
                string[] heroesInfo = Console.ReadLine().Split();

                string heroeName = heroesInfo[0];
                int hitPoints = int.Parse(heroesInfo[1]);
                int manaPoints = int.Parse(heroesInfo[2]);

                heroes.Add(heroeName, new KeyValuePair<int, int>(hitPoints, manaPoints));
            }

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }

                string[] info = input.Split(" - ");

                string action = info[0];

                if (action == "CastSpell")
                {//"CastSpell – {hero name} – {MP needed} – {spell name}"
                    string currHero = info[1];
                    int manaPointNeeded = int.Parse(info[2]);
                    string spellName = info[3];

                    if (heroes[currHero].Value > manaPointNeeded)
                    {
                        int hp = heroes[currHero].Key;                                 //* Клуча на KeyValuePair
                        int newManaPoints = heroes[currHero].Value - manaPointNeeded; // * променяме старото Value на KeyValuePair, за да зададем отдолу новата
                        heroes[currHero] = new KeyValuePair<int, int>(hp, newManaPoints); // задаваме старият Key с ново Value
                        Console.WriteLine($"{currHero} has successfully cast {spellName} and now has {newManaPoints} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{currHero} does not have enough MP to cast {spellName}!");
                    }
                }
                else if (action == "TakeDamage")
                {
                    string currHero = info[1];
                    int damage = int.Parse(info[2]);
                    string attacker = info[3];

                    heroes[currHero] = new KeyValuePair<int, int>(heroes[currHero].Key - damage, heroes[currHero].Value);

                    if (heroes[currHero].Key > 0)
                    {
                        Console.WriteLine($"{currHero} was hit for {damage} HP by {attacker} and now has {heroes[currHero].Key} HP left!");
                    }
                    else
                    {
                        Console.WriteLine($"{currHero} has been killed by {attacker}!");
                        heroes.Remove(currHero);
                    }
                }
                else if (action == "Recharge")
                {
                    string currHero = info[1];
                    int amount = int.Parse(info[2]);
                    int currMana = heroes[currHero].Value;


                    heroes[currHero] = new KeyValuePair<int, int>(heroes[currHero].Key, heroes[currHero].Value + amount);

                    if (heroes[currHero].Value > 200)
                    {
                        int manaPoints = 200;
                        heroes[currHero] = new KeyValuePair<int, int>(heroes[currHero].Key, manaPoints);
                        Console.WriteLine($"{currHero} recharged for {manaPoints - currMana} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{currHero} recharged for {amount} MP!");
                    }
                }

                else if (action == "Heal")
                {
                    string currHero = info[1];
                    int amount = int.Parse(info[2]);
                    int currHp = heroes[currHero].Key;
                    heroes[currHero] = new KeyValuePair<int, int>(heroes[currHero].Key + amount, heroes[currHero].Value);

                    if (heroes[currHero].Key > 100)
                    {
                        int amountRecovered = 100 - currHp; ;
                        heroes[currHero] = new KeyValuePair<int, int>(100, heroes[currHero].Value);
                        Console.WriteLine($"{currHero} healed for {amountRecovered} HP!");
                    }
                    else
                    {
                        Console.WriteLine($"{currHero} healed for {amount} HP!");

                    }
                }
            }
            foreach (var item in heroes) 
            {
                Console.WriteLine($"{item.Key}");

                Console.WriteLine($"HP: {heroes[item.Key].Key}");
                Console.WriteLine($"MP: {heroes[item.Key].Value}");
            }

            //foreach (var hero in heroes)
            //{
            //    Console.WriteLine(hero.Key);
            //    foreach (var item in hero.Value.ToString())
            //    {
            //        Console.WriteLine(item);
            //    }
            //}
        }
    }
}