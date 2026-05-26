using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESDAT_T2 {
    internal class NodoP {
        public Empleado Valor {  get; set; }
        public NodoP Izqu {  get; set; }
        public NodoP Dere {  get; set; }
        public NodoP(Empleado empleado) {
            Valor = empleado;
        }
        public override string ToString() {
            return Valor.ToString();
        }
    }
}
