using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fernanda.Lecina._2C
{
    public abstract class Mascota
    {
        private string nombre;
        private string raza;
        //propiedades
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }
        public string Raza
        {
            get
            {
                return this.raza;
            }
        }
        public Mascota(string nombre, string raza)
        {
            this.nombre = nombre;
            this.raza = raza;
        }
        protected virtual string DatosCompletos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("\"{0}{1}\"", Nombre, Raza);
            return sb.ToString();
;        }
        protected abstract string Ficha();
    }
}
