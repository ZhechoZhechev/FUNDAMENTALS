using System;
using System.Collections.Generic;
using System.Linq;

namespace _20.Snowwhite
{

    class Dwarfs 
    {
        public string Name { get; set; }
        public string HatColour { get; set; }
        public int Physics { get; set; }
    }
    class Program
    {
        static void Main()
        {
            string input = string.Empty;

            List<Dwarfs> dwarfs = new List<Dwarfs>();

            while ((input = Console.ReadLine()) != "Once upon a time")
            {
                var dwarfsInfo = input.Split(" <:> ");
                string dwarfName = dwarfsInfo[0];
                string dwarfHat = dwarfsInfo[1];
                int dwarfPhysic = int.Parse(dwarfsInfo[2]);

                if (!dwarfs.Any(x => x.Name == dwarfName && x.HatColour == dwarfHat))
                {
                    Dwarfs dwarf = new Dwarfs
                    {
                        Name = dwarfName,
                        HatColour = dwarfHat,
                        Physics = dwarfPhysic
                    };
                    dwarfs.Add(dwarf);
                }
                else
                {
                    var curDwarf = dwarfs.FirstOrDefault(x => x.Name == dwarfName);
                    curDwarf.Physics = Math.Max(curDwarf.Physics, dwarfPhysic);
                }
                
            }
            foreach (var dwarf in dwarfs.OrderByDescending(x => x.Physics).ThenByDescending(x => dwarfs.Count(y => y.HatColour == x.HatColour)))
            {
                Console.WriteLine($"({dwarf.HatColour}) {dwarf.Name} <-> {dwarf.Physics}");
            }
        }
    }
}
