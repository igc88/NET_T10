using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_T10 {
    class E6 {
        public E6 () {
            Libro l1 = new Libro();
            Libro l2 = new Libro();

            l1.Autor = "J. R. R. Tolkien";
            l1.Titulo = "El señor de los anillos";
            l1.ISBN = "21312317823918732981";
            l1.NumPags = 1031;

            l2.Autor = "Santiago Posteguillo";
            l2.Titulo = "Africanus";
            l2.ISBN = "32108930913209312";
            l2.NumPags = 700;

            Console.WriteLine(l1);
            Console.WriteLine(l2);

            Console.WriteLine("El libro con más páginas es: ");
            Console.WriteLine((l1.NumPags > l2.NumPags) ? l1.Titulo : l2.Titulo);
        }
    }
}
