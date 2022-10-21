using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace idisposable
{
    internal class Program
    {
        static void Main(string[] args)
        {
           using (var ejemplo = new Ejemplo())
            {

            }//...
        }
    }
}
