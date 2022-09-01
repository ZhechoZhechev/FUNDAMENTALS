using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.Heroes_of_Code_and_Logic_VII
{
    class Hero
    {
        public Hero(string name, int hp, int mp)
        {
            Name = name;
            HP = hp;
            MP = mp;
        }
        public string Name { get; set; }
        public int HP { get; set; }
        public int MP { get; set; }
    }
    class Program
    {
        static void Main()
        {
            int numOfHeroes = int.Parse(Console.ReadLine());

            const int HERO_MAX_HP = 100;
            const int HERO_MAX_MP = 200;

            List<Hero> heroes = new List<Hero>();

            for (int i = 0; i < numOfHeroes; i++)
            {
                var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string heroName = input[0];
                int heroHp = int.Parse(input[1]);
                int heroMp = int.Parse(input[2]);

                Hero hero = new Hero(heroName, heroHp, heroMp);
                heroes.Add(hero);
            }

            string inputNew = string.Empty;

            while ((inputNew = Console.ReadLine()) != "End")
            {
                var info = inputNew.Split(" - ");
                string action = info[0];
                string heroName = info[1];

                var curHero = heroes.FirstOrDefault(x => x.Name == heroName);
                
                switch (action)
                {
                    case "CastSpell":
                        int mpNeeded = int.Parse(info[2]);
                        string spellName = info[3];


                        if (heroes.Any(x => x.Name == heroName && x.MP >= mpNeeded))
                        {
                            curHero.MP = curHero.MP - mpNeeded;

                            Console.WriteLine($"{curHero.Name} has successfully cast {spellName} and now has {curHero.MP} MP!");
                        }
                        else
                        {
                            Console.WriteLine($"{curHero.Name} does not have enough MP to cast {spellName}!");
                        }
                        break;
                    case "TakeDamage":
                        int damage = int.Parse(info[2]);
                        string attacker = info[3];
                        
                        curHero.HP = curHero.HP - damage;

                        if (curHero.HP > 0)
                        {
                            Console.WriteLine($"{curHero.Name} was hit for {damage} HP by {attacker} and now has {curHero.HP} HP left!");
                        }
                        else 
                        {
                            Console.WriteLine($"{curHero.Name} has been killed by {attacker}!");
                            heroes.Remove(curHero);
                        }
                        break;
                    case "Recharge":
                        int amountMpToRecharge = int.Parse(info[2]);
                        int amountMpBeforeHeal = curHero.MP;
                        
                        curHero.MP = Math.Min((curHero.MP + amountMpToRecharge), HERO_MAX_MP);
                        int amountRecharged = curHero.MP - amountMpBeforeHeal;
                        
                            Console.WriteLine($"{curHero.Name} recharged for {amountRecharged} MP!");
                        break;
                    case "Heal":
                        int amountHpToHeal = int.Parse(info[2]);
                        int hpBeforeHeal = curHero.HP;
                        
                        curHero.HP = Math.Min((curHero.HP + amountHpToHeal), HERO_MAX_HP);
                        int amountHealed = curHero.HP - hpBeforeHeal;
                        
                        Console.WriteLine($"{curHero.Name} healed for {amountHealed} HP!");
                        break;
                }
            }
            foreach (var aliveHeroes in heroes)
            {
                Console.WriteLine(aliveHeroes.Name);
                Console.WriteLine($"  HP: {aliveHeroes.HP}");
                Console.WriteLine($"  MP: {aliveHeroes.MP}");
            }
        }
    }
}
