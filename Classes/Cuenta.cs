using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_T10 {
    class Cuenta {
        private string _titular;
        private double _cantidad; 

        public string Titular {
            get { return _titular; }
            set { _titular = value; }
        }
        public double Cantidad {
            get { return _cantidad; }
            set { _cantidad = value; }
        }

        public Cuenta(string titular) {
            Titular = titular;
        }

        public Cuenta(string titular, double cantidad) {
            Titular = titular;
            Cantidad = cantidad;
        }

        public override string ToString() {
            return Titular + ": " + Cantidad;
        }

        public void Ingresar(double cantidad) {
            if (cantidad < 0) return;

            Cantidad += cantidad;
        }

        public void Retirar(double cantidad) {
            if (cantidad < 0) return;

            Cantidad -= cantidad;

            if (Cantidad < 0) Cantidad = 0;
        }
    }
}
