using System.Collections;
using System.Collections.Generic;

namespace lab3
{
    public class CityA : IEnumerable<House>
    {
        public List<List<House>> Houses = new List<List<House>>();
        public IEnumerator<House> GetEnumerator()
        {
            return new HouseEnumeratorA(Houses);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}