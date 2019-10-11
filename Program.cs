using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_8
{
    class Program
    {

        public struct Estudiantes
        {
            public string nombre;
            public string carnet;
            public string carrera;
            private double cum;

             public void setCUM(double cum)
            {
                if (cum >= 0 && cum <= 10)
                {
                    this.cum = cum;
                }
                else
                {
                    this.cum = 1;
                }
            }
            public double getCUM()
            {
                return cum;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("\n¿Cuántos estudiantes ingresará?");
            int extencion;
            extencion = Convert.ToInt32(Console.ReadLine());
            Estudiantes[] ArregloEstudiantes = new Estudiantes[extencion];
            Console.Clear();
            for (int i = 0; i < ArregloEstudiantes.Length; i++)
            {
                Console.WriteLine("Digite la información del estudiante número {0}", i + 1);
                Console.WriteLine("\nNombre del alumno: ");
                ArregloEstudiantes[i].nombre = Console.ReadLine();
                Console.WriteLine("\nCarnet del estudiante (con guiones y las letras en mayusculas): ");
                ArregloEstudiantes[i].carnet = Console.ReadLine();
                Console.WriteLine(" \nCarrera del estudiante: ");
                ArregloEstudiantes[i].carrera = Console.ReadLine();
                Console.WriteLine("\nCum del estudiante: ");
                ArregloEstudiantes[i].setCUM(Convert.ToDouble(Console.ReadLine()));
                Console.Clear();
            }
            for (int i = 0; i < ArregloEstudiantes.Length; i++)
            {
                Console.WriteLine("\nEstudiante número {0}", i + 1);
                Console.WriteLine("\nNombre: {0}", ArregloEstudiantes[i].nombre);
                Console.WriteLine("\nCarnte: {0}", ArregloEstudiantes[i].carnet);
                Console.WriteLine("\nCarrera: {0}", ArregloEstudiantes[i].carrera);
                Console.WriteLine("\nCUM: {0}", ArregloEstudiantes[i].getCUM());
            }
        }
    }
}