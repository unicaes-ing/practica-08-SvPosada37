using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_8
{
    class Ejercicio3
    {
        //Estrucuta materia
        public struct materia
        {
            public string nombre;
            private double nota;
            //Validacion
            public void setNota (double nota)
            {
                if (nota >= 0 && nota <=10)
                {
                    this.nota = nota;
                }
                else
                { 
                    this.nota = 1;
                }
            }
            public double getNota()
            {
                return nota;
            }
        }
        //Estructura Alumno
       public struct alumno
        {
            public string nombre;
            public string carnet;
            public string carrera;
            public materia materia1;
            public materia materia2;
            public materia materia3;
            public materia materia4;
        }
        static string Resultado(double nota)
        {
            if (nota >= 7)
            {
                string pasar = "Aprobada";
                return pasar;
            }
            else
            {
                string reprobar = "Reprobada";
                return reprobar;
            }
        }
        static void Main(string[] args)
        {
            
            Console.WriteLine("\n¿Cuántos estudiantes ingresará?");
            int extencion;
            extencion = Convert.ToInt32(Console.ReadLine());
            alumno[] ArregloEstudiantes = new alumno[extencion];
            Console.Clear();
            //Preguntar datos
            for (int i = 0; i < ArregloEstudiantes.Length; i++)
            {
                Console.WriteLine("Digite la información del estudiante número {0}", i + 1);
                Console.WriteLine("\nNombre del alumno: ");
                ArregloEstudiantes[i].nombre = Console.ReadLine();
                Console.WriteLine("\nCarnet del estudiante (con guiones y las letras en mayusculas): ");
                ArregloEstudiantes[i].carnet = Console.ReadLine();
                Console.WriteLine(" \nCarrera del estudiante: ");
                ArregloEstudiantes[i].carrera = Console.ReadLine();
                //Materia 1
                Console.WriteLine("\nPrimera materia del estudiante: ");
                Console.WriteLine("\nNombre de la materia: ");
                ArregloEstudiantes[i].materia1.nombre = Console.ReadLine();
                Console.WriteLine("\nNota de la materia");
                ArregloEstudiantes[i].materia1.setNota(Convert.ToDouble(Console.ReadLine()));
                //Materia 2
                Console.WriteLine("\nSegunda materia del estudiante: ");
                Console.WriteLine("\nNombre de la materia: ");
                ArregloEstudiantes[i].materia2.nombre = Console.ReadLine();
                Console.WriteLine("\nNota de la materia");
                ArregloEstudiantes[i].materia2.setNota(Convert.ToDouble(Console.ReadLine()));
                //Materia 3
                Console.WriteLine("\nTercera materia del estudiante: ");
                Console.WriteLine("\nNombre de la materia: ");
                ArregloEstudiantes[i].materia3.nombre = Console.ReadLine();
                Console.WriteLine("\nNota de la materia");
                ArregloEstudiantes[i].materia3.setNota(Convert.ToDouble(Console.ReadLine()));
                //Materia 4
                Console.WriteLine("\nCuarta materia del estudiante: ");
                Console.WriteLine("\nNombre de la materia: ");
                ArregloEstudiantes[i].materia4.nombre = Console.ReadLine();
                Console.WriteLine("\nNota de la materia");
                ArregloEstudiantes[i].materia4.setNota(Convert.ToDouble(Console.ReadLine()));
                Console.Clear();
            }
            //Imprimir Estructura
            for (int i = 0; i < ArregloEstudiantes.Length; i++)
            {
                Console.WriteLine("\nEstudiante número {0}", i + 1);
                Console.WriteLine("\nNombre: {0}", ArregloEstudiantes[i].nombre);
                Console.WriteLine("\nCarnet: {0}", ArregloEstudiantes[i].carnet);
                Console.WriteLine("\nCarrera: {0}", ArregloEstudiantes[i].carrera);
                //Materia 1
                Console.WriteLine("\n{0}", ArregloEstudiantes[i].materia1.nombre);
                Console.WriteLine("\nNota: {0}", ArregloEstudiantes[i].materia1.getNota());
                Console.WriteLine("\n{0}", Resultado(ArregloEstudiantes[i].materia1.getNota()));
                //Materia 2
                Console.WriteLine("\n{0}", ArregloEstudiantes[i].materia2.nombre);
                Console.WriteLine("\nNota: {0}", ArregloEstudiantes[i].materia2.getNota());
                Console.WriteLine("\n{0}", Resultado(ArregloEstudiantes[i].materia2.getNota()));
                //Materia 3
                Console.WriteLine("\n{0}", ArregloEstudiantes[i].materia3.nombre);
                Console.WriteLine("\nNota: {0}", ArregloEstudiantes[i].materia3.getNota());
                Console.WriteLine("\n{0}", Resultado(ArregloEstudiantes[i].materia3.getNota()));
                //Materia 4
                Console.WriteLine("\n{0}", ArregloEstudiantes[i].materia4.nombre);
                Console.WriteLine("\nNota: {0}", ArregloEstudiantes[i].materia4.getNota());
                Console.WriteLine("\n{0}", Resultado(ArregloEstudiantes[i].materia4.getNota()));
            }
        }
    }
}