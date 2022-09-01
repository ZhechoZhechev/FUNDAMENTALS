using System;
using System.Linq;

namespace _09._Pokemon_Don_t_Go
{
    class Program
    {
        static void Main()
        {
            var pokemonsList = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int sum = 0;
            int currentValue = 0;
            while (pokemonsList.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());
                if (index >= 0 && index <= pokemonsList.Count - 1)
                {
                    currentValue = pokemonsList[index];
                    sum += currentValue;
                    pokemonsList.RemoveAt(index);

                }
                else if (index < 0)
                {
                    currentValue = pokemonsList[0];
                    sum += currentValue;
                    pokemonsList[0] = pokemonsList[pokemonsList.Count - 1];

                }
                else if (index > pokemonsList.Count - 1)
                {
                    currentValue = pokemonsList[pokemonsList.Count - 1];
                    sum += currentValue;
                    pokemonsList[pokemonsList.Count - 1] = pokemonsList[0];
                }
                for (int i = 0; i < pokemonsList.Count; i++)
                {
                    if (pokemonsList[i] <= currentValue)
                    {
                        pokemonsList[i] += currentValue;
                    }
                    else
                    {
                        pokemonsList[i] -= currentValue;
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
