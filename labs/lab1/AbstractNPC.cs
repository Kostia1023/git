namespace lab1
{
    public abstract class AbstractNPC : NPC_ITEM
    {
        public int x;
        public int y;
        public int hp;
        public abstract string TakeItem(AbstractItem item);
    }
}