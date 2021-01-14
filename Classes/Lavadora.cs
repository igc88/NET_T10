using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_T10 {
    class Lavadora : Electrodomestico {
        private const double defaultCarga = 5;

        private double _carga = defaultCarga;

        public double Carga {
            get { return _carga; }
            set { _carga = value; }
        }

        public Lavadora() : base() {}
        public Lavadora(int precio, int peso) : base(precio, peso) { }
        public Lavadora(double carga, int precio, string color, char consumo, int peso) : base(precio,color,consumo,peso) {
            this.Carga = carga;
        }

        public double precioFinal() {
            return base.precioFinal() + (this.Carga > 30 ? 30 : 0);
        }
    }
}
