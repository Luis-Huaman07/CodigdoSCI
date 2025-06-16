using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace biblioteca_SCI
{
    public class BibliotecaSCI
    {
        public static class Alerta
        {
            public static void SonidoIncendio()
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("🚨 ALARMA DE INCENDIO ACTIVADA 🚨");
                Console.WriteLine("EVACUAR INMEDIATAMENTE");
                Console.ForegroundColor = ConsoleColor.White;

                // Sonidos con beeps
                for (int i = 0; i < 5; i++)
                {
                    Console.Beep(2000, 600);
                    Thread.Sleep(300);
                }
            }

            public static void Moderado(Action callback)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("⚠️ ADVERTENCIA MODERADA ⚠️");
                Console.WriteLine("Niveles de alerta detectados");
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("Presiona cualquier tecla para continuar...");
                Console.ReadKey();
                callback();
            }

            public static void SinPeligro()
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("✅ SISTEMA NORMAL");
                Console.WriteLine("Todos los parámetros dentro de rangos seguros");
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("Presiona cualquier tecla para continuar...");
                Console.ReadKey();
            }
        }
    }
}
