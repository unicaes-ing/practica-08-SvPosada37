using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_8
{
    class Ejercicio4
    {
        public enum TipoDePago
        {
            Efectivo = 1,
            TarjetaDeDebito = 2,
            TarjetaDeCredito = 3
        }

        static void Main(string[] args)
        {
            double monto;
            Console.WriteLine("Ingrese el total a pagar: ");
            monto = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el tipo de pago: ");
            Console.WriteLine(" [1].Efectivo");
            Console.WriteLine(" [2].Tarjeta de Debito");
            Console.WriteLine(" [3].Tarjeta de Credito");
            Console.WriteLine("-------------------------");
            int t = Convert.ToInt32(Console.ReadLine());

            switch ((TipoDePago)t)
            {
                case TipoDePago.Efectivo:
                    Console.Clear();
                    Console.WriteLine("Monto:${0}", monto);
                    Console.WriteLine("Efectivo: Descuento del 15%");

                    double total1, sub1;
                    sub1 = monto * 0.15;
                    total1 = monto - sub1;
                    Console.WriteLine("El total a pagar es de:${0}", total1);

                    break;

                case TipoDePago.TarjetaDeDebito:
                    Console.Clear();
                    Console.WriteLine("Monto:${0}", monto);
                    Console.WriteLine("Tarjeta de Debito: Descuento del 10%");

                    double total2, sub2;
                    sub2 = monto * 0.10;
                    total2 = monto - sub2;
                    Console.WriteLine("El total a pagar es de:${0}", total2);
                    break;

                case TipoDePago.TarjetaDeCredito:
                    Console.Clear();
                    Console.WriteLine("Monto:${0}", monto);
                    Console.WriteLine(" Tarjeta de Credito: Descuento del 5%");

                    double total3, sub3;
                    sub3 = monto * 0.05;
                    total3 = monto - sub3;
                    Console.WriteLine("El total a pagar es de:${0}", total3);

                    break;

            }
            Console.ReadKey();

        }

    }
}
