using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncendiosFunciones
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace IncendiosFunciones
    {
        public class Funciones
        {
            private static Random _random = new Random();

            public int Calculartemperatura()
            {
                // Simulamos temperaturas entre 15°C y 80°C
                return _random.Next(15, 81);
            }

            public double Calcularhumo()
            {
                // Simula niveles de humo entre 0% y 3%
                return Math.Round(_random.NextDouble() * 3, 2);
            }

            public static void Sector1()
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n🏭 ACTIVANDO MONITOREO SECTOR 1");
                Console.WriteLine("Zona: Oficinas generales");
                Console.ForegroundColor = ConsoleColor.White;
            }

            public static void Sector2()
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n🏭 ACTIVANDO MONITOREO SECTOR 2");
                Console.WriteLine("Zona: Sala de Reuniones");
                Console.ForegroundColor = ConsoleColor.White;
            }

            public static void Sector3()
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n🏭 ACTIVANDO MONITOREO SECTOR 3");
                Console.WriteLine("Zona: Oficina del Director");
                Console.ForegroundColor = ConsoleColor.White;
            }

            public static void Sector4()
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n🏭 ACTIVANDO MONITOREO SECTOR 4");
                Console.WriteLine("Zona: Área de mantenimiento");
                Console.ForegroundColor = ConsoleColor.White;
            }

            public static void Sector5()
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n🏭 ACTIVANDO MONITOREO SECTOR 5");
                Console.WriteLine("Zona: Área de servicios");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
