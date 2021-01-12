using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_T10 {
    class E3 {
        public E3 () {
            Console.WriteLine("Escribe la longitud de la colección de passwords. ");
            int longitud = int.Parse(Console.ReadLine());
            
            Password[] array = new Password[longitud];
            bool[] fortalezas = new bool[longitud];

            Console.WriteLine("Escribe ahora la longitud de los passwords de la colección. ");
            int longitudPasswords = int.Parse(Console.ReadLine());

            for (int i = 0; i < array.Length; i++) {
                array[i] = new Password(longitudPasswords);
                fortalezas[i] = array[i].esFuerte();
            }

            for (int i =0; i < array.Length; i++) {
                Console.WriteLine("{0} - {1}", array[i].Passwd, fortalezas[i] ? "Fuerte" : "Debil");
            }
        }
        
        
    }
}
