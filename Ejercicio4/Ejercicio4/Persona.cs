namespace Ejercicio4
{
    using System;

    class Persona
    {
        private string nombre;

        // Método para asignar un nuevo nombre a la persona
        public void SetNombre(string nuevoNombre)
        {
            nombre = nuevoNombre;
        }

        // Método para que la persona salude
        public void Saludar()
        {
            Console.WriteLine($"Hola, soy {nombre}.");
        }
    }
}
