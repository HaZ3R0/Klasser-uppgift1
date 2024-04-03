using Klasser_uppgift1;
using System;
namespace klasserUppgift1
{
    class Program
    {
        static void Main(string[] args)
        {
            Bil p = new Bil ("Bmw", 1974, "blå", 6000, 4);

            Console.WriteLine(p.märke);
            Console.WriteLine(p.årsmodell);
            Console.WriteLine(p.färg);
            Console.WriteLine(p.mil);
            Console.WriteLine(p.däck);
        }
    }
}