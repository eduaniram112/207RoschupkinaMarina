using System;

namespace Task02
{
    class Plant
    {
        int growth;
        int photosensitivity;
        int frostresistance;

        public Plant(int growth, int photosensitivity, int frostresistance)
        {
            this.growth = growth;
            this.photosensitivity = photosensitivity;
            this.frostresistance = frostresistance;
        }
        public int Growth => growth;
        public int Photo => photosensitivity;
        public int Frost => frostresistance;

        public override string ToString()
        {
            return "\nGrowth: " + growth + "\nPhoto sensitivity: " + photosensitivity + "\nFrost resistance: " + frostresistance;
        }
        
    }

    class Program
    {
        static int Comp(Plant a,Plant b)
        {
            if (a.Photo % 2 == 1 && b.Photo % 2 == 0) return 1;
            if (a.Photo % 2 == 0 && b.Photo % 2 == 1) return -1;
            else return 0;
        }

        static void Main(string[] args)
        {
            Random r = new Random();
            Plant[] garden = new Plant[10];
            for(int i = 0; i < garden.Length; i++)
            {
                garden[i] = new Plant(r.Next(25, 101), r.Next(0, 101), r.Next(0, 81));
            }
            Array.ForEach(garden, Console.WriteLine);

            Console.WriteLine("\nGrowth\n");
            Array.Sort(garden, delegate (Plant a, Plant b) //анонимный
            {
                if (a.Growth < b.Growth) return 1;
                if (a.Growth > b.Growth) return -1;
                else return 0;
            }
            );
            Array.ForEach(garden, Console.WriteLine);

            Console.WriteLine("\nFrost\n");
            Array.Sort(garden, (a, b) => //лямбда
            {
                if (a.Frost > b.Frost) return 1;
                if (a.Frost < b.Frost) return -1;
                else return 0;
            }
            );
            Array.ForEach(garden, Console.WriteLine);

            Console.WriteLine("\nPhoto\n");
            Array.Sort(garden, Comp); //самостоятельный метод
            Array.ForEach(garden, Console.WriteLine);
        }
    }
}
