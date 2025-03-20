using System;
using System.Security.Cryptography.X509Certificates;

namespace TrabajoFinal
{
    internal class Program
    {
        
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

        public static void AgregarAlumno()
        {
            Double Suma,Promedio;
            List<ALUMNO> Alumnos = new List<ALUMNO>();
            Alumnos.Add(new ALUMNO());
            Console.WriteLine("Digitar el Id del estudiante");
            Alumnos[0].IdAlumnos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digitar el Nombre del estudiante");
            Alumnos[0].Nombre = Console.ReadLine();
            Console.WriteLine("Digitar la edad del estudiante");
            Alumnos[0].Edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digitar las calificaciones del estudiante");

            for (int i = 1; i <= 5; i++) {
                Console.WriteLine($"Introduzca la calificacion #{i}");
                Alumnos[0].Calificacion.Add(Convert.ToDouble(Console.ReadLine()));
            }
            foreach (var item in Alumnos)
            {

                Promedio = item.Calificacion.Sum() / 5;
                Console.WriteLine($"El estudiante con el ID: {item.IdAlumnos} \n El nombre: {item.Nombre} \n la edad: {item.Edad} \n Las calificaciones son: {string.Join(",", item.Calificacion)} \n El Promedio: {Promedio}");

            }
        }

         public static void selecionar()
        {
            Console.Write("===Sistema de Gestion Estudiantil===");
            Console.WriteLine("\n");
            Console.WriteLine("1. Agregar un nuevo estudiante");
            Console.WriteLine("2. Listado de los estudiantes");
            Console.WriteLine("3. Buscar Estudiantes por Id");
            Console.WriteLine("4. Calcular del promedio");
            Console.WriteLine("5. Salir del Programa\n");
            Console.WriteLine("Seleciones la opciones ");

            int Opciones = int.Parse(Console.ReadLine());

            switch (Opciones)
            {
                case 1:
                    Console.WriteLine("Agrege un nuevio estudiantes");
                    AgregarAlumno();
                    break;
                case 2:
                    Console.WriteLine("Listado de los estudiantes");
                    break;
                case 3:
                    Console.WriteLine("Buscar Estudiantes por Id");
                    break;
                case 4:
                    Console.WriteLine("Calcular del promedio");
                    break;
                case 5:
                    //Console.WriteLine("Salir del Programa");
                    Salir();
                    string reg = Console.ReadLine();
                   
                    
                    
                    break;

                default:
                    Console.WriteLine("Seleciones la opcion correcto");
                    break;
            }
        }
        
       
        static void Main(string[] args)

        {
            selecionar();
        }
    }  
}