using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matematickaVjezba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b; 
            double c;
            double d;
            double x;

            Console.WriteLine("Unesite četiri broja: ");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());   
            c = Convert.ToDouble(Console.ReadLine());   
            d = Convert.ToDouble(Console.ReadLine());   

            x = Math.Pow(a, 2) + Math.Pow(b, 2) + Math.Pow(c, 2) + Math.Pow(d, 2)/ Math.Pow(a + b, 2) + Math.Pow(c + d, 2);
            Console.WriteLine("Zadatak: Math.Pow(a, 2) + Math.Pow(b, 2) + Math.Pow(c, 2) + Math.Pow(d, 2)/ Math.Pow(a + b, 2) + Math.Pow(c + d, 2)");
            Console.WriteLine("Rezultat je: " + x);




            Console.ReadKey();
        }
    }
}
