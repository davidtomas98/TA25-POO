namespace Ejercicio4
{
    using System;

    class PruebaPersona
    {
        public static void Main(string[] args)
        {
            // Crear objetos de tipo Persona
            Persona persona1 = new Persona();
            Persona persona2 = new Persona();

            // Pedir y asignar nombres a las personas
            Console.Write("Ingresa el nombre de la primera persona: ");
            string nombrePersona1 = Console.ReadLine();
            persona1.SetNombre(nombrePersona1);

            Console.Write("Ingresa el nombre de la segunda persona: ");
            string nombrePersona2 = Console.ReadLine();
            persona2.SetNombre(nombrePersona2);

            // Mostrar saludos de las personas
            Console.WriteLine("\nSaludos:");
            persona1.Saludar();
            persona2.Saludar();

            // Esperar a que el usuario presione una tecla antes de salir
            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
