﻿using System;

namespace TrabajoFinal
{
    internal class Program
    {

        public static void AgregarAlumnos()
        {
            List<string> Alumnos = new List<string>();
            Alumnos.Add(Console.Read().ToString());

            




        }

            
        
        static void Main(string[] args)
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
                    Console.WriteLine("Salir del Programa");
                    break;

                default:
                    Console.WriteLine("Seleciones la opcion correcto");
                    break;
            }

        }
    }
}