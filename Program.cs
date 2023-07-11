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
            Double grados;
            Double radianes;
            Double resultado;
            Console.WriteLine("ingresar el valor en grados");
            grados= Double.Parse(Console.ReadLine());

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
