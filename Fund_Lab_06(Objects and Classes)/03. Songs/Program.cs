using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Songs
{
    class Song 
    {
        public Song(string typeList, string name, string time)
        {
            this.TypeList = typeList;
            this.Name = name;
            this.Time = time;
        }
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }

    class Program
    {
        static void Main()
        {
            int songsCount = int.Parse(Console.ReadLine());
            
            var songs = new List<Song>();

            for (int i = 0; i < songsCount; i++)
            {
                var data = Console.ReadLine().Split("_").ToList();

                Song song = new Song(data[0], data[1], data[2]);

                songs.Add(song);
            }
            string listType = Console.ReadLine();

            if (listType == "all")
            {
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (Song song in songs)
                {
                    if (listType == song.TypeList)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }
        }
    }
}
