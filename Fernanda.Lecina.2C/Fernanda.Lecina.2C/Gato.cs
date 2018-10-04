using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fernanda.Lecina._2C
{
    public class Gato:Mascota
    {
        public Gato(string nombre, string raza) : base(nombre, raza)
        { }
        public static bool operator ==(Gato g1, Gato g2)
        {
            if (g1.Nombre == g2.Nombre && g1.Raza == g2.Raza)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Gato g1, Gato g2)
        {
            return !(g1 == g2);
        }
        protected override string Ficha()
        {
            StringBuilder sb = new StringBuilder();
            
                sb.AppendFormat("{0}{1}", this.Nombre, this.Raza);
           
            return sb.ToString();
        }
        public override bool Equals(object obj)
        {
            if (obj is Gato)
            {
                return ((Gato)obj == this);
            }
            return false;
        }
        public override string ToString()
        {
            return Ficha();
        }
    }
}
