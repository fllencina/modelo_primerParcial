using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParcial1
{
    public class Profesor : Persona
    {
        //atributo
        DateTime fechaIngreso = new DateTime();

        //propiedades
        public int Antiguedad
        {
            get
            {
                DateTime fechaActual = DateTime.Now;
                TimeSpan retorno = fechaIngreso - fechaActual;
                int dias = (int)retorno.TotalDays;
                return dias;
            }
        }
        //constructores
        public Profesor(string nombre, string apellido, string documento) : base(nombre, apellido, documento)
        { }
        public Profesor(string nombre, string apellido, string documento, DateTime fechaIngreso) : base(nombre, apellido, documento)
        {
            this.fechaIngreso = fechaIngreso;
        }

        public override bool ValidarDocumentacion(string doc)
        {     
            if (doc.Length == 9)
            {
                for (int i = 0; i < doc.Length; i++)
                { 
                    if (int.TryParse(doc, out int resultado))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
public override string ExponerDatos()
{
    StringBuilder retorno = new StringBuilder();
    retorno.AppendFormat("{1}, {2}, Antiguedad en dias: {3}", base.ExponerDatos(), this.fechaIngreso, Antiguedad);
    return retorno.ToString();
}
    }
}
