using System;
using System.Linq;

namespace _02._Change_List
{
    class Program
    {
        static void Main()
        {
            var intigers = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                string[] commands = Console.ReadLine().Split();
                if (commands[0] == "end")
                {
                    break;
                }
                if (commands[0] == "Delete")
                {
                    int elementToDel = int.Parse(commands[1]);
                    intigers.RemoveAll(el => el == elementToDel);
                }
                if (commands[0] == "Insert")
                {
                    int elementToIns = int.Parse(commands[1]);
                    int index = int.Parse(commands[2]);
                    intigers.Insert(index, elementToIns);
                }

            }
            Console.WriteLine(string.Join(" ", intigers));
        }
    }
}
