namespace lab1
{
    public class UnderwaterItem : AbstractItem
    {
        public UnderwaterTypeItem type;
        public override string ShowType()
        {
            return type.ToString();
        }
    }
}