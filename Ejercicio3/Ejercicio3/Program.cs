using System;

namespace Ejercicio3
{
    class Operaciones
    {
        private int valor1;
        private int valor2;

        // Constructor para cargar los valores para operaciones
        public Operaciones(int valor1, int valor2)
        {
            this.valor1 = valor1;
            this.valor2 = valor2;
        }

        // Métodos para realizar operaciones
        public int Suma()
        {
            return valor1 + valor2;
        }

        public int Resta()
        {
            return valor1 - valor2;
        }

        public int Multiplicacion()
        {
            return valor1 * valor2;
        }

        public double Division()
        {
            if (valor2 != 0)
            {
                return (double)valor1 / valor2;
            }
            else
            {
                throw new DivideByZeroException("No se puede dividir por cero.");
            }
        }

        // Método para imprimir los resultados de las operaciones
        public void ImprimirResultados()
        {
            Console.WriteLine($"Suma: {Suma()}");
            Console.WriteLine($"Resta: {Resta()}");
            Console.WriteLine($"Multiplicación: {Multiplicacion()}");
            try
            {
                Console.WriteLine($"División: {Division()}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"División: Error - {ex.Message}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Crear un objeto Operaciones y mostrar los resultados
            Operaciones operaciones = new Operaciones(10, 5);
            Operaciones operaciones2 = new Operaciones(10, 0);

            Console.WriteLine("Operaciones con valores válidos:");
            operaciones.ImprimirResultados();

            Console.WriteLine("\nOperaciones con valor de división por cero:");
            operaciones2.ImprimirResultados();

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
