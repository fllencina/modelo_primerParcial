using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParcial1
{
    public class Curso
    {
        //atributos
        List<Alumno> alumnos;
        short anio;
        Divisiones division;
        Profesor profesor;
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
        //constructores
        private Curso()
        {
             alumnos = new List<Alumno>();
        }
        public Curso(short anio, Divisiones division,Profesor profesor):this()
        {
            this.anio = anio;
            this.division = division;
            this.profesor = profesor;
        }
        //sobrecargas
        public static explicit operator string (Curso c)
        {
            StringBuilder Datos = new StringBuilder();
            Datos.AppendFormat("Curso {0}\n", c.AnioDivision);
            foreach(Alumno a in  c.alumnos)
            {
                Datos.AppendFormat("{0}\n", a.ExponerDatos());
            }
            return Datos.ToString();
        }
        public static bool operator == (Curso c, Alumno a)
        {

                 if (a.AnioDivision == c.AnioDivision)      
                     return true;
            
            
            return false;
            
        }
        public static bool operator !=(Curso c, Alumno a)
        {
            return !(c == a);
        }
        public static Curso operator +(Curso c, Alumno a)
        {
            
            if (c==a)
            {
                 c.alumnos.Add(a); 
            }
            return c;
        }

    }
}
