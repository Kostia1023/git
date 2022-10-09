namespace lab1
{
    public abstract class AbstractNPC
    {
        public string name;
        public int x;
        public int y;
        public int hp;
        public abstract string TakeItem(AbstractItem item);
    }
}