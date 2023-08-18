using System;

namespace Ejercicio5
{
    class Libro
    {
        private string autor;
        private string titulo;
        private string ubicacion;

        // Métodos Set para los atributos
        public void SetAutor(string nuevoAutor)
        {
            autor = nuevoAutor;
        }

        public void SetTitulo(string nuevoTitulo)
        {
            titulo = nuevoTitulo;
        }

        public void SetUbicacion(string nuevaUbicacion)
        {
            ubicacion = nuevaUbicacion;
        }

        // Métodos Get para los atributos
        public string GetAutor()
        {
            return autor;
        }

        public string GetTitulo()
        {
            return titulo;
        }

        public string GetUbicacion()
        {
            return ubicacion;
        }

        // Método para mostrar la información del libro
        public void MostrarInformacion()
        {
            Console.WriteLine("Información del libro:");
            Console.WriteLine($"Título: {titulo}");
            Console.WriteLine($"Autor: {autor}");
            Console.WriteLine($"Ubicación: {ubicacion}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Crear un objeto de la clase Libro
            Libro miLibro = new Libro();

            // Establecer valores usando métodos Set para el libro de Harry Potter
            miLibro.SetTitulo("Harry Potter y la Piedra Filosofal");
            miLibro.SetAutor("J.K. Rowling");
            miLibro.SetUbicacion("Estantería B");

            // Mostrar información del libro usando el método MostrarInformacion
            miLibro.MostrarInformacion();

            // Esperar a que el usuario presione una tecla antes de salir
            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
