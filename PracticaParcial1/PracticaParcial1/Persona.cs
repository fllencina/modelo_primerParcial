using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParcial1
{
    public enum Divisiones
    {
        A,
        B,
        C,
        D,
        E
    }
    public abstract class Persona
    {
        // atributos
        private string apellido;
        private string documento;
        private string nombre;
        //propiedades
        /// <summary>
        /// propiedad de solo lectura, retorna el apellido
        /// </summary>
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
        }
        //propiedades
        /// <summary>
        /// propiedad de lectura y escritura, ingresa o retorna el documento
        /// </summary>
        public string Documento
        {
            get
            {
                return this.documento;
            }
            set
            {
                if (ValidarDocumentacion(value))
                {
                    this.documento = value;
                }
            }
        }
        //propiedades
        /// <summary>
        /// propiedad de solo lectura, retorna el nombre
        /// </summary>
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }
        // constructor
        public Persona(string nombre,string apellido,string documento)
        {
            this.nombre = nombre;
            this.documento = documento;
            this.apellido = apellido;
        }
        //metodos
        public virtual string ExponerDatos()
        {
            StringBuilder Datos = new StringBuilder();
            Datos.AppendFormat("Apellido: {0},Nombre: {1},Documento: {2}",Apellido,Nombre,Documento);
            return Datos.ToString();
        }
        public abstract bool ValidarDocumentacion(string doc);
    }
}
