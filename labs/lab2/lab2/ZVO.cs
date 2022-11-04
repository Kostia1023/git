using System.Collections.Generic;

namespace lab2
{
    public class ZVO
    {
        public List<StructuralUnit> StructuralUnits = new List<StructuralUnit>();
        
        public void addStructuralUnit(StructuralUnit structuralUnit)
        {
            StructuralUnits.Add(structuralUnit);
        }

        public void removeStructuralUnit(StructuralUnit structuralUnit)
        {
            StructuralUnits.Remove(structuralUnit);
        }
    }
}