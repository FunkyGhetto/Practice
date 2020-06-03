using System;
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
            string result = Console.ReadLine();
            if (result == "1") 
            {
                Console.WriteLine("Du valgte Stein!");
                Console.ReadLine();
            }
            else if (result == "2")
            {  
                Console.WriteLine("Du valgte Saks!");
                Console.ReadLine();
            }  
            else if (result == "3")
            {
                Console.WriteLine("Du valgte Papir!");
                Console.ReadLine();
            }

        }
    }
}
