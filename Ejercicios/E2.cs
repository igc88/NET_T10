using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_T10 {
    class E2 {
        public E2() {
            char sexo;
            string nombre;
            int peso, edad;
            double altura;

            Console.WriteLine("Escriba el nombre de la persona: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Escriba la edad de la persona: ");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Escriba el sexo de la persona (H, M): ");
            sexo = char.Parse(Console.ReadLine());
            Console.WriteLine("Escriba el peso de la persona: ");
            peso = int.Parse(Console.ReadLine());
            Console.WriteLine("Escriba la altura de la persona: ");
            altura = double.Parse(Console.ReadLine());

            Persona p1 = new Persona(nombre, edad, sexo, altura, peso);
            Persona p2 = new Persona(nombre, edad, sexo);
            
            Persona p3 = new Persona();
            p3.Nombre = nombre;
            p3.Edad = edad;
            p3.Sexo = sexo;
            p3.Altura = altura;
            p3.Peso = peso;

            Console.WriteLine("\n");
            Console.WriteLine(p1.ToString());
            Console.WriteLine(p1.esMayorEdad() ? "Es mayor de edad" : "No es mayor de edad");
            Console.WriteLine(p1.comprobarIMC());
            Console.WriteLine("\n");
            Console.WriteLine(p2.ToString());
            Console.WriteLine(p2.esMayorEdad() ? "Es mayor de edad" : "No es mayor de edad");
            Console.WriteLine(p2.comprobarIMC());
            Console.WriteLine("\n");
            Console.WriteLine(p3.ToString());
            Console.WriteLine(p3.esMayorEdad() ? "Es mayor de edad" : "No es mayor de edad");
            Console.WriteLine(p3.comprobarIMC());
        }
    }
}
