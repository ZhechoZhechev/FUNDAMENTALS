using System;
using System.Collections.Generic;
using System.Linq;

namespace _21.Dragon_Army
{
    class Dragons
    {
        public Dragons(string type, string name, int damage, int health, int armour)
        {
            Type = type;
            Name = name;
            Damage = damage;
            Health = health;
            Armour = armour;
        }
        public string Type { get; set; }
        public string Name { get; set; }
        public int Damage { get; set; }
        public int Health { get; set; }
        public int Armour { get; set; }
    }
    class Program
    {
        static void Main()
        {
            List<Dragons> army = new List<Dragons>();
            
            const int HEALTH = 250;
            const int DAMAGE = 45;
            const int ARMOUR = 10;

            int dragonsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < dragonsCount; i++)
            {
                var dragonsInfo = Console.ReadLine().Split();

                string dragonType = dragonsInfo[0];
                string dragonName = dragonsInfo[1];
                var dragonDamage = dragonsInfo[2] == "null" ? DAMAGE : int.Parse(dragonsInfo[2]);
                var dragonHealth = dragonsInfo[3] == "null" ? HEALTH : int.Parse(dragonsInfo[3]);
                var dragonArmor = dragonsInfo[4] == "null" ? ARMOUR : int.Parse(dragonsInfo[4]);

                if (!army.Any(x => x.Type == dragonType && x.Name == dragonName ))
                {
                    Dragons dragong = new Dragons(dragonType, dragonName, dragonDamage, dragonHealth, dragonArmor);
                }
                else
                {
                    var curDragon = army.FirstOrDefault(x => x.Name == dragonName);
                    curDragon.Damage = dragonDamage;
                    curDragon.Health = dragonHealth;
                    curDragon.Armour = dragonArmor;
                }
            }
            foreach (var item in army)
            {
                double avDamage = 1.00 * (army.Select(x => x.Type.Average( / item.Type.Count;
                double avHealth = 1.00 * (type.Value.Values.Select(x => x[1]).Sum()) / item.Type.Count;
                double avArmor = 1.00 * (type.Value.Values.Select(x => x[2]).Sum()) / item.Type.Count;
            }
        }
    }
}
