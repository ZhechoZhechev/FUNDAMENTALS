using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Store_Boxes
{
    class Item
    {
        public Item(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
    class Box
    {
        public int SerialNum { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public decimal PriceForABox
        {
            get
            {
                return this.ItemQuantity * this.Item.Price;
            }
        }

    }
    class Program
    {
        static void Main()
        {
            string input = string.Empty;

            var boxes = new List<Box>();

            while ((input = Console.ReadLine()) != "end")
            {
                var data = input.Split().ToList();

                Box box = new Box
                {
                    SerialNum = int.Parse(data[0]),
                    Item = new Item(data[1], decimal.Parse(data[3])),
                    ItemQuantity = int.Parse(data[2])

                };
                boxes.Add(box);
            }
            List<Box> orderBoxes = boxes.OrderByDescending(box => box.PriceForABox).ToList();
            foreach (Box box in orderBoxes)
            {
                Console.WriteLine(box.SerialNum);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PriceForABox:f2}");
            }
        }
    }
}
