using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServicioWeb_Biblioteca
{
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple, InstanceContextMode = InstanceContextMode.Single)]
    public class Biblioteca : IBiblioteca
    {
        int numsaludos = 0;

        public string Saluda(string nombre)
        {
            lock (this) { numsaludos++; }
            string saludo = "Hola, " + nombre + "!";
            Console.WriteLine("Saludos #{0}: " + saludo, numsaludos);
            return saludo;
        }

        public Persona Cumpleaños(Persona persona)
        {
            persona.Edad++;
            return persona;
        }

        public Persona Yo()
        {
            Persona X = new Persona();
            X.Edad = 46;
            X.Nombre = "JMMR";
            return X;
        }

        public float PesoX(Persona persona, float v)
        {
            return persona.Edad * v / 115.5f;
        }
    }
}
