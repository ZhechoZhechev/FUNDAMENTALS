using System;
using System.Collections.Generic;

namespace _04._SoftUni_Parking
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            Dictionary<string, string> parkingRegistraiotn = new Dictionary<string, string>();

            for (int i = 0; i < num; i++)
            {
                string[] commands = Console.ReadLine().Split();
                
                string action = commands[0];

                switch (action)
                {
                    case "register":
                        if (!parkingRegistraiotn.ContainsKey(commands[1])) 
                        {
                            parkingRegistraiotn.Add(commands[1], commands[2]);
                            Console.WriteLine($"{commands[1]} registered {commands[2]} successfully");
                        }
                        else Console.WriteLine($"ERROR: already registered with plate number {commands[2]}");
                        break;
                    case "unregister":
                        if (parkingRegistraiotn.ContainsKey(commands[1]))
                        {
                            parkingRegistraiotn.Remove(commands[1]);
                            Console.WriteLine($"{commands[1]} unregistered successfully");
                        }
                        else Console.WriteLine($"ERROR: user {commands[1]} not found");
                        break;
                }
                
            }
            foreach (KeyValuePair<string, string> user in parkingRegistraiotn)
                {
                    Console.WriteLine($"{user.Key} => {user.Value}");
                }
        }
    }
}
