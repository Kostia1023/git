using System;
using System.Linq;
using System.Xml.Serialization;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace Lab_4_var18_lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("read/write/filter");
                string command = Console.ReadLine();
                Console.WriteLine("Json/XML");
                string type = Console.ReadLine();
                type = type.ToLower();
                if (type == "json")
                {
                    switch (command.ToLower())
                    {
                        case "read":
                            ReadJsonAsync();
                            break;
                        case "write":
                            WriteJsonAsync();
                            break;
                        case "filter":
                            Console.Write("gender(male/woman): ");
                            FilterJsonAsync(Console.ReadLine().ToLower());
                            break;
                        default:
                            Console.WriteLine("Incorrect command");
                            break;
                    }
                    continue;

                }
                if (type == "xml")
                {
                    switch (command.ToLower())
                    {
                        case "read":
                            ReadXMLAsync();
                            break;
                        case "write":
                            WriteXMLAsync();
                            break;
                        case "filter":
                            Console.Write("gender(male/woman): ");
                            FilterXMLAsync(Console.ReadLine().ToLower());
                            break;
                        default:
                            Console.WriteLine("Incorrect command");
                            break;
                    }
                    continue;
                }

                Console.WriteLine("Incorrect type");


            }
            async void ReadJsonAsync()
            {
                using StreamReader fs = new StreamReader("../../../Data.json");
                List<Person> list = JsonConvert.DeserializeObject<List<Person>>(await fs.ReadToEndAsync());
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
            }


            async void ReadXMLAsync()
            {
                XmlSerializer formatter = new XmlSerializer(typeof(List<Person>));
                using FileStream fs = new FileStream("../../../Data.xml", FileMode.Open, FileAccess.Read);
                List<Person> list = (List<Person>) await Task.Run(()=>formatter.Deserialize(fs));
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
            }

            async void WriteJsonAsync()
            {
                List<Person> personList = new List<Person> {
                    new Person
                    {
                        Name = "Person1",
                        Gender="male",
                        YearBirth = 1999,
                        Schooling = "schooling1",
                        DateAppcent = DateTime.Now
                    },
                    new Person
                    {
                        Name = "Person2",
                        Gender="woman",
                        YearBirth = 1999,
                        Schooling = "schooling2",
                        DateAppcent = DateTime.Now
                    },
                    new Person
                    {
                        Name = "Person3",
                        Gender="male",
                        YearBirth = 1999,
                        Schooling = "schooling3",
                        DateAppcent = DateTime.Now
                    },
                    new Person
                    {
                        Name = "Person4",
                        Gender="woman",
                        YearBirth = 1999,
                        Schooling = "schooling4",
                        DateAppcent = DateTime.Now
                    },
                    new Person
                    {
                        Name = "Person5",
                        Gender="male",
                        YearBirth = 1999,
                        Schooling = "schooling5",
                        DateAppcent = DateTime.Now
                    },
                };

                using StreamWriter fs = new StreamWriter("../../../Data.json");
                string jsonText = JsonConvert.SerializeObject(personList, Formatting.Indented);
                await fs.WriteAsync(jsonText);
                Console.WriteLine("Created");
            }

            async void WriteXMLAsync()
            {
                List<Person> personList = new List<Person> {
                    new Person
                    {
                        Name = "Person1",
                        Gender="male",
                        YearBirth = 1999,
                        Schooling = "schooling1",
                        DateAppcent = DateTime.Now
                    },
                    new Person
                    {
                        Name = "Person2",
                        Gender="woman",
                        YearBirth = 1999,
                        Schooling = "schooling2",
                        DateAppcent = DateTime.Now
                    },
                    new Person
                    {
                        Name = "Person3",
                        Gender="male",
                        YearBirth = 1999,
                        Schooling = "schooling3",
                        DateAppcent = DateTime.Now
                    },
                    new Person
                    {
                        Name = "Person4",
                        Gender="woman",
                        YearBirth = 1999,
                        Schooling = "schooling4",
                        DateAppcent = DateTime.Now
                    },
                    new Person
                    {
                        Name = "Person5",
                        Gender="male",
                        YearBirth = 1999,
                        Schooling = "schooling5",
                        DateAppcent = DateTime.Now
                    },
                };
                XmlSerializer formatter = new XmlSerializer(typeof(List<Person>));

                using FileStream fs = new FileStream("../../../Data.xml", FileMode.Create, FileAccess.Write);
                await Task.Run(()=> formatter.Serialize(fs, personList));
                Console.WriteLine("Created");
            }

            async void FilterJsonAsync(string gender)
            {
                List<Person> personList = new List<Person>();

                using (StreamReader fs = new StreamReader("../../../Data.json"))
                {
                    personList = JsonConvert.DeserializeObject<List<Person>>(await fs.ReadToEndAsync());
                }
                Console.WriteLine("Readed");

                var filterPersonList = personList.Where((person) => person.Gender == gender);

                Console.WriteLine("Filtered");

                using (StreamWriter fs = new StreamWriter("../../../Data.json"))
                {
                    string jsonText = JsonConvert.SerializeObject(filterPersonList.ToList<Person>(), Formatting.Indented);
                    await fs.WriteAsync(jsonText);
                }

                Console.WriteLine("Writed");
            }

            async void FilterXMLAsync(string gender)
            {
                List<Person> personList = new List<Person>();
                XmlSerializer formatter = new XmlSerializer(typeof(List<Person>));

                using (FileStream fs = new FileStream("../../../Data.xml", FileMode.Open, FileAccess.Read))
                {
                    personList = (List<Person>)await Task.Run(() => formatter.Deserialize(fs));
                }
                Console.WriteLine("Readed");

                var filterPersonList = personList.Where((person) => person.Gender == gender);

                Console.WriteLine("Filtered");

                using (FileStream fs = new FileStream("../../../Data.xml", FileMode.Create, FileAccess.Write))
                {
                    await Task.Run(() => formatter.Serialize(fs, filterPersonList.ToList<Person>()));
                }

                Console.WriteLine("Writed");
            }
        }
    }
}
