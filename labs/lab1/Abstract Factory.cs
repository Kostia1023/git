using System;

namespace lab1
{
    public class Abstract_Factory
    {
        private Random rnd;
        private int size;
        public World CreateWorld(TypeWorld typeWorld, int size)
        {
            rnd = new Random();
            this.size = size;
            if (typeWorld == TypeWorld.Terrestrial)
            {
                return TerrestrialWorld();
            }
            else
            {
                return UnderwaterWorld();
            }
        }

        public World TerrestrialWorld()
        {
            World world = new World();
            world.map = new NPC_ITEM[size, size];
            TerrestrialNPC terrestrialNpc = new TerrestrialNPC();
            terrestrialNpc.hp = rnd.Next(5, 10);
            terrestrialNpc.name = "npc1";
            terrestrialNpc.x = rnd.Next(0, size-1);
            terrestrialNpc.y = rnd.Next(0, size-1);
            world.map[terrestrialNpc.x, terrestrialNpc.y] = terrestrialNpc;
            TerrestrialItem terrestrialItem = new TerrestrialItem();
            terrestrialItem.type = TerrestrialTypeItem.Grass;
            terrestrialItem.x = rnd.Next(0, size-1);
            terrestrialItem.y = rnd.Next(0, size-1);
            terrestrialItem.name = "item1";
            world.map[terrestrialItem.x, terrestrialItem.y] = terrestrialItem;
            return world;
        }

        public World UnderwaterWorld()
        {
            World world = new World();
            world.map = new NPC_ITEM[size, size];
            UnderwaterNPC underwaterNpc = new UnderwaterNPC();
            underwaterNpc.hp = rnd.Next(5, 10);
            underwaterNpc.name = "npc1";
            underwaterNpc.x = rnd.Next(0, size-1);
            underwaterNpc.y = rnd.Next(0, size-1);
            world.map[underwaterNpc.x, underwaterNpc.y] = underwaterNpc;
            UnderwaterItem underwaterItem = new UnderwaterItem();
            underwaterItem.type = UnderwaterTypeItem.Algae;
            underwaterItem.x = rnd.Next(0, size-1);
            underwaterItem.y = rnd.Next(0, size-1);
            underwaterItem.name = "item1";
            world.map[underwaterItem.x, underwaterItem.y] = underwaterItem;
            return world;
        }
        
    }
}