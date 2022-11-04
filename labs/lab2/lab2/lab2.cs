using System;

namespace lab2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ZVO zvo = new ZVO();
            Worker worker1 = new Worker("name1", "position1" );
            Worker worker2 = new Worker("name2", "position2" );
            Worker worker3 = new Worker("name3", "position3" );
            Worker worker4 = new Worker("name4", "position4" );
            StructuralUnit structuralUnit1 = new StructuralUnit("Structural1");
            StructuralUnit structuralUnit2 = new StructuralUnit("Structural2");
            StructuralUnit structuralUnit3 = new StructuralUnit("Structural3");
            structuralUnit1.addWorker(worker1);
            structuralUnit2.addWorker(worker2);
            structuralUnit2.addWorker(worker3);
            structuralUnit3.addWorker(worker4);
            structuralUnit1.addStructuralUnit(structuralUnit2);
            structuralUnit1.addStructuralUnit(structuralUnit3);
            zvo.addStructuralUnit(structuralUnit1);
            Console.WriteLine(zvo.StructuralUnits[0].name);
            Console.WriteLine(zvo.StructuralUnits[0].StructuralUnits[0].name);
            Console.WriteLine(zvo.StructuralUnits[0].StructuralUnits[1].name);
        }
    }
}