using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_T10 {
    class Libro {
        private string _autor;
        private string _titulo;
        private string _isbn;
        private int _numPags;
        public string Autor {
            get { return _autor; }
            set { _autor = value; }
        }
        public string Titulo {
            get { return _titulo; }
            set { _titulo = value; }
        }
        public string ISBN {
            get { return _isbn; }
            set { _isbn = value; }
        }
        public int NumPags {
            get { return _numPags; }
            set { _numPags = value; }
        }
        public override string ToString() {
            return "El libro " + this.Titulo + " con ISBN: " + this.ISBN +  " está escrito por " + this.Autor + " y tiene " + this.NumPags + " páginas.";
        }
    }
}
