using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SL
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IOperaciones2" in both code and config file together.
    [ServiceContract] //Define un contrato de servicio
    public interface IOperaciones2 //Una interfaz es un contrato
    {
        [OperationContract] //Operaciones que se hacen en el contrato
        int Suma(int Numero1, int Numero2); //Firma de Método

        [OperationContract]
        int Resta(int Numero1, int Numero2); //Firma de Método

        [OperationContract]
        int Multiplicacion(int Numero1, int Numero2); //Firma de Método

        [OperationContract]
        decimal Division(decimal Numero1, decimal Numero2); //Firma de Método
    }
}
