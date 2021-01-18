using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_T10 {
    interface Entregable{
        string Titulo { get; set; }

        void Entregar();
        void Devolver();
        bool isEntregado();
        
    }
}
