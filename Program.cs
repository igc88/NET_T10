﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_T10 {
    class Program {
        static void Main(string[] args) {
            int opcion = 0;

            Console.WriteLine("Elija el ejercicio que desea ejecutar: \n 1. Cuenta \n 0. Salir");
            
            opcion = int.Parse(Console.ReadLine());

            switch (opcion) {
                case 1:
                    E1 ejercicio1 = new E1();

                    break;
                default:
                    break;
            }

            Console.ReadKey();
        }
    }
}