using System;
using System.Text;

namespace Ejercicio8
{
    class Password
    {
        private int longitud;
        private string contraseña;

        private const int LongitudPorDefecto = 8;

        // Constructor por defecto
        public Password()
        {
            this.longitud = LongitudPorDefecto;
            GenerarContraseñaAleatoria();
        }

        // Constructor con longitud para generar contraseña aleatoria
        public Password(int longitud)
        {
            this.longitud = longitud;
            GenerarContraseñaAleatoria();
        }

        // Método privado para generar contraseña aleatoria
        private void GenerarContraseñaAleatoria()
        {
            // Definimos la cadena de caracteres que se usará para generar la contraseña
            const string caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()";
            StringBuilder sb = new StringBuilder();

            // Creamos una instancia de Random para generar números aleatorios
            Random random = new Random();
            for (int i = 0; i < longitud; i++)
            {
                // Obtenemos un índice aleatorio para seleccionar un carácter de la cadena
                int indiceCaracter = random.Next(caracteres.Length);
                sb.Append(caracteres[indiceCaracter]);
            }

            contraseña = sb.ToString();
        }

        // Método para mostrar la contraseña generada
        public void MostrarContraseña()
        {
            Console.WriteLine($"Contraseña generada: {contraseña}");
        }

        static void Main(string[] args)
        {
            // Crear objetos Password con diferentes longitudes
            Password password1 = new Password();
            Password password2 = new Password(25);

            // Mostrar las contraseñas generadas
            Console.WriteLine("Contraseña 1:");
            password1.MostrarContraseña();

            Console.WriteLine("\nContraseña 2:");
            password2.MostrarContraseña();
        }
    }
}
