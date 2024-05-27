using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServicioWeb_Biblioteca
{

    [ServiceContract]
    public interface IBiblioteca
    {
        [OperationContract]
        string Saluda(string nombre);

        [OperationContract]
        Persona Cumpleaños(Persona persona);

        [OperationContract]
        Persona Yo();


        [OperationContract]
        float PesoX(Persona persona, float v);
    }


    [DataContract]
    public class Persona
    {
        int edad = 20;
        string nombre = "Hello ";

        [DataMember]
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        [DataMember]
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
    }
}