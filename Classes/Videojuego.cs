using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_T10 {
    class Videojuego : Entregable, IComparable<Videojuego> {
        public enum Generos {
            Accion, RPG, Fantastico, Infantil, Pelea, Deportes
        }

        private Generos _genero = Generos.Accion;
        private int _horasEstimadas = 3;
        private bool _entregado;
        private string _titulo;

        public Generos Genero {
            get { return _genero; }
            set { _genero = value; }
        }

        public int HorasEstimadas {
            get { return _horasEstimadas; }
            set { _horasEstimadas = value; }
        }

        public string Titulo {
            get { return _titulo; }
            set { _titulo = value; }
        }

        public string Company { get; set; }

        public string Creador { get; set; }

        public string Entregado { get; set; }

    public Videojuego() { }
        public Videojuego(string titulo, string creador) {
            this.Titulo = titulo;
        }
        public Videojuego(string titulo, int horasEstimadas, Generos genero, string creador) {
            this.Titulo = titulo;
            this.HorasEstimadas = horasEstimadas;
            this.Genero = genero;
        }

        public override string ToString() {
            return "Titulo: " + this.Titulo + "\n" + "Horas estimadas: " + this.HorasEstimadas + "\n" + "Entregado: " + this._entregado + "\n" + "Género: " + this.Genero + "\n" + "Compañía: " + this.Company + "Crador: " + this.Creador + "\n";
        }
        public void Entregar() {
            this._entregado = true;
        }
        public void Devolver() {
            this._entregado = false;
        }
        public bool isEntregado() {
            return this._entregado;
        }

        public int CompareTo(Videojuego o) {
            if (this.HorasEstimadas > o.HorasEstimadas) {
                return 1;
            } else if (this.HorasEstimadas == o.HorasEstimadas) {
                return 0;
            } else {
                return -1;
            }
        }
    }
}