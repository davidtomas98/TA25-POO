using System;

namespace Ejercicio6
{
    class Coche
    {
        private string marca;
        private string modelo;
        private int cilindrada;
        private double potencia;

        // Métodos Set para los atributos
        public void SetMarca(string nuevaMarca)
        {
            marca = nuevaMarca;
        }

        public void SetModelo(string nuevoModelo)
        {
            modelo = nuevoModelo;
        }

        public void SetCilindrada(int nuevaCilindrada)
        {
            cilindrada = nuevaCilindrada;
        }

        public void SetPotencia(double nuevaPotencia)
        {
            potencia = nuevaPotencia;
        }

        // Métodos Get para los atributos
        public string GetMarca()
        {
            return marca;
        }

        public string GetModelo()
        {
            return modelo;
        }

        public int GetCilindrada()
        {
            return cilindrada;
        }

        public double GetPotencia()
        {
            return potencia;
        }

        // Método para mostrar la información del coche
        public void MostrarInformacion()
        {
            Console.WriteLine("Información del coche:");
            Console.WriteLine($"Marca: {marca}");
            Console.WriteLine($"Modelo: {modelo}");
            Console.WriteLine($"Cilindrada: {cilindrada} cc");
            Console.WriteLine($"Potencia: {potencia} HP");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Crear un objeto de la clase Coche
            Coche miCoche = new Coche();

            // Establecer valores usando métodos Set para un coche Mercedes C
            miCoche.SetMarca("Mercedes");
            miCoche.SetModelo("Clase C");
            miCoche.SetCilindrada(560);
            miCoche.SetPotencia(180.0);

            // Mostrar información del coche usando el método MostrarInformacion
            miCoche.MostrarInformacion();

            // Esperar a que el usuario presione una tecla antes de salir
            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
