using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_T10 {
    class E4 {
        public E4 () {
            Electrodomestico[] e = {
                new Lavadora(),
                new Lavadora(1000, 500),
                new Lavadora(50, 1500, "Azul", 'A', 300),
                new Television(),
                new Television(1000, 500),
                new Television(43, true, 1500, "Azul", 'A', 300),
                new Electrodomestico(),
                new Electrodomestico(1000, 500),
                new Electrodomestico(1500, "Azul", 'A', 300),
            };
            int i = 1;
            foreach (Electrodomestico o in e) {
                Console.WriteLine("Electrodomestico {0}: {1}", i, o.precioFinal());
                i++;
            }            
        }
    }
}
