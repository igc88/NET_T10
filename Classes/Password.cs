using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_T10 {
    class Password {
        private int _longitud = 8;
        private string _passwd = string.Empty;
        public int Longitud {
            get { return _longitud; }
            set { _longitud = value; }
        }
        public string Passwd {
            get { return _passwd; }
        }
        public Password() { }

        public Password(int longitud) {
            Longitud = longitud;
            this._passwd = generarPassword(Longitud);
        }
        private string generarPassword(int longitud) {
            string caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            string rndPasswd = string.Empty;

            Random rdn = new Random();
            for (int i = 0; i < longitud; i++) {
                
                char letra = caracteres[rdn.Next(caracteres.Length)];
                rndPasswd += letra.ToString();
            }

            return rndPasswd;
        }

        public bool esFuerte() {
            string minusculas = "abcdefghijklmnopqrstuvwxyz";
            string mayusculas = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string nums = "1234567890";

            int nNum = 0, nMay = 0, nMin = 0;

            for (int i = 0; i < Passwd.Length; i++) {
                if (minusculas.Contains(Passwd[i])) nMin++;
                if (mayusculas.Contains(Passwd[i])) nMay++;
                if (nums.Contains(Passwd[i])) nNum++;
            }

            return nMay > 2 && nMin > 1 && nNum > 5;
        }
    }
}
