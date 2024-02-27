using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vettori
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vettore v1 = new Vettore(6, 3);
            Vettore v2 = new Vettore(4, 6);
            double a = 3;
            Console.WriteLine(v1 * v2);
            Console.WriteLine(v1*a);
            Console.WriteLine(a* v1);
            Console.WriteLine(+v1);
            Console.WriteLine(-v1);
            Console.WriteLine(v1 + v2);
            Console.WriteLine(v1 -v2);
            Console.WriteLine(v1 / a);
            Console.WriteLine(v1.Modulo());
            if(v1==v2==true) {
                Console.WriteLine("i due vettori sono uguali");

            }
            if(v1!=v2==true)
            {
                Console.WriteLine("i due vettori sono diversi");

            }
            Console.ReadLine();

        }
    }
}
