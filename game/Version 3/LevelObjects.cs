using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Version_3
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



        public FiguresPoints[] SpecialCubeList;

        private int numberSpecialCube;
        public int NumberSpecialCube
        {
            get
            {
                return numberSpecialCube;
            }
            set
            {
                if (value < 0 || value > MaxNumberSpecialCube) throw new Exception("eror");
                numberSpecialCube = value;
            }
        }

        private int maxNumberSpecialCube;
        public int MaxNumberSpecialCube
        {
            get
            {
                return maxNumberSpecialCube;
            }
            set
            {
                if (value < 0) throw new Exception("eror");
                maxNumberSpecialCube = value;
            }
        }




        public FiguresPoints[] SpecialUnbreakableCubeList;

        private int numberUnbreakableSpecialCube;
        public int NumberUnbreakableSpecialCube
        {
            get
            {
                return numberUnbreakableSpecialCube;
            }
            set
            {
                if (value < 0 || value > MaxNumberUnbreakableSpecialCube) throw new Exception("eror");
                numberUnbreakableSpecialCube = value;
            }
        }

        private int maxNumberUnbreakableSpecialCube;
        public int MaxNumberUnbreakableSpecialCube
        {
            get
            {
                return maxNumberUnbreakableSpecialCube;
            }
            set
            {
                if (value < 0) throw new Exception("eror");
                maxNumberUnbreakableSpecialCube = value;
            }
        }



        public FiguresPoints[] HeartList;

        private int numberHeart;
        public int NumberHeart
        {
            get
            {
                return numberHeart;
            }
            set
            {
                if (value < 0 || value > MaxNumberHeart) throw new Exception("eror");
                numberHeart = value;
            }
        }

        private int maxNumberHeart;
        public int MaxNumberHeart
        {
            get
            {
                return maxNumberHeart;
            }
            set
            {
                if (value < 0) throw new Exception("eror");
                maxNumberHeart = value;
            }
        }


        public FiguresPoints[] StarList;

        private int numberStar;
        public int NumberStar
        {
            get
            {
                return numberStar;
            }
            set
            {
                if (value < 0 || value > MaxNumberStar) throw new Exception("eror");
                numberStar = value;
            }
        }

        private int maxNumberStar;
        public int MaxNumberStar
        {
            get
            {
                return maxNumberStar;
            }
            set
            {
                if (value < 0) throw new Exception("eror");
                maxNumberStar = value;
            }
        }


        public FiguresPoints[] AllEnemiesList;

        public FiguresPoints[] AllSpecialCube;

        public FiguresPoints[] AllPlatformsList;

        public FiguresPoints WinObj;


        public LevelObjects(int enemies, int platforms, int staticEnemies, int checkPoint, int special, int specialUnbr, int heart, int star, FiguresPoints Win)
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

            maxNumberSpecialCube = special;
            SpecialCubeList = new FiguresPoints[special];
            NumberSpecialCube = 0;

            maxNumberUnbreakableSpecialCube = specialUnbr;
            SpecialUnbreakableCubeList = new FiguresPoints[specialUnbr];
            NumberUnbreakableSpecialCube = 0;

            MaxNumberHeart = heart;
            HeartList = new FiguresPoints[heart];
            NumberHeart = 0;

            MaxNumberStar = star;
            StarList = new FiguresPoints[star];
            NumberStar = 0;


            AllSpecialCube = new FiguresPoints[special + specialUnbr];

            AllPlatformsList = new FiguresPoints[platforms + special + specialUnbr];

            AllEnemiesList = new FiguresPoints[enemies + staticEnemies];

            WinObj = Win;
        }

        public void AddEnemy(Enemy Enemy)
        {
            EnemiesList[NumberEnemies] = Enemy;
            (EnemiesList[NumberEnemies] as FigureWithoutPhysics).picture.BringToFront();
            NumberEnemies++;
        }
        public void AddPlatforms(FiguresPoints platforms)
        {
            PlatformsList[NumberPlatforms] = platforms;
            (PlatformsList[NumberPlatforms] as FigureWithoutPhysics).picture.BackgroundImageLayout = ImageLayout.Tile;
            (PlatformsList[NumberPlatforms] as FigureWithoutPhysics).picture.BackgroundImage = Image.FromFile("../../img/UnbreakerBreak.png");
            (PlatformsList[NumberPlatforms] as FigureWithoutPhysics).picture.BringToFront();
            NumberPlatforms++;
        }
        public void AddStaticEnemy(FiguresPoints Enemy)
        {
            StaticEnemiesList[staticEnemies] = Enemy;
            (StaticEnemiesList[staticEnemies] as FigureWithoutPhysics).picture.BringToFront();
            StaticEnemies++;
        }
        public void AddCheckPoints(FiguresPoints CheckPoint)
        {
            CheckPointsList[NumberCheckpoints] = CheckPoint;
            (CheckPointsList[NumberCheckpoints] as FigureWithoutPhysics).picture.BringToFront();
            NumberCheckpoints++;
        }
        public void AddSpecialCube(FiguresPoints Special)
        {
            SpecialCubeList[NumberSpecialCube] = Special;
            (SpecialCubeList[NumberSpecialCube] as FigureWithoutPhysics).picture.BringToFront();
            NumberSpecialCube++;
        }

        public void AddHeart(FiguresPoints heart)
        {
            HeartList[NumberHeart] = heart;
            (HeartList[NumberHeart] as FigureWithoutPhysics).picture.BringToFront();
            NumberHeart++;
        }
        public void AddStar(FiguresPoints star)
        {
            StarList[NumberStar] = star;
            (StarList[NumberStar] as FigureWithoutPhysics).picture.BringToFront();
            NumberStar++;
        }
        public void AddSpecialUnbreakableCube(FiguresPoints Special)
        {
            SpecialUnbreakableCubeList[NumberUnbreakableSpecialCube] = Special;
            (SpecialUnbreakableCubeList[NumberUnbreakableSpecialCube] as FigureWithoutPhysics).picture.BringToFront();
            NumberUnbreakableSpecialCube++;
        }

        public FiguresPoints[] Enemie()
        {
            FiguresPoints[] figures = new FiguresPoints[NumberEnemies];
            for (int i = 0; i < NumberEnemies; i++)
            {
                figures[i] = EnemiesList[i];
            }
            return figures;
        }


        public FiguresPoints[] AllEnemies()
        {
            StaticEnemiesList.CopyTo(AllEnemiesList, 0);
            EnemiesList.CopyTo(AllEnemiesList, MaxStaticEnemies);
            return AllEnemiesList;
        }


        public FiguresPoints[] AllPlatforms()
        {
            PlatformsList.CopyTo(AllPlatformsList, 0);
            SpecialCubeList.CopyTo(AllPlatformsList, MaxNumberPlatforms);
            SpecialUnbreakableCubeList.CopyTo(AllPlatformsList, MaxNumberPlatforms + maxNumberSpecialCube);
            return AllPlatformsList;
        }
    }
}
