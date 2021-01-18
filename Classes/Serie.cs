using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_T10 {
    class Serie : Entregable, IComparable<Serie> {
        public enum Generos {
            Thriller, SCI_FI, Drama, Comedia, Terror, Animación
        }

        private int _numTemporadas = 3;
        private string _titulo = string.Empty;        
        private bool _entregado = false;
        private Generos _genero = Generos.Drama;
        private string _creador;

        public string Titulo { 
            get { return _titulo; }
            set { _titulo = value; }
        }
        public int NumTemporadas {
            get { return _numTemporadas; }
            set { _numTemporadas = value; }
        }

        public Generos Genero {
            get { return _genero; }
            set { _genero = value; }
        }

        public string Creador {
            get { return _creador; }
            set { _creador = value; }
        }

        public Serie() { }
        public Serie(string titulo, string creador) {
            this.Titulo = titulo;
            this.Creador = creador;
        }
        public Serie(string titulo, int numTemporadas, Generos genero, string creador) {
            this.Titulo = titulo;
            this.NumTemporadas = numTemporadas;
            this.Genero = genero;
            this.Creador = creador;
        }

        public override string ToString() {
            return "Titulo: " + this.Titulo + "\n" + "Número de temporadas: " + this.NumTemporadas + "\n" + "Entregado: " + this._entregado + "\n" + "Género: " + this.Genero + "\n" + "Creador: " + this.Creador;
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

        public int CompareTo(Serie o) {
            if (this.NumTemporadas > o.NumTemporadas) {
                return 1;
            } else if (this.NumTemporadas == o.NumTemporadas) {
                return 0;
            } else {
                return -1;
            }
        }
    }
}