using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace cargadinamicaensamblados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var assembly = Assembly.LoadFrom("Ensamblado dinamico.dll");
            var mitipo = assembly.GetType("MiTipo");
            var instancia = Activator.CreateInstance(mitipo);

            mitipo.GetField("numero").SetValue(instancia, 1500);

            Console.WriteLine(mitipo.GetField("numero").GetValue(instancia));
        }
    }
}
