using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Xml;

namespace SteinSaksPapir
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Alternativer: \n" +
                "1) Stein \n" +
                "2) Saks \n" +
                "3) Papir");
            Console.Write("Stein, Saks, PAPIR! : ");
            SteinSaksPapir();
        }
        private static void SteinSaksPapir()
        {
            int intTemp = Convert.ToInt32(Console.ReadLine());

            RanInt generator = new RanInt();
            int rand = generator.RandomNumber(1, 3);

            if (intTemp == 1)
            {
                if (rand == 1)
                {
                    Console.WriteLine("Uavgjort! Begge valgte Stein");
                    Console.ReadLine();
                }
                else if (rand == 2)
                {
                    Console.WriteLine("Du vant! Stein slår Saks");
                    Console.ReadLine();
                }
                else if (rand == 3)
                {
                    Console.WriteLine("Du tapte! Papir slår Stein");
                    Console.ReadLine();
                }
            }
            if (intTemp == 2)
            {
                if (rand == 2)
                {

                    Console.WriteLine("Uavgjort! Begge valgte Saks");
                    Console.ReadLine();
                }
                else if (rand == 3)
                {
                    Console.WriteLine("Du vant! Saks slår Papir");
                    Console.ReadLine();
                }
                else if (rand == 1)
                {
                    Console.WriteLine("Du tapte! Stein slår Saks");
                    Console.ReadLine();
                }
            }
            if (intTemp == 3)
            {
                if (rand == 3)
                {

                   Console.WriteLine("Uavgjort! Begge valgte Papir");
                   Console.ReadLine();
                }
                else if (rand == 1)
                {
                    Console.WriteLine("Du vant! Papir slår Stein");
                    Console.ReadLine();
                }
                else if (rand == 2)
                {
                    Console.WriteLine("Du tapte! Saks slår Papir");
                    Console.ReadLine();
                }
            }
        }
        public class RanInt
        {
        public int RandomNumber(int min, int max)
            {
                Random random = new Random();
                return random.Next(min, max);
            }
        }
    }
}
