using System.Collections.Generic;
using System.Linq;

namespace lab2
{
    public class StructuralUnit
    {
        public string name;

        public List<StructuralUnit> StructuralUnits = new List<StructuralUnit>();
        public List<Worker> Workers = new List<Worker>();

        public StructuralUnit(string name)
        {
            this.name = name;
        }

        public void addStructuralUnit(StructuralUnit structuralUnit)
        {
            StructuralUnits.Add(structuralUnit);
        }

        public void removeStructuralUnit(StructuralUnit structuralUnit)
        {
            StructuralUnits.Remove(structuralUnit);
        }

        public void addWorker(Worker worker)
        {
            Workers.Add(worker);
        }

        public void removeWorker(Worker worker)
        {
            Workers.Remove(worker);
        }
    }
}