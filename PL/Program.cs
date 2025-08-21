using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class Program
    {
        static void Main(string[] args)
        {
            ServicioOperaciones.Operaciones2Client cliente = new ServicioOperaciones.Operaciones2Client();

            var resulSum = cliente.Suma(5, 3);
            Console.WriteLine("El resultado de la suma es: " + resulSum + "\n");

            var resulRes = cliente.Resta(9, 6);
            Console.WriteLine("El resultado de la resta es: " + resulRes + "\n");

            var resulMul = cliente.Multiplicacion(9, 7);
            Console.WriteLine("El resultado de la multiplicacion es: " + resulMul + "\n");

            var resulDiv = cliente.Division(20, 4);
            Console.WriteLine("El resultado de la Division es: " + resulDiv + "\n");

            Console.ReadKey();
        }
    }
}
