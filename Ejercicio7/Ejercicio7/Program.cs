using System;

namespace MiNamespace
{
    class Persona
    {
        private string nombre;
        private int edad;
        private string dni;
        private char sexo;
        private double peso;
        private double altura;

        private const char SexoPorDefecto = 'H';

        // Constructor por defecto
        public Persona()
        {
            InicializarValoresPorDefecto("", 0, SexoPorDefecto);
        }

        // Constructor con nombre, edad y sexo; el resto por defecto
        public Persona(string nombre, int edad, char sexo)
        {
            InicializarValoresPorDefecto(nombre, edad, sexo);
        }

        // Constructor con todos los atributos como parámetro
        public Persona(string nombre, int edad, string dni, char sexo, double peso, double altura)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.dni = dni;
            this.sexo = ComprobarSexo(sexo);
            this.peso = peso;
            this.altura = altura;
        }

        // Método para inicializar valores por defecto
        private void InicializarValoresPorDefecto(string nombre, int edad, char sexo)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.dni = GenerarDNI();
            this.sexo = ComprobarSexo(sexo);
            this.peso = 0.0;
            this.altura = 0.0;
        }

        // Método para comprobar el sexo, asigna H si no es válido
        private char ComprobarSexo(char sexo)
        {
            return (sexo == 'H' || sexo == 'M') ? sexo : SexoPorDefecto;
        }

        // Método para generar un DNI aleatorio
        private string GenerarDNI()
        {
            Random random = new Random();
            int dniAleatorio = random.Next(10000000, 99999999);
            char letra = ObtenerLetraDNI(dniAleatorio);
            return $"{dniAleatorio}-{letra}";
        }

        // Método para obtener la letra del DNI
        private char ObtenerLetraDNI(int dni)
        {
            string letrasDNI = "TRWAGMYFPDXBNJZSQVHLCKE";
            int resto = dni % 23;
            return letrasDNI[resto];
        }

        // Mostrar información de la persona
        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Edad: {edad}");
            Console.WriteLine($"DNI: {dni}");
            Console.WriteLine($"Sexo: {sexo}");
            Console.WriteLine($"Peso: {peso} kg");
            Console.WriteLine($"Altura: {altura} cm");
        }

        // Método Main para demostrar la clase Persona (opcional)
        static void Main(string[] args)
        {
            Persona persona1 = new Persona();
            Persona persona2 = new Persona("David", 25, 'H');
            Persona persona3 = new Persona("Oriol", 19, "47863195-B", 'H', 67, 175.0);

            Console.WriteLine("Información de la persona 1:");
            persona1.MostrarInformacion();

            Console.WriteLine("\nInformación de la persona 2:");
            persona2.MostrarInformacion();

            Console.WriteLine("\nInformación de la persona 3:");
            persona3.MostrarInformacion();
        }
    }
}
