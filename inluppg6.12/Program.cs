using System;

namespace inluppg6_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv önskad höjd");
            RitaTriangel(int.Parse(Console.ReadLine()));
        }


        static void RitaTriangel(int h)
        {
            int levelSidobredd = h - 1;
            int levelBredd = 1;
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < levelSidobredd; j++)
                {
                    Console.Write(' ');
                }
                for (int k = 0; k < levelBredd; k++)
                {
                    Console.Write("*");
                }
                Console.Write('\n');
                levelBredd+=2;
                levelSidobredd--;
            }
        }
    }
}