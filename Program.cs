using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_T10 {
    class Program {
        static void Main(string[] args) {
            int opcion = 0;

            Console.WriteLine("Elija el ejercicio que desea ejecutar: \n 1. Cuenta \n 2. Persona \n 3. Password \n 5. Series y Videojuegos \n 0. Salir");
            
            opcion = int.Parse(Console.ReadLine());

            switch (opcion) {
                case 1:
                    E1 ejercicio1 = new E1();

                    break;
                case 2:
                    E2 ejercicio2 = new E2();
                    break;
                case 3:
                    E3 ejercicio3 = new E3();
                    break;
                case 4:
                    E4 ejercicio4 = new E4();
                    break;
                case 5:
                    E5 ejercicio5 = new E5();
                    break;
                case 6:
                    E6 ejercicio6 = new E6();
                    break;
                case 7:
                    E7 ejercicio7 = new E7();
                    break;
                default:
                    break;
            }

            Console.ReadKey();
        }
    }
}
