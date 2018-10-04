using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fernanda.Lecina._2C
{
    public class Perro : Mascota
    {
        private int edad;
        private bool esAlfa;

        //propiedades
        public int Edad
        {
            get
            {
                return this.edad;
            }
            set
            {
                this.edad = value;
            }
        }
        public bool EsAlfa
        {
            get
            {
                return this.esAlfa;
            }
            set
            {
                this.esAlfa = value;
            }
        }
        //constructores
        public Perro(string nombre, string raza, int edad, bool esAlpha) : this(nombre, raza)
        {
            Edad = edad;
            EsAlfa = EsAlfa;
        }
        public Perro(string nombre, string raza) : base(nombre, raza)
        {
            Edad = 0;
            EsAlfa = false;
        }
        protected override string Ficha()
        {
            StringBuilder sb = new StringBuilder();
            if (this.esAlfa == true)
            {
                sb.AppendFormat("{0}{1},{2},Edad {3}", this.Nombre, this.Raza, " alfa de la manada ", this.edad);
            }
            else
            {
                sb.AppendFormat("{0}{1}Edad {2}", this.Nombre, this.Nombre, this.edad);
            }
            return sb.ToString();
        }
        public static bool operator ==(Perro p1, Perro p2)
        {
            if (p1.Nombre == p2.Nombre && p1.edad == p2.edad && p1.Raza == p2.Raza)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Perro p1, Perro p2)
        {
            return !(p1 == p2);
        }
        public static explicit operator int(Perro perro)
        {
            return perro.edad;
        }
        public override bool Equals(object obj)
        {
            if(obj is Perro )
            {
                return ((Perro)obj == this);
            }
            return false;
        }
        public override string ToString()
        {
            return Ficha();
        }
    }
}
