using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ESDAT_T2 {
    internal class ArbolBBP {
        public NodoP Primero {  get; set; }
        public ArbolBBP() {
            Primero = null;
        }
        
        public void Agrega(Empleado empleado) {
             Primero = Agrega(Primero, empleado);
        }
        private NodoP Agrega(NodoP nodoActual, Empleado empleado) {
            if (nodoActual == null) {
                return new NodoP(empleado);
            }

            if (empleado.Codigo < nodoActual.Valor.Codigo) {
                nodoActual.Izqu = Agrega(nodoActual.Izqu, empleado);
            } else if (empleado.Codigo > nodoActual.Valor.Codigo) {
                nodoActual.Dere = Agrega(nodoActual.Dere, empleado);
            }

            return nodoActual;
        }

        public void MuestraInCodigo() {
            InOrden(Primero);
        }
        private void InOrden(NodoP nodo) {
            if(nodo != null) {
                Console.WriteLine(nodo.ToString());
                InOrden(nodo.Izqu);
                InOrden(nodo.Dere);
            }
        }
        
        public void MuestraPosAntiguedad() {
            PosOrden(Primero);
        }
        private void PosOrden(NodoP nodo) {
            if (nodo != null) {
                InOrden(nodo.Izqu);
                InOrden(nodo.Dere);
                Console.WriteLine(nodo.ToString());
            }
        }

        public int MayerasA(int antiguedad) {
            int contador = 0;
            NodoP temp = Primero;

            RecorridoMayoresAPreOrden(temp, ref contador, antiguedad);

            return contador;
        }
        private void RecorridoMayoresAPreOrden(NodoP nodo, ref int contador, int antiguedad) {
            if(nodo !=null) {
                if(nodo.Valor.Antiguedad > antiguedad) {
                    contador++;
                }
                RecorridoMayoresAPreOrden(nodo.Izqu, ref contador, antiguedad);
                RecorridoMayoresAPreOrden(nodo.Dere, ref contador, antiguedad);
            }
        }
        public string Penultimo() {
            NodoP penultimo = new NodoP(new Empleado());
            NodoP ultimo = new NodoP(new Empleado());
            RecorridoPenultimoPreOrden(this.Primero, ref penultimo, ref ultimo);

            return penultimo.ToString();
        }

        private void RecorridoPenultimoPreOrden(NodoP nodo, ref NodoP penultimo, ref NodoP ultimo) {
            if(nodo !=null) {                
                RecorridoPenultimoPreOrden(nodo.Izqu, ref penultimo, ref ultimo);
                //raiz
                penultimo = ultimo;
                ultimo = nodo;
                RecorridoPenultimoPreOrden(nodo.Dere, ref penultimo, ref ultimo);
            }
        }
        public void Retornar() {
            Console.WriteLine();
            Console.WriteLine("Presione cualquier tecla para volver...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
