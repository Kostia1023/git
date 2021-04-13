using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Version1
{
    class LevelObjects
    {
        public Enemy[] EnemiesList;
        
        private int numberEnemies;
        public int NumberEnemies
        {
            get
            {
                return numberEnemies;
            }
            set
            {
                if (value < 0 || value > MaxNumberEnemies) throw new Exception("eror");
                numberEnemies = value;
            }
        }
        
        private int maxNumberEnemies;
        public int MaxNumberEnemies
        {
            get
            {
                return maxNumberEnemies;
            }
            set
            {
                if (value < 0) throw new Exception("eror");
                maxNumberEnemies = value;
            }
        }


        public FiguresPoints[] StaticEnemiesList;

        private int staticEnemies;
        public int StaticEnemies
        {
            get
            {
                return staticEnemies;
            }
            set
            {
                if (value < 0) throw new Exception("eror");
                staticEnemies = value;
            }
        }

        private int maxStaticEnemies;
        public int MaxStaticEnemies
        {
            get
            {
                return maxStaticEnemies;
            }
            set
            {
                if (value < 0) throw new Exception("eror");
                maxStaticEnemies = value;
            }
        }


        public FiguresPoints[] PlatformsList;
        
        private int numberPlatforms;
        public int NumberPlatforms
        {
            get
            {
                return numberPlatforms;
            }
            set
            {
                if (value < 0 || value > MaxNumberPlatforms) throw new Exception("eror");
                numberPlatforms = value;
            }
        }

        private int maxNumberPlatforms;
        public int MaxNumberPlatforms
        {
            get
            {
                return maxNumberPlatforms;
            }
            set
            {
                if (value < 0) throw new Exception("eror");
                maxNumberPlatforms = value;
            }
        }

        public FiguresPoints[] AllEnemiesList;

        public FiguresPoints WinObj;


        public FiguresPoints[] CheckPointsList;

        private int numberCheckPoints;
        public int NumberCheckpoints
        {
            get
            {
                return numberCheckPoints;
            }
            set
            {
                if (value < 0 || value > MaxNumberCheckPoints) throw new Exception("eror");
                numberCheckPoints = value;
            }
        }

        private int maxNumberCheckPoints;
        public int MaxNumberCheckPoints
        {
            get
            {
                return maxNumberCheckPoints;
            }
            set
            {
                if (value < 0) throw new Exception("eror");
                maxNumberCheckPoints = value;
            }
        }


        public LevelObjects(int enemies, int platforms, int staticEnemies, int checkPoint, FiguresPoints Win)
        {
            MaxNumberEnemies = enemies;
            EnemiesList = new Enemy[enemies];
            NumberEnemies = 0;

            MaxNumberPlatforms = platforms;
            PlatformsList = new FiguresPoints[platforms];
            numberPlatforms = 0;

            MaxStaticEnemies = staticEnemies;
            StaticEnemiesList = new FiguresPoints[staticEnemies];
            StaticEnemies = 0;

            MaxNumberCheckPoints = checkPoint;
            CheckPointsList = new FiguresPoints[checkPoint];
            NumberCheckpoints = 0;

            AllEnemiesList  = new FiguresPoints[enemies + staticEnemies];

            WinObj = Win;
        }

        public void AddEnemy(Enemy Enemy)
        {
            EnemiesList[NumberEnemies] = Enemy;
            NumberEnemies++;
        }
        public void AddPlatforms(FiguresPoints platforms)
        {
            PlatformsList[NumberPlatforms] = platforms;
            NumberPlatforms++;
        }
        public void AddStaticEnemy(FiguresPoints Enemy)
        {
            StaticEnemiesList[staticEnemies] = Enemy;
            StaticEnemies++;
        }
        public void AddCheckPoints(FiguresPoints CheckPoint)
        {
            CheckPointsList[NumberCheckpoints] = CheckPoint;
            NumberCheckpoints++;
        }

        public FiguresPoints[] AllEnemies()
        {
            StaticEnemiesList.CopyTo(AllEnemiesList, 0);
            EnemiesList.CopyTo(AllEnemiesList, MaxStaticEnemies);
            return AllEnemiesList;
        }
    }
}
