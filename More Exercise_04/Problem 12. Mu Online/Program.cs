using System;

namespace Problem_12._Mu_Online
{
    class Program
    {
        static void Main()
        {
            var sequence = Console.ReadLine().Split("|");
            int bitcoin = 0;
            int health = 100;
            const int MAX_HEALTH = 100;

            for (int room = 0; room < sequence.Length; room++)
            {
                var actions = sequence[room].Split();
                string command = actions[0];

                switch (command)
                {
                    case "potion":
                        int potionValue = int.Parse(actions[1]);

                        if (potionValue + health > MAX_HEALTH)
                        {
                            potionValue = MAX_HEALTH - health;
                            health += potionValue;
                        }
                        else
                        {
                            health += potionValue;
                        }
                        Console.WriteLine($"You healed for {potionValue} hp.");
                        Console.WriteLine($"Current health: {health} hp.");
                        break;
                    //HealMeUp(actions, health, MAX_HEALTH);
                    case "chest":
                        int bitCoinInChest = int.Parse(actions[1]);
                        bitcoin += bitCoinInChest;
                        Console.WriteLine($"You found {bitCoinInChest} bitcoins.");
                        break;
                        //FoundBitcoins(actions, bitcoin);
                    default:
                        string monster = actions[0];
                        int monsterAttack = int.Parse(actions[1]);

                        health -= monsterAttack;
                        if (health > 0)
                        {
                            Console.WriteLine($"You slayed {monster}.");
                        }
                        else
                        {
                            Console.WriteLine($"You died! Killed by {monster}.");
                            Console.WriteLine($"Best room: {room + 1}");
                            return;
                        }
                        break;
                        //FightAMonster(actions, health, room);
                }
            }
            Console.WriteLine($"You've made it!");
            Console.WriteLine($"Bitcoins: {bitcoin}");
            Console.WriteLine($"Health: {health}");
        }

        //private static void FightAMonster(string[] actions, int health, int room)
        //{
        //    string monster = actions[0];
        //    int monsterAttack = int.Parse(actions[1]);

        //    health -= monsterAttack;
        //    if (health > 0)
        //    {
        //        Console.WriteLine($"You slayed {monster}.");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"You died! Killed by {monster}.");
        //        Console.WriteLine($"Best room: {room + 1}");
        //    }

        //}

        //private static void FoundBitcoins(string[] actions, int bitcoin)
        //{
        //    int bitCoinInChest = int.Parse(actions[1]);
        //    bitcoin += bitCoinInChest;
        //    Console.WriteLine($"You found {bitCoinInChest} bitcoins.");
        //}

        //private static void HealMeUp(string[] actions, int health, int mAX_HEALTH)
        //{
        //    int potionValue = int.Parse(actions[1]);

        //    if (potionValue + health > mAX_HEALTH)
        //    {
        //        potionValue = mAX_HEALTH - health;
        //        health += potionValue;
        //    }
        //    else
        //    {
        //        health += potionValue; 
        //    }
        //    Console.WriteLine($"You healed for {potionValue} hp.");
        //    Console.WriteLine($"Current health: {health} hp.");
        //}
    }
}
