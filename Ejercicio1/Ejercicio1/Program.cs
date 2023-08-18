using System;

namespace Ejercicio1
{
    class Alumno
    {
        private string nombre;
        private int edad;

        // Constructor para cargar los datos del alumno
        public Alumno(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        // Método para imprimir los datos del alumno
        public void ImprimirDatos()
        {
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Edad: {edad}");
        }

        // Método para imprimir si el alumno es mayor de edad
        public void MensajeMayorEdad()
        {
            if (edad >= 18)
            {
                Console.WriteLine("Es mayor de edad.");
            }
            else
            {
                Console.WriteLine("No es mayor de edad.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Crear objetos Alumno y mostrar sus datos y edad
            Alumno alumno = new Alumno("David", 25);
            Alumno alumno2 = new Alumno("Oriol", 16);

            Console.WriteLine("Datos del primer alumno:");
            alumno.ImprimirDatos();
            alumno.MensajeMayorEdad();

            Console.WriteLine("\nDatos del segundo alumno:");
            alumno2.ImprimirDatos();
            alumno2.MensajeMayorEdad();

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}