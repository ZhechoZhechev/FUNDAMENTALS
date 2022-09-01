using System;
using System.Linq;

namespace Problem_5___Shoot_for_the_Win
{
    class Program
    {
        static void Main()
        {
            var sequenceOfTargets = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input = string.Empty;
            int targetsShoot = 0;

            while ((input = Console.ReadLine()) != "End")
            {
                int index = int.Parse(input);
                
                if (index < 0 || index > sequenceOfTargets.Count - 1) continue;
                
                int targetBackup = sequenceOfTargets[index];
                    
                if (sequenceOfTargets[index] != -1 )
                {
                    sequenceOfTargets[index] = -1;
                    targetsShoot++;
                    
                    for (int i = 0; i <= sequenceOfTargets.Count - 1; i++)
                    {
                        if (sequenceOfTargets[i] == sequenceOfTargets[index]) continue;
                       
                        if (sequenceOfTargets[i] > targetBackup)
                        {
                            sequenceOfTargets[i] -= targetBackup;
                        }
                        else
                        {
                            sequenceOfTargets[i] += targetBackup;
                        }
                    }
                }
            }
            Console.WriteLine($"Shot targets: {targetsShoot} -> {string.Join(" ", sequenceOfTargets)}");
        }
    }
}
