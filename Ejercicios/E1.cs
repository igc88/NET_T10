using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_T10 {
    class E1 {
        public E1() {
            Cuenta c1 = new Cuenta("Iago", 1500.80);

            Console.WriteLine(c1.ToString());

            Console.WriteLine("Introduzca una cantidad a ingresar: ");
            c1.Ingresar(double.Parse(Console.ReadLine()));
            Console.WriteLine(c1.ToString());

            Console.WriteLine("Introduzca una cantidad a retirar: ");
            c1.Retirar(double.Parse(Console.ReadLine()));
            Console.WriteLine(c1.ToString());
        }
    }
}
