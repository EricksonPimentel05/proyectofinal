using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuenta
{
    class Program
    {
        static void Main(string[] args)
        {
            int cuenta;
            float saldo, suma;
            string linea;
            suma = 0;

            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("Nombre: Erickson Pimentel" + "\n" + "Matricula: 17-EIIT-1-014" + "\n");
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("Seccion 0463");
            Console.WriteLine("-------------------------------------------------------------");
            do
            {
                Console.Write("Ingrese número de cuenta:");
                linea = Console.ReadLine();
                cuenta = int.Parse(linea);
                if (cuenta >= 0)
                {
                    Console.Write("Ingrese saldo:");
                    linea = Console.ReadLine();
                    saldo = float.Parse(linea);
                    if (saldo > 0)
                    {
                        Console.WriteLine("Saldo Acreedor.");
                        suma = suma + saldo;
                    }
                    else
                    {
                        if (saldo < 0)
                        {
                            Console.WriteLine("Saldo Deudor.");
                        }
                        else
                        {
                            Console.WriteLine("Saldo Nulo.");
                        }
                    }
                }
            } while (cuenta >= 0);
            Console.Write("Total de saldos Acreedores.");
            Console.Write(suma);
            Console.ReadKey();
        
        }
    }
}
