using System;
using System.Collections.Generic;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            var carros = new List<Carro>()
            {
                new Gol(),
                new GolRallye()

            };

            foreach (var item in carros)
            {
                Console.WriteLine("modelo: {0}, ano: {1}" ,item.modelo, item.ano);
                item.AumentarAno(1);
                Console.WriteLine("modelo: {0}, ano: {1}" ,item.modelo, item.ano);
            }          
           
            Console.ReadKey();
        }
    }
}
