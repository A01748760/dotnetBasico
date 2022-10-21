using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiposdinamicos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var c = new
            {
                Nombre = ".NET Basico",
                Autor = "David Rodriguez Fragoso",
                Descripcion = "Curso de .NET Basico"
            };
            Console.WriteLine(c.Nombre);
            Console.WriteLine(c.Autor);
            Console.WriteLine(c.Descripcion);

            Console.ReadLine();
        }
    }
}
