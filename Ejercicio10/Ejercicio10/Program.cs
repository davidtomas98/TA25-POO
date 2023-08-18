using System;

namespace Ejercicio10
{
    class Serie
    {
        private string titulo;
        private int numeroTemporadas;
        private bool entregado;
        private string genero;
        private string creador;

        private const int NumeroTemporadasPorDefecto = 3;
        private const bool EntregadoPorDefecto = false;
        private const string GeneroPorDefecto = "";
        private const string CreadorPorDefecto = "";

        // Constructor por defecto
        public Serie()
        {
            InicializarValoresPorDefecto(NumeroTemporadasPorDefecto, EntregadoPorDefecto, GeneroPorDefecto, CreadorPorDefecto);
        }

        // Constructor con el título y creador; el resto por defecto
        public Serie(string titulo, string creador)
        {
            InicializarValoresPorDefecto(NumeroTemporadasPorDefecto, EntregadoPorDefecto, GeneroPorDefecto, creador);
            this.titulo = titulo;
        }

        // Constructor con todos los atributos excepto entregado
        public Serie(string titulo, int numeroTemporadas, string genero, string creador)
        {
            InicializarValoresPorDefecto(numeroTemporadas, EntregadoPorDefecto, genero, creador);
            this.titulo = titulo;
        }

        // Método para inicializar valores por defecto
        private void InicializarValoresPorDefecto(int numeroTemporadas, bool entregado, string genero, string creador)
        {
            this.numeroTemporadas = numeroTemporadas;
            this.entregado = entregado;
            this.genero = genero;
            this.creador = creador;
        }

        // Método para mostrar información de la serie
        public void MostrarInformacion()
        {
            Console.WriteLine("Información de la serie:");
            Console.WriteLine($"Título: {titulo}");
            Console.WriteLine($"Número de Temporadas: {numeroTemporadas}");
            Console.WriteLine($"Entregado: {(entregado ? "Sí" : "No")}");
            Console.WriteLine($"Género: {genero}");
            Console.WriteLine($"Creador: {creador}");
        }

        static void Main(string[] args)
        {
            Serie serie1 = new Serie();
            Serie serie2 = new Serie("Breaking Bad", "Vince Gilligan");
            Serie serie3 = new Serie("Game of Thrones", 8, "Fantasía", "David Benioff y D. B. Weiss");

            Console.WriteLine("Serie 1:");
            serie1.MostrarInformacion();

            Console.WriteLine("\nSerie 2:");
            serie2.MostrarInformacion();

            Console.WriteLine("\nSerie 3:");
            serie3.MostrarInformacion();
        }
    }
}
