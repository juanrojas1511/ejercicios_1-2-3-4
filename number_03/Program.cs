using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int max_personas;
            int asistencia_act = 0;
            int veces_lleno = 0;
            int veces_vacio = 0;
            int peronas_ingresaron = 0;
            int personas_salio = 0;


            Console.WriteLine("Ingrese un número máximo de personas:");
            max_personas = int.Parse(Console.ReadLine());

            Console.WriteLine("=====================================");
            Console.WriteLine("El número máximo establecido es de " + max_personas + " personas, presione una tecla para comenzar a contar");
            Console.ReadKey();
            
      
            do
            {
                Console.Clear();
                Console.WriteLine("==============================");
                Console.WriteLine($"| Asistentes actuales |{asistencia_act}");
                Console.WriteLine($"| Aforo               |{((double)asistencia_act / max_personas * 100):F0}%");
                Console.WriteLine($"| Máximo              |{max_personas} personas");
                Console.WriteLine("Presione");
                Console.WriteLine("[i] si ingresa una persona");
                Console.WriteLine("[s] si sale una persona");
                Console.WriteLine("[x] para terminar");

                char opcion = char.ToLower(Console.ReadKey().KeyChar);

                switch (opcion)
                {
                    case 'i':
                        if (asistencia_act < max_personas)
                        {
                            asistencia_act++;
                            peronas_ingresaron++;
                        }
                        break;
                    case 's':
                        if (asistencia_act > 0)
                        {
                            asistencia_act--;
                            personas_salio++;
                        }
                        break;
                    case 'x':
                        Console.WriteLine("Terminado");
                        break;
                    default:
                        Console.WriteLine("Intente de nuevo.");
                        break;
                }
                if (asistencia_act == 0)
                {
                    veces_vacio++;
                }
                else if (asistencia_act == max_personas)
                {
                    veces_lleno++;
                }
                if (opcion == 'x')
                {
                    break;
                }
            } while (true);
            Console.Clear();
            Console.WriteLine("=================================");
            Console.WriteLine("El programa ha terminado");
            Console.WriteLine("=================================");
            Console.WriteLine("Estadísticas:");
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"{peronas_ingresaron} personas ingresaron");
            Console.WriteLine($"{personas_salio} personas salieron");
            Console.WriteLine($"{veces_lleno} veces se llenó el local");
            Console.WriteLine($"Estuvo vacío {veces_vacio} veces");
            Console.ReadKey();
        }
    }
}
