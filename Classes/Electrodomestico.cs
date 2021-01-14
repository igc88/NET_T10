using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_T10 {
    class Electrodomestico {
        public enum Consumos {
            A, B, C, D, E, F
        }

        public enum Colores {
            Blanco, Negro, Rojo, Azul, Gris
        }

        protected int PrecioBase { get; set; } = 100;
        protected Colores Color { get; set; } = Colores.Blanco;
        protected Consumos ConsumoEnergetico { get; set; } = Consumos.F;
        protected int Peso { get; set; } = 5;
        public Electrodomestico() { }
        public Electrodomestico(int precio, int peso) {
            this.PrecioBase = precio;
            this.Peso = peso;
        }

        public Electrodomestico(int precio, string color, char consumo, int peso) {
            this.PrecioBase = precio;
            this.Peso = peso;

            comprobarConsumoEnergetico(consumo);
            comprobarColor(color);
        }

        public void MostrarDatos() {
            Console.WriteLine("Precio: {0} €", this.PrecioBase);
            Console.WriteLine("Color: {0} ", this.Color);
            Console.WriteLine("Consumo: {0} KW", this.ConsumoEnergetico);
            Console.WriteLine("Peso: {0} kg", this.Peso);
        }

        public void comprobarConsumoEnergetico(char letra) {            
            if (Enum.IsDefined(typeof(Consumos), letra.ToString())) {
                this.ConsumoEnergetico = (Consumos)Enum.Parse(typeof(Consumos), letra.ToString());
            } else {
                this.ConsumoEnergetico=Consumos.F;
            }
        }

        public void comprobarColor(string color) {            
            if (Enum.IsDefined(typeof(Colores), color)) {
                this.Color = (Colores)Enum.Parse(typeof(Colores), color);
            } else {
                this.Color = Colores.Blanco;
            }
        }

        public double precioFinal() {
            int precioPeso = 0, precioConsumo = 0;

            if (this.Peso > 0 && this.Peso <= 19) {
                precioPeso = 10;
            } else if (this.Peso >= 20 && this.Peso < 49) {
                precioPeso = 50;
            } else if (this.Peso >= 50 && this.Peso < 79) {
                precioPeso = 80;
            } else if (this.Peso <= 79) {
                precioPeso = 100;
            }

            switch (this.ConsumoEnergetico) {
                case Consumos.A:
                    precioConsumo = 100;
                    break;
                case Consumos.B:
                    precioConsumo = 80;
                    break;
                case Consumos.C:
                    precioConsumo = 60;
                    break;
                case Consumos.D:
                    precioConsumo = 50;
                    break;
                case Consumos.E:
                    precioConsumo = 30;
                    break;
                case Consumos.F:
                    precioConsumo = 10;
                    break;
            }

            return this.Peso + precioConsumo + precioPeso;
        }
    }
}
