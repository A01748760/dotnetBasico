using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inspecciontipos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var persona = new Persona();
            var t = persona.GetType();
            Console.WriteLine(t.FullName);
            Console.WriteLine(t.Name);
            Console.WriteLine(t.IsSealed);
            Console.WriteLine(t.IsAbstract);
            Console.WriteLine(t.IsClass);

            var metodos = t.GetMethods();
            foreach (var metodo in metodos)
            {
                if (metodo.Name == "Saludar")
                {
                    metodo.Invoke(persona, new[] { "Buenas buenas" });
                }
                Console.WriteLine(metodo.Name);
            }
            Console.WriteLine();
            Console.WriteLine();

            var propiedades = t.GetProperties();
            foreach (var propieda in propiedades)
            {
                Console.WriteLine(propieda.Name);
            }

            Console.WriteLine();
            Console.WriteLine();

            var campos = t.GetFields();
            foreach (var campo in campos)
            {
                Console.WriteLine(campo.Name);
            }

            Console.ReadLine();
        }
    }
    class Persona
    {
        public int numero;
        public int id { get; set; }
        public string name { get; set; }

        public void Saludar(string nombre)
        {
            Console.WriteLine($"Hola {nombre}");
        }
    }
}
