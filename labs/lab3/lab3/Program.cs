using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace lab3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            CityA cityA = new CityA();
            for (int i = 0; i < 4; i++)
            {
                List<House> houses = new List<House>();
                for (int j = 0; j < 4; j++)
                {
                    houses.Add(new House((i+1) * 10 + j + 2, j));
                }
                cityA.Houses.Add(houses);
            }

            List<House> Houses = new List<House>();
            foreach (House house in cityA)
            {
                if (house.countResidents == 0)
                {
                    Houses.Add(house);
                }
            }

            foreach (House house in Houses)
            {
                Console.WriteLine(house.address);
            }
            
        }
    }
}