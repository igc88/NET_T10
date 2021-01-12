using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_T10 {
    class Persona {
        private string _nombre  = "";
        private int _edad  = 0;
        private string _dni;
        private char _sexo = 'H';
        private double _altura = 0;
        private int _peso = 0;

        public string Nombre {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public int Edad {
            get { return _edad; }
            set { _edad= value; }
        }
        public string DNI {
            get { return _dni; }
        }
        public char Sexo {
            get { return _sexo; }
            set { _sexo = value; }
        }
        public double Altura {
            get { return _altura; }
            set { _altura = value; }
        }
        public int Peso {
            get { return _peso; }
            set { _peso = value; }
        }

        public enum IMC {
            Sobrepeso = 1,
            PesoIdeal = 0,
            PesoInferior = -1
        }

        public void SetNombre(string nombre) {
            this.Nombre = nombre;
        }

        public void Saludar() {
            Console.WriteLine("Hola soy {0}", this.Nombre);
        }

        public Persona() {
            generaDNI();
        }

        public Persona(string nombre, int edad, char sexo) {
            this.Nombre = nombre;
            this.Edad = edad;
            this.Sexo = sexo;

            generaDNI();
        }

        public Persona(string nombre, int edad, char sexo, double altura, int peso) {
            this.Nombre = nombre;
            this.Edad = edad;
            this.Sexo = sexo;
            this.Altura = altura;
            this.Peso = peso;

            generaDNI();
        }

        public override string ToString() {
            return "Nombre: " + this.Nombre + "\n" + "Edad: " + this.Edad + "\n" + "Sexo: " + this.Sexo + "\n" + "DNI: " + this.DNI + "\n" + "Altura: " + this.Altura + "\n" + "Peso: " + this.Peso;
        }        

        public IMC comprobarIMC() {
            double imc = this.Peso / Math.Pow(this.Altura, 2);

            if (imc < 20) {
                return IMC.PesoInferior;
            } else if (imc >=20 && imc <=25) {
                return IMC.PesoIdeal;
            } else {
                return IMC.Sobrepeso;
            }           
        }

        public bool esMayorEdad() {
            return this.Edad >= 18;
        }

        private void comprobarSexo(char sexo) {
            if (sexo != 'H' && sexo != 'M') {
                this.Sexo = 'H';
            }
        }
        private void generaDNI() {
            string plantilla = "TRWAGMYFPDXBNJZSQVHLCKE";

            string dni = string.Empty;
            Random rnd = new Random();

            for (int i = 0; i < 8; i++) {
                int rndNum = rnd.Next(0, 9);
                dni += rndNum.ToString();
            }

            int numDni = int.Parse(dni);
            int mod23 = numDni % 23;

            this._dni = dni + plantilla[mod23];
        }
    }
}
