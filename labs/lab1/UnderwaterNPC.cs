namespace lab1
{
    public class UnderwaterNPC : AbstractNPC
    {
        public override string TakeItem(AbstractItem item)
        {
            return $"take a {item.ShowType()}";
        }
    }
}