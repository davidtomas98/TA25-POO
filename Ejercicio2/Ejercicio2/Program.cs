using System;

namespace Ejercicio2
{
    class Empleado
    {
        private string nombre;
        private double sueldo;

        // Constructor para cargar los datos del empleado
        public Empleado(string nombre, double sueldo)
        {
            this.nombre = nombre;
            this.sueldo = sueldo;
        }

        // Método para imprimir los datos del empleado
        public void ImprimirDatos()
        {
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Sueldo: {sueldo}");
        }

        // Método para imprimir si el empleado debe pagar impuestos
        public void MensajeImpuestos()
        {
            if (sueldo > 3000)
            {
                Console.WriteLine("Debe pagar impuestos.");
            }
            else
            {
                Console.WriteLine("No debe pagar impuestos.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Crear objetos Empleado y mostrar sus datos e impuestos
            Empleado empleado = new Empleado("David", 1700);
            Empleado empleado2 = new Empleado("Maria", 4000);

            Console.WriteLine("Datos del primer empleado:");
            empleado.ImprimirDatos();
            empleado.MensajeImpuestos();

            Console.WriteLine("\nDatos del segundo empleado:");
            empleado2.ImprimirDatos();
            empleado2.MensajeImpuestos();

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
