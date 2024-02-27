using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace vettori
{
    internal class Vettore
    {
        public double X { get;}
        public double Y { get;}

        public Vettore (double x, double y)
        {  X = x; Y = y; }

        public static Vettore operator - (Vettore v1 , Vettore v2)
        {
            return new Vettore(v1.X-v2.X, v1.Y-v2.Y);

        }
        public static Vettore operator +(Vettore v1, Vettore v2)
        {
            return new Vettore(v1.X + v2.X, v1.Y + v2.Y);

        }
        public static double operator *(Vettore v1, Vettore v2)
        {
            double prodotto = (v1.X * v2.X+v1.Y*v2.Y);
            return prodotto;
        }
        public static Vettore operator *(Vettore v1, double a)
        {
            return new Vettore(v1.X*a, v1.Y*a);
        }
        public static Vettore operator *( double a, Vettore v1)
        {
            return new Vettore(v1.X * a, v1.Y * a);
        }
        public static Vettore operator /(Vettore v1, double a)
        {
            return new Vettore(v1.X / a, v1.Y / a);
        }
        public double Modulo()
        {
            return(Math.Sqrt(this.X*this.X + this.Y*this.Y));
        }
        public static bool operator==(Vettore v1 , Vettore v2)
        {
            if(v1.X==v2.X && v1.Y==v2.Y) return true;
            else return false;
        }
        public static bool operator !=(Vettore v1, Vettore v2)
        {
            if(v1.X!=v2.X && v1.Y!=v2.Y) return false;
            else return true;
        }
        public static Vettore operator -(Vettore v1)
        {
            return new Vettore(-v1.X, -v1.Y);
        }
        public static Vettore operator +(Vettore v1)
        {
            return new Vettore(v1.X, v1.Y);
        }
        public override string ToString()
        {
            return string.Format("{0};{1}", X,Y);
        }
        public static Vettore Parse(string text)
        {
            string[] parts = text.Split(';');
            return new Vettore(double.Parse(parts[0]), double.Parse(parts[1]));
        }
        public static bool TryParse(string text, out Vettore vettore)
        {
            try
            {
                vettore = Vettore.Parse(text);
                return true;

            }
            catch
            {
                vettore = null; return false;
            } }
            


    }

    }

