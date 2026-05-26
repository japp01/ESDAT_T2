using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ESDAT_T2 {
    internal class Program {
        
        static void Main(string[] args) {
            ArbolBBP arbol = new ArbolBBP();

            //agregando empleados
            arbol.Agrega(new Empleado(3689, "a", 5));
            arbol.Agrega(new Empleado(2378, "b", 15));
            arbol.Agrega(new Empleado(4975, "c", 25));
            arbol.Agrega(new Empleado(8162, "d", 35));
            arbol.Agrega(new Empleado(4763, "e", 45));
            arbol.Agrega(new Empleado(5915, "f", 55));
            arbol.Agrega(new Empleado(1584, "g", 65));
            arbol.Agrega(new Empleado(5861, "h", 75));

            while (true) {
                Console.WriteLine("1. Agrega");
                Console.WriteLine("2. Listar1");
                Console.WriteLine("3. Listar2");
                Console.WriteLine("4. Mayores a cierta antiguedad");
                Console.WriteLine("5. Penultimo");
                Console.WriteLine("9. Fin");
                Console.WriteLine();
                Console.Write("> ");
                string opcion = Console.ReadLine();
                int.TryParse(opcion, out int value);

                switch (value) {
                    case 0:
                        Console.WriteLine("Opcion incorrecta");
                        arbol.Retornar();
                        break;
                    case 1:
                        Console.Write("codigo: ");
                        int codigo = int.Parse(Console.ReadLine());
                        Console.Write("nombre: ");
                        string nombre = Console.ReadLine();
                        Console.Write("antiguedad: ");
                        int antiguedad = int.Parse(Console.ReadLine());

                        arbol.Agrega(new Empleado(codigo, nombre, antiguedad));

                        Console.WriteLine("Agregado!");
                        arbol.Retornar();
                        break;
                    case 2:
                        arbol.MuestraInCodigo();
                        arbol.Retornar();
                        break;
                    case 3:
                        arbol.MuestraPosAntiguedad();
                        arbol.Retornar();
                        break;
                    case 4:
                        Console.Write("Antiguedad: ");
                        int ant = int.Parse(Console.ReadLine());
                        Console.WriteLine(arbol.MayerasA(ant));
                        arbol.Retornar();
                        break;
                    case 5:
                        Console.WriteLine(arbol.Penultimo());
                        arbol.Retornar();
                        break;
                    case 9:
                        return;
                    default:
                        Console.WriteLine("Opcion incorrecta");
                        arbol.Retornar();
                        break;
                }
            }
            
        }
        
    }
}
