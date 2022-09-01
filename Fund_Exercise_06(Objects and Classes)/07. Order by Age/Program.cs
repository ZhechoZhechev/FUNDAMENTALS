using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Order_by_Age
{
    class Program
    {
        static void Main()
        {
            List<Person> people = new List<Person>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] personInfo = input.Split();
                string name = personInfo[0];
                string personID = personInfo[1];
                int age = int.Parse(personInfo[2]);
                bool ischanged = false;

                Person person = new Person(name, personID, age);

                foreach (var per in people)
                {
                    if (per.PersonsID == personID)
                    {
                        per.Name = name;
                        per.PersonsID = personID;
                        ischanged = true;
                    }
                }
                if (!ischanged)
                {
                    people.Add(person);
                }
            }
            foreach (var per in people.OrderBy(x => x.Age))
            {
                Console.WriteLine(per);
            }
        }
    }

    class Person
    {
        public Person(string name, string personsID, int age)
        {
            Name = name;
            PersonsID = personsID;
            Age = age;
        }
        public string Name { get; set; }
        public string PersonsID { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Name} with ID: {PersonsID} is {Age} years old.";
        }
    }
}
