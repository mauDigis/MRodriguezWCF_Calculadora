using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SL
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Operaciones2" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Operaciones2.svc or Operaciones2.svc.cs at the Solution Explorer and start debugging.
    public class Operaciones2 : IOperaciones2
    {
        public int Suma(int Numero1, int Numero2)
        {
            return Numero1 + Numero2;
        }
        public int Resta(int Numero1, int Numero2)
        {
            return Numero1 - Numero2;
        }
        public int Multiplicacion(int Numero1, int Numero2)
        {
            return Numero1 * Numero2;
        }
        public decimal Division(decimal Numero1, decimal Numero2)
        {
            return Numero1 / Numero2;
        }
    }
}