using System;
using System.Text.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace JsonEjemplo
{
    public class Mascota
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public Type Type { get; set; }
    }
    public enum Type
    {
        Gato, Perro, Ave, Otros
    }

    class program
    {
        static void Main(string[] args)
        {
            var Mascota = new Mascota()
            {
                Nombre = " Ricardo perro",
                Edad = 7,
                Type = Type.Perro



            };
            var optios = new JsonSerializerOptions { WriteIndented = true };
            string Jsonstring = JsonSerializer.Serialize(Mascota, optios);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Jsonstring);
            Console.ReadKey();

        }

    }


}