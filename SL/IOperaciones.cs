using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SL
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IOperaciones  //Datos primitivos
    {

        [OperationContract]
        int Suma(int Numero1, int Numero2); //Firma de Método

        [OperationContract]
        int Resta(int Numero1, int Numero2); //Firma de Método

        [OperationContract]
        int Multiplicacion(int Numero1, int Numero2); //Firma de Método

        [OperationContract]
        decimal Division(decimal Numero1, decimal Numero2); //Firma de Método

    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
