using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class progam
    {
        static void Main(string[] args)
        {
            int[] numeros = { 1, 5, 7, 3, 5, 9 };
            IEnumerable<int> valores = from n in numeros
                                       where n > 3 && n < 8
                                       select n;

            foreach (int num in valores)
                Console.WriteLine(num);

            Console.WriteLine("-----");

            string[] postres = { "Pie de limon", "pastel de limon", "helado de chocolate", "helado de" };

            IEnumerable<string> encontrados = from p in postres
                                              where p.Contains("limon")
                                              orderby p
                                              select p;
            foreach (string postre in encontrados)
                Console.WriteLine(postre);


            Console.WriteLine("-----");

            InformacionResultados(valores);
            Console.WriteLine("-----");
            InformacionResultados(encontrados);

        }

        static void InformacionResultados(object pResultados)
        {
            Console.WriteLine("Tipo {0}", pResultados.GetType().Name);
            Console.WriteLine("Location {0}", pResultados.GetType().Assembly.GetName().Name);
        }
    }
}