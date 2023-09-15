using System;
namespace Uppgift2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur långt hoppade Elin?");
            string x = Console.ReadLine();
            int y = Convert.ToInt32(x);
            Console.Clear();
            Console.WriteLine("Hur långt hoppade Alma?");
            string a = Console.ReadLine();
            int b = Convert.ToInt32(a);
            int dif = y - b; 
            Console.Clear();
            Console.WriteLine("Alma hoppade " + dif + " längre än Elin");
        }
    }
}