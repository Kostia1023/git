using System;
using System.Collections;
using System.Collections.Generic;

namespace lab3
{
    public class HouseEnumeratorA :  IEnumerator<House>
    {
        private List<List<House>> Houses;
        int[] position = new []{-1, -1};
        public HouseEnumeratorA(List<List<House>> houses)
        {
            Houses = houses;
        }
        
        public bool MoveNext()
        {
            if (position[0] < Houses.Count && position[1] < Houses.Count - 1)
            {
                if (position[0] == -1)
                {
                    position[0] = 0;
                }
                position[1]++;
                return true;
            }

            if (position[0] < Houses.Count - 1 && position[1] < Houses.Count)
            {
                position[0]++;
                position[1] = 0;
                return true;
            }
            
            return false;
        }

        public void Reset()
        {
            this.position[0] = -1;
            this.position[1] = -1;
        }

        public House Current
        {
            get
            {
                if (position[0] == -1 || position[1] == -1 || position[0] >= Houses.Count || position[1] >= Houses[0].Count)
                    throw new ArgumentException();
                
                return Houses[position[0]][position[1]];
            }
        }

        object IEnumerator.Current => Current;

        public void Dispose()
        {
        }
    }
}