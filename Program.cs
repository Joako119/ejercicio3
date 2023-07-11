using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double grados;
            double radianes;
            double resultado;
            // cambios para probar
            Console.WriteLine("ingresar el valor en grados");
            grados= double.Parse(Console.ReadLine());

            if (grados > 0)
            {
                radianes = (0.0174532925);
                resultado = grados * radianes;
                Console.Write($"el valor en radianes es {resultado}");
            }
            else
            {
                Console.WriteLine("el valor debe ser mayor a 0.");
            }











        }
    }
}
