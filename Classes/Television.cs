using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_T10 {
    class Television : Electrodomestico {
        private int _resolucion = 20;
        private bool _tdt = false;

        public int Resolucion {
            get { return _resolucion; }
            set { _resolucion = value; }
        }
        public bool TDT {
            get { return _tdt; }
            set { _tdt = value; }
        }
        public Television() : base() { }
        public Television(int precio, int peso) : base(precio, peso) { }
        public Television(int resolucion, bool tdt, int precio, string color, char consumo, int peso) : base(precio, color, consumo, peso) {
            this.Resolucion = resolucion;
            this.TDT = tdt;
        }

        public double precioFinal () {
            double result = base.precioFinal();

            if (Resolucion > 40) {
                result += result*0.3;
            }

            if (TDT) {
                result += 50;
            }

            return result;
        }
    }
}
