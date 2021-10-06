using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> personList = new List<Person> {
                    new Person
                    {
                        Name = "Person1",
                        Gender="male",
                        YearBirth = 2001,
                        Schooling = "schooling1",
                        DateAppcent = DateTime.Now
                    },
                    new Person
                    {
                        Name = "Person2",
                        Gender="female",
                        YearBirth = 1995,
                        Schooling = "schooling2",
                        DateAppcent = DateTime.Now
                    },
                    new Person
                    {
                        Name = "Person3",
                        Gender="male",
                        YearBirth = 1990,
                        Schooling = "schooling3",
                        DateAppcent = DateTime.Now
                    },
                    new Person
                    {
                        Name = "Person4",
                        Gender="female",
                        YearBirth = 1988,
                        Schooling = "schooling4",
                        DateAppcent = DateTime.Now
                    },
                    new Person
                    {
                        Name = "Person5",
                        Gender="male",
                        YearBirth = 2000,
                        Schooling = "schooling5",
                        DateAppcent = DateTime.Now
                    },
                };


            var list = personList.Where((person) => person.Gender == "male");

            WriteList(list.ToList<Person>());



            list = personList.Where((person) => person.Gender == "male")
                .OrderBy((person) => person.YearBirth)
                .Take(1);

            WriteList(list.ToList<Person>());

            var list2 = personList.GroupBy(person => person.Gender);

            foreach(var group in list2)
            {
                Console.WriteLine($"{group.Key} - {group.Count()}");
            }
            Console.WriteLine("----------------------------");


            List<Person> list3 = personList;
            list3.ForEach(person => person.YearBirth += 18);

            WriteList(list3);

            list = personList.OrderBy(person => person.YearBirth)
                .Skip(1);

            WriteList(list.ToList<Person>());

            Console.WriteLine($"All: {personList.All(person => person.Gender == "female")}");
            Console.WriteLine($"Any: {personList.Any(person => person.Gender == "male")}");
        }

        static void WriteList(List<Person> list)
        {
            int i = 0;

            foreach (Person person in list)
            {
                Console.WriteLine($"Person {++i}");
                Console.WriteLine($"   {person.Name}");
                Console.WriteLine($"   {person.Gender}");
                Console.WriteLine($"   {person.YearBirth}");
                Console.WriteLine($"   {person.Schooling}");
                Console.WriteLine($"   {person.DateAppcent}");
            }
            Console.WriteLine("----------------------------");
        }
    }

}
