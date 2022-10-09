using System;

namespace lab1
{
    public class TerrestrialNPC : AbstractNPC 
    {
        public override string TakeItem(AbstractItem item)
        {
            return $"take a {item.ShowType()}";
        }
    }
}