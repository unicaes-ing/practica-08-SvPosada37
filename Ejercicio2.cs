using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_8
{
    class Ejercicio2
    {
       public static Productos Total = new Productos();
        public struct Productos
        {
            public string nombre;
            private int cantidad;
            private double precio;
            public double total;
            

            public void setCantidad(int cantidad)
            {
                if (cantidad > 0 )
                {
                    this.cantidad = cantidad;
                } 
                else
                {
                    this.cantidad = 0;
                }
            }
            public int getCantidad()
            {
                return cantidad;
            }
            public void setPrecio(double precio)
            {
                if (precio > 0)
                {
                    this.precio = precio;
                }
                else
                {
                    this.precio = 0;
                }
            }
            public double getPrecio()
            {
                precio = (precio * 0.13) + precio;
                return precio;
            }  
        }

        static void Main(string[] args)
        {
            Console.WriteLine("¿Cuántos productos desea ingresar?");
            int extencion;
            extencion = Convert.ToInt32(Console.ReadLine());
            Productos[] ArregloProductos = new Productos[extencion];
            Console.Clear();
            
            for (int i = 0; i < ArregloProductos.Length; i++)
            {
                Console.WriteLine("Digite la información del Producto número {0}", i + 1);
                Console.WriteLine("\nNombre del producto: ");
                ArregloProductos[i].nombre = Console.ReadLine();
                Console.WriteLine("\nCantidad: ");
                ArregloProductos[i].setCantidad(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine("\nPrecio: ");
                ArregloProductos[i].setPrecio(Convert.ToDouble(Console.ReadLine()));
                
                Console.Clear();
            }
            for (int i = 0; i < ArregloProductos.Length; i++)
            {
                Console.WriteLine("\nProducto número {0}", i + 1);
                Console.WriteLine("\nNombre: {0}", ArregloProductos[i].nombre);
                Console.WriteLine("\nCantidad: {0}", ArregloProductos[i].getCantidad());
                Console.WriteLine("\nPrecio: {0:C2}", ArregloProductos[i].getPrecio());
                Total.total += ArregloProductos[i].getPrecio();
            }
            Console.WriteLine("\nEl total de los productos es: {0:C2}", Total.total);
            Console.WriteLine("");
            Console.ReadKey();
        }
    }
}
