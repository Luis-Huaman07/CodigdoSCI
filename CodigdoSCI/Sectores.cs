using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using biblioteca_SCI;
using IncendiosFunciones;
using IncendiosFunciones.IncendiosFunciones;
using static biblioteca_SCI.BibliotecaSCI;
namespace ProgramSCI
{
    internal class Sectores
    {
        static void Main(string[] args)
        {
            Panel();
        }
        static void Panel()
        {
            int peligro = 0;
            int sectores;
            Console.WriteLine(" ---------------------------------(SECTORES)--------------------------------");
            Console.WriteLine("|                                                          |    SECTOR 3    |");
            Console.WriteLine("|                                                          |                |");
            Console.WriteLine("|                                                          |                |");
            Console.WriteLine("|                                |         SECTOR 2        |                |");
            Console.WriteLine("|                                |                         |                |");
            Console.WriteLine("|             SECTOR 1           |                         |                |");
            Console.WriteLine("|                                |                                          |");
            Console.WriteLine("|                                |                                          |");
            Console.WriteLine("|                                |                                          |");
            Console.WriteLine("------------------------------------------------------------------          |");
            Console.WriteLine("|                                                                           |");
            Console.WriteLine("|                                                                           |");
            Console.WriteLine("|                                         |                                 |");
            Console.WriteLine("|                                         |                                 |");
            Console.WriteLine("|                                         |                                 |");
            Console.WriteLine("|                                         |                                 |");
            Console.WriteLine("|                                         |                                 |");
            Console.WriteLine("|                       SECTOR 4          |            SECTOR 5             |");
            Console.WriteLine(" ---------------------------------------------------------------------------");
            Console.WriteLine();

            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n                      PANEL DE CONTROL");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("(1) Monitorear planta 1: ");
                Console.WriteLine("(2) Monitorear planta 2: ");
                Console.WriteLine("(3) Monitorear planta 3: ");
                Console.WriteLine("(4) Monitorear planta 4: ");
                Console.WriteLine("(5) Monitorear planta 5: ");
                Console.WriteLine("(6) Activar  alarma manualmente");
                Console.WriteLine("(7) Para salir");
                Console.ForegroundColor = ConsoleColor.White;
                sectores = int.Parse(Console.ReadLine());
                Menu(sectores, peligro);
            } while (sectores != 7);
        }
        static void Menu(int sector, int peligro)
        {
            switch (sector)
            {
                case 1: Sector1(); break;
                case 2: Sector2(); break;
                case 3: Sector3(); break;
                case 4: Sector4(); break;
                case 5: Sector5(); break;
                case 6: Seis(); break;
                case 7: Console.WriteLine("Saliendo......"); Environment.Exit(0); break;
                default: Console.WriteLine("Opción no válida"); break;

            }
        }
        static void Sensores(ref int peligro, ref int intentos, ref bool hayAdvertenciaTemp, ref bool hayAdvertenciaHumo)
        {

            Console.WriteLine("Intentos de Monitoreo Constante");
            int nintentos = int.Parse(Console.ReadLine());
            peligro = 200;
            do
            {
                int temp1 = Temperatura();
                int temp2 = Temperatura();
                double humo1 = Humo();
                double humo2 = Humo();
                Thread.Sleep(2000);
                Console.Clear();
                peligro = 200;
                Console.WriteLine($"Sensor de temperatura N°1: {temp1}°C");
                Console.WriteLine($"Sensor de temperatura N°2: {temp2}°C");
                Console.WriteLine($"Sensor de humo N°1: {humo1}%");
                Console.WriteLine($"Sensor de humo N°2: {humo2}%");
                Console.WriteLine("\n--- ADVERTENCIAS ---");
                if (temp1 >= 60) { Console.WriteLine("PELIGRO: Temperatura crítica en sensor 1"); peligro += 2; }
                if (temp2 >= 60) { Console.WriteLine("PELIGRO: Temperatura crítica en sensor 2"); peligro += 2; }
                if (humo1 >= 1.5) { Console.WriteLine("PELIGRO: Humo crítico en sensor 1"); peligro += 2; }
                if (humo2 >= 1.5) { Console.WriteLine("PELIGRO: Humo crítico en sensor 2"); peligro += 2; }

                if ((temp1 >= 31 && temp1 < 59) && (humo1 >= 0.6 && humo1 < 1.4))
                {
                    Console.WriteLine("Advertencia: Temperatura y humo moderados en sensor 1");
                    hayAdvertenciaTemp = true;
                    hayAdvertenciaHumo = true;
                    peligro += 2;
                }
                else if (temp1 >= 0 && temp1 < 30)
                {
                    Console.WriteLine("Advertencia: Temperatura media en sensor 1");
                    hayAdvertenciaTemp = false; peligro += 1;
                }
                else if (humo1 >= 0.6 && humo1 < 1.4)
                {
                    Console.WriteLine("Advertencia: Humo moderado en sensor 1");
                    hayAdvertenciaHumo = true; peligro += 1;
                }
                else { hayAdvertenciaTemp = true; hayAdvertenciaHumo = false; peligro += 1; }

                if ((temp2 >= 31 && temp2 < 59) && (humo2 >= 0.6 && humo2 < 1.4))
                {
                    Console.WriteLine("Advertencia: Temperatura y humo moderados en sensor 2");
                    hayAdvertenciaTemp = true;
                    hayAdvertenciaHumo = true;
                    peligro += 2;
                }
                else if (temp2 >= 0 && temp2 < 30)
                {
                    Console.WriteLine("Advertencia: Temperatura media en sensor 2");
                    hayAdvertenciaTemp = false; peligro += 1;
                }
                else if (humo2 >= 0.6 && humo2 < 1.4)
                {
                    Console.WriteLine("Advertencia: Humo moderado en sensor 2");
                    hayAdvertenciaHumo = true; peligro += 1;
                }
                else { hayAdvertenciaTemp = true; hayAdvertenciaHumo = false; peligro += 1; }
                if (peligro >= 8)
                {
                    break;
                }

                intentos++;
            }
            while (intentos != nintentos);
        }
        static void Sector1()
        {
            int peligro = 200;
            int intentos = 0;
            bool hayAdvertenciaTemp = false;
            bool hayAdvertenciaHumo = false;
            Funciones.Sector1();
            Sensores(ref peligro, ref intentos, ref hayAdvertenciaTemp, ref hayAdvertenciaHumo);
            Estado(peligro, intentos, hayAdvertenciaTemp, hayAdvertenciaHumo);
        }
        static void Sector2()
        {
            int peligro = 200;
            int intentos = 0;
            bool hayAdvertenciaTemp = false;
            bool hayAdvertenciaHumo = false;
            Funciones.Sector2();
            Sensores(ref peligro, ref intentos, ref hayAdvertenciaTemp, ref hayAdvertenciaHumo);
            Estado(peligro, intentos, hayAdvertenciaTemp, hayAdvertenciaHumo);

        }
        static void Sector3()
        {
            int peligro = 200;
            int intentos = 0;
            bool hayAdvertenciaTemp = false;
            bool hayAdvertenciaHumo = false;
            Funciones.Sector3();
            Sensores(ref peligro, ref intentos, ref hayAdvertenciaTemp, ref hayAdvertenciaHumo);
            Estado(peligro, intentos, hayAdvertenciaTemp, hayAdvertenciaHumo);
        }
        static void Sector4()
        {

            int peligro = 200;
            int intentos = 0;
            bool hayAdvertenciaTemp = false;
            bool hayAdvertenciaHumo = false;
            Funciones.Sector4();
            Sensores(ref peligro, ref intentos, ref hayAdvertenciaTemp, ref hayAdvertenciaHumo);
            Estado(peligro, intentos, hayAdvertenciaTemp, hayAdvertenciaHumo);
        }
        static void Sector5()
        {

            int peligro = 200;
            int intentos = 0;
            bool hayAdvertenciaTemp = false;
            bool hayAdvertenciaHumo = false;
            Funciones.Sector5();
            Sensores(ref peligro, ref intentos, ref hayAdvertenciaTemp, ref hayAdvertenciaHumo);
            Estado(peligro, intentos, hayAdvertenciaTemp, hayAdvertenciaHumo);
        }
        static int Temperatura()
        {
            Funciones t = new Funciones();

            int temp = t.Calculartemperatura();
            return temp;
        }
        static double Humo()
        {
            Funciones h = new Funciones();
            double hu = h.Calcularhumo();
            return hu;
        }
        static void Estado(int peligro, int intentos, bool hayAdvertenciaTemp, bool hayAdvertenciaHumo)
        {
            if (peligro >= 8)
            {
                Alerta.SonidoIncendio();
            }
            else if (hayAdvertenciaTemp || hayAdvertenciaHumo)
            {
                Alerta.Moderado(Panel);
            }
            else
            {
                Alerta.SinPeligro();
            }
            Panel();
        }
        static void Seis()
        {
            Console.WriteLine("Seleccione sector del que desea activar la alarma:");
            int acti = int.Parse(Console.ReadLine());
            switch (acti)
            {
                case 1: Funciones.Sector1(); Alerta.SonidoIncendio(); break;
                case 2: Funciones.Sector2(); Alerta.SonidoIncendio(); break;
                case 3: Funciones.Sector3(); Alerta.SonidoIncendio(); break;
                case 4: Funciones.Sector4(); Alerta.SonidoIncendio(); break;
                case 5: Funciones.Sector5(); Alerta.SonidoIncendio(); break;
                default: break;
            }
        }
    }
}
