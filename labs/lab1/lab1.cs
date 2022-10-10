using System;

namespace lab1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Розмір світу");
            int size = Convert.ToInt32(Console.ReadLine());
            TypeWorld typeWorld;
            while (true)
            {
                Console.WriteLine("Тип світу (Terrestrial/Underwater)");
                string type = Console.ReadLine();
                if (type == "Underwater")
                {
                    typeWorld = TypeWorld.Underwater;
                    break;
                }

                if (type == "Terrestrial")
                {
                    typeWorld = TypeWorld.Terrestrial;
                    break;
                }
            }
            
            Abstract_Factory factory = new Abstract_Factory();
            World world = factory.CreateWorld(typeWorld ,size);
            foreach (NPC_ITEM el in world.map)
            {
                if (el == null)
                {
                    Console.WriteLine('*');
                    continue;
                }
                Console.WriteLine(el.name);
            }
        }
    }
}