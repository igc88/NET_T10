using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_T10 {
    class Raices {
        private double _a;
        private double _b;
        private double _c;

        public double A {
            get { return _a; }
            set { _a = value; }
        }
        public double B {
            get { return _b; }
            set { _b = value; }
        }
        public double C {
            get { return _c; }
            set { _c = value; }
        }
        public double getDiscriminante() {
            return Math.Pow(this.B, 2) - (4 * this.A * this.C);
        }
        public bool tieneRaices() {
            return getDiscriminante() > 0;
        }
        public bool tieneRaiz() {
            return getDiscriminante() == 0;
        }
        public void obtenerRaices() {
            double s1 = -this.B + Math.Sqrt(getDiscriminante()) / 2 * A;
            double s2 = -this.B - Math.Sqrt(getDiscriminante()) / 2 * A;

            Console.WriteLine("Solución 1: {0}", s1);
            Console.WriteLine("Solución 2: {0}", s2);
        }
        public void obtenerRaiz() {
            double s1 = -this.B + Math.Sqrt(getDiscriminante()) / 2 * A;
            
            Console.WriteLine("Solución 1: {0}", s1);
        }

        public void calcular() {
            if (tieneRaices()) {
                obtenerRaices();
            }

            if (tieneRaiz()) {
                obtenerRaiz();
            }
        }
    }
}
