using System;
using System.Collections.Generic;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace TrabajoFinal
{
    internal class Program
    {
        public static List<ALUMNO> Alumnos = new List<ALUMNO>();
        public static double Promedio;
        public static void AgregarL(int indicen)
        { //listado para agrega un estudiantes 
            Alumnos.Add(new ALUMNO());
            Console.WriteLine("Ingrese  el Id del estudiante");
            Alumnos[indicen].IdAlumnos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese  el Nombre del estudiante");
            Alumnos[indicen].Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la edad del estudiante");
            Alumnos[indicen].Edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese las calificaciones del estudiante");
            for (int i = 1; i <= 1; i++) // Aqui van agregar las calificaciones 
            {
                Console.WriteLine($"Introduzca la calificacion del las  #{i}");
                Alumnos[indicen].Calificacion.Add(Convert.ToDouble(Console.ReadLine()));
            }

        } // hay esta el la lista 
        public static void selecionar()
        {
            Console.Write("===Sistema de Gestion Estudiantil===");
            Console.WriteLine("\n");
            Console.WriteLine("1. Agregar un nuevo estudiante");
            Console.WriteLine("2. Listado de los estudiantes");
            Console.WriteLine("3. Buscar Estudiantes por Id");
            Console.WriteLine("4. Calcular del promedio");
            Console.WriteLine("5. Salir del Programa\n");
            Console.WriteLine("Seleciones una de las opciones");
                int Opciones = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            switch (Opciones)
            {
                case 1:
                    Console.WriteLine("==Agregar un nuevo estudiante==\n");
                    Console.WriteLine("*****************************************************************************************************************");
                    AgregarAlumno();
                    
                    break;
                case 2:
                    Console.WriteLine("Listado de los estudiantes");
                    ListarAlumnos(Alumnos);
                    break;
                case 3:
                    Console.WriteLine("Buscar Estudiantes por Id");
                    BuscarEstudiantes();
                    break;
                case 4:
                    Console.WriteLine("Calcular del promedio");
                    break;
                case 5:
                    //Console.WriteLine("Salir del Programa");
                    Salir();




                    break;

                default:
                    Console.WriteLine("Seleciones la opcion correcto");
                    break;
            }
        } // parte inicil del codigo 

        public static void AgregarAlumno()
        {   
            Double Promedio;

            AgregarL(0);
            int ind =0; 
            Console.WriteLine("Deseas agregar mas Estudiantes Y/N ? ");
            string indice = Console.ReadLine();
            while (indice == "Y")
            {
                ind++;
                AgregarL(ind);
                Console.WriteLine("Deseas agregar mas Estudiantes Y/N ? ");
                indice = Console.ReadLine();
            }
            
                selecionar();

          } // listo en parte 
        public static void ListarAlumnos(List<ALUMNO> alumnos)
        {

            foreach (var item in Alumnos)// Promedio 
            {
                Promedio = item.Calificacion.Sum() / 5; // aqui se esta sumando los valores del listado y se esta dividiendo 
                Console.WriteLine("*****************************************************************************************************************");
                Console.WriteLine($"Estudiantes {item.Nombre}");
                Console.WriteLine($"El estudiante con el ID: {item.IdAlumnos} \nEl nombre: {item.Nombre} \nla edad: {item.Edad} \nLas calificaciones son: {string.Join(",", item.Calificacion)} \nEl Promedio: {Promedio}");
            }
            Console.WriteLine("*****************************************************************************************************************");
            Console.ReadLine(); // para que pare el sistema y no entre de golpe 
            selecionar();
        } //listo 

       /* public static void ELiminar()
        {
            Console.WriteLine("Cual Estudiantes quieres eliminar");
            int IdEliminar = int.Parse(Console.ReadLine());
            Alumnos.RemoveAt(Id)
        }   */

        public static void Salir()
        {
            string Verificacion;
            Console.WriteLine("Deseas Salir del Programa Y/N ");
            Verificacion = Console.ReadLine();
            
            if (Verificacion == "Y"  )
            {
                Console.WriteLine("Salido Exitosamente");
                Environment.Exit(0);
               
            }if (Verificacion == "N")
            { Console.WriteLine("Seleciones tu opcion");
                selecionar();
            }else 
            { Console.WriteLine("Selecion la opcion correcta");
                return;    
            }
        }

        public static void BuscarEstudiantes()

        {
            Console.WriteLine("SELECIONES EL ID DEL ESTUDIANTES BUSCADO");
            int IdBuscado = int.Parse(Console.ReadLine());
             
            foreach (var item in Alumnos)
                
            {
                if (item.IdAlumnos == IdBuscado)
                {
                    Promedio = item.Calificacion.Sum() / 5; // aqui se esta sumando los valores del listado y se esta dividiendo 
                    Console.WriteLine("*****************************************************************************************************************");
                    Console.WriteLine($"Estudiantes {item.Nombre}");
                    Console.WriteLine($"El estudiante con el ID: {item.IdAlumnos} \nEl nombre: {item.Nombre} \nla edad: {item.Edad} \nLas calificaciones son: {string.Join(",", item.Calificacion)} \nEl Promedio: {Promedio}");
                }
            }
            Console.WriteLine("*****************************************************************************************************************");
            Console.ReadLine(); // para que pare el sistema y no entre de golpe 
            selecionar();
        }

       

     


       
        static void Main(string[] args)
        {
            selecionar();
        }
    }  
}