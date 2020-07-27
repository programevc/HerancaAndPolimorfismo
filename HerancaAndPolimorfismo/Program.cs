using System;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            var Gol = new Gol();
            Console.WriteLine(Gol.modelo);
            Console.WriteLine(Gol.ano);
            Gol.Fabricar();
            Console.WriteLine(Gol.ano);

            var GolRallye = new GolRallye();
            Console.WriteLine(GolRallye.modelo);
            Console.WriteLine(GolRallye.ano);
            GolRallye.Fabricar();
            Console.WriteLine(GolRallye.ano);

            Console.ReadKey();
        }
    }
}
