using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @struct
{
    class Program
    {
        public struct Rectangle
        {
            public int Width { get; set; }
            public int Height { get; set; }
            public int Xcoord { get; set; }
            public int Ycoord { get; set; }
        }

        public static void CheckDublicate(Rectangle[] massive)
        {
            int count = 0;
            for (int i = 1; i < massive.Length; i++)
            {
                if (massive[i-1].Equals(massive[i])) { count = count + 1; }
            }
            Console.WriteLine(count);
        }
            
        static void Main(string[] args)
        {
            Rectangle Rect = new Rectangle();
            Random rnd = new Random(10);
            Rectangle[] RectMass = new Rectangle[100];
            for (int i = 0; i < 99; i++)
            {
                RectMass[i] = new Rectangle {Height = rnd.Next(0, 3), Width = rnd.Next(0,3) };
            }
            //if struct, the method has found some(10 - 15 dublicats),
            //if class, the amount of dublicats is empty.
            CheckDublicate(RectMass);
            Console.ReadLine();
        }

    }
}
