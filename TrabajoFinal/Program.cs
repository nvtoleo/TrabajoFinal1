using System;
using System.Collections.Generic;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace TrabajoFinal
{
    internal class Program
    {
        public static List<ALUMNO> Alumnos = new List<ALUMNO>();
        public static double Promedio;
        public static int Prom = 4;
        public static int Incremento = 1;
        public static int IndCre = 0;
        public static bool valor = true;
        public static void AgregarL(int indicen)
        { //listado para agrega un estudiantes 
            Alumnos.Add(new ALUMNO());
            //Console.WriteLine("Ingrese  el Id del estudiante");
            //Alumnos[indicen].IdAlumnos = Convert.ToInt32(Console.ReadLine());
            Alumnos[indicen].IdAlumnos = Incremento++;
            Console.WriteLine("Ingrese  el Nombre del estudiante");
            Alumnos[indicen].Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la edad del estudiante");
            Alumnos[indicen].Edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese las calificaciones del estudiante");

            for (int i = 1; i <= 4; i++) // Aqui van agregar las calificaciones 
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
                    PromedioAlumno();
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
            //string indice = "Y";
            
            while (valor = true)
            {
                AgregarL(IndCre++);
                Console.WriteLine("Deseas agregar mas Estudiantes Y/N ? ");
                string indice = Console.ReadLine().ToUpper();
                if (indice == "Y") 
                { 
                    valor = true; 
                }
                else
                {
                    valor = false;
                }
            } Console.Clear();
                selecionar();

          } // listo en parte 
        public static void ListarAlumnos(List<ALUMNO> alumnos)
        {

            foreach (var item in Alumnos)// Promedio 
            {
                
                    Promedio = item.Calificacion.Sum() / 4; // aqui se esta sumando los valores del listado y se esta dividiendo 
                    Console.WriteLine("*****************************************************************************************************************");
                    Console.WriteLine($"Estudiantes {item.Nombre}");
                    Console.WriteLine($"El estudiante con el ID: {item.IdAlumnos} \nEl nombre: {item.Nombre} \nla edad: {item.Edad} \nLas calificaciones son: {string.Join(",", item.Calificacion)} \nEl Promedio: {Promedio}");
            
            }
            Console.WriteLine("No Hay nada en la lista");
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

        public static void PromedioAlumno()
        {
            Console.WriteLine("SELECIONES EL ID DEL ESTUDIANTES BUSCADO");
            int IdBuscado = int.Parse(Console.ReadLine());

            foreach (var item in Alumnos)

            {
                if (item.IdAlumnos == IdBuscado)
                {
                    Promedio = item.Calificacion.Sum() / Prom; // aqui se esta sumando los valores del listado y se esta dividiendo 
                    Console.WriteLine("*****************************************************************************************************************");
                    Console.WriteLine($"Estudiantes {item.Nombre}");
                    Console.WriteLine($"Tu promedio es:  {Promedio}");
                }
                Console.WriteLine("El Alumno no existe");
                Console.ReadLine();
                selecionar();
            }
        }

        public static void Salir()
        {       
            while (valor == true)
            {
                string Verificacion;
                Console.WriteLine("Deseas Salir del Programa Y/N ");
               // Verificacion = Console.ReadLine();
                Verificacion = Console.ReadLine().ToUpper();

                if (Verificacion == "Y")
                {
                    Console.WriteLine("Salido Exitosamente");
                    Environment.Exit(0);

                }
                if (Verificacion == "N")
                {
                    Console.WriteLine("Seleciones tu opcion");
                    //valor = false;
                    Console.Clear();
                    selecionar();
                }
                else
                {
                    Console.WriteLine("Selecion la opcion correcta");
                     valor = true;

                }
            }
        } // listo 

        public static void BuscarEstudiantes()

        {
            Console.WriteLine("SELECIONES EL ID DEL ESTUDIANTES BUSCADO");
            int IdBuscado = int.Parse(Console.ReadLine());
             
            foreach (var item in Alumnos)
                
            { 
                if (item.IdAlumnos == IdBuscado)
                {
                    Promedio = item.Calificacion.Sum() / Prom; // aqui se esta sumando los valores del listado y se esta dividiendo 
                    Console.WriteLine("*****************************************************************************************************************");
                    Console.WriteLine($"Estudiantes {item.Nombre}");
                    Console.WriteLine($"El estudiante con el ID: {item.IdAlumnos} \nEl nombre: {item.Nombre} \nla edad: {item.Edad} \nLas calificaciones son: {string.Join(",", item.Calificacion)} \nEl Promedio: {Promedio}");
                }
            }
            Console.WriteLine("No hay ningun Alumno Resgistrado");
            Console.WriteLine("*****************************************************************************************************************");
            Console.ReadLine(); // para que pare el menu de inicio  y no entre de golpe 
            selecionar();
        }

        static void Main(string[] args)
        {
            selecionar();
        }
    }  
}
