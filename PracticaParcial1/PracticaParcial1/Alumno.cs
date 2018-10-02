using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParcial1
{
   public class Alumno:Persona
    {
        //atributos
        short anio;
        Divisiones division;

        //propiedades
        public string AnioDivision
        {
            get
            {
                StringBuilder retorno = new StringBuilder();
                retorno.AppendFormat("{0} º {1}", this.anio, this.division);
                return retorno.ToString();
            }
        }
        
        //constructor
        public Alumno(string nombre,string apellido, string documento,short anio, Divisiones division):base(nombre,apellido,documento)
        {
            this.anio = anio;
            this.division = division;
        }
        //metodos
        public override bool ValidarDocumentacion(string doc)
        {
            if (doc.Length == 9 && doc[2] == '-' && doc[7] == '-')
            {
                doc = doc.Replace("-", "");
                for (int i = 0; i < doc.Length; i++)
                {
                    if (doc[i] < '0' || doc[i] > '9')
                        return false;
                }
                return true;
            }
            return false;
        }
        public override string ExponerDatos()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.AppendFormat("{0},Anio Division: {1}", base.ExponerDatos(), AnioDivision);
            return retorno.ToString();
        }
    }
}
