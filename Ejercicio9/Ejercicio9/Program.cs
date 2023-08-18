using System;


namespace Ejercicio9
{
    class Electrodomestico
    {
        protected double precioBase;
        protected string color;
        protected char consumoEnergetico;
        protected double peso;

        protected const string ColorPorDefecto = "blanco";
        protected const char ConsumoEnergeticoPorDefecto = 'F';
        protected const double PrecioBasePorDefecto = 100.0;
        protected const double PesoPorDefecto = 5.0;

        // Constructor por defecto
        public Electrodomestico()
        {
            InicializarValoresPorDefecto(PrecioBasePorDefecto, PesoPorDefecto);
        }

        // Constructor con precio y peso; el resto por defecto
        public Electrodomestico(double precioBase, double peso)
        {
            InicializarValoresPorDefecto(precioBase, peso);
        }

        // Constructor con todos los atributos como parámetro
        public Electrodomestico(double precioBase, string color, char consumoEnergetico, double peso)
        {
            this.precioBase = precioBase;
            this.color = ComprobarColor(color);
            this.consumoEnergetico = ComprobarConsumoEnergetico(consumoEnergetico);
            this.peso = peso;
        }

        // Método para inicializar valores por defecto
        private void InicializarValoresPorDefecto(double precioBase, double peso)
        {
            this.precioBase = precioBase;
            this.color = ColorPorDefecto;
            this.consumoEnergetico = ConsumoEnergeticoPorDefecto;
            this.peso = peso;
        }

        // Método para comprobar y asignar color
        private string ComprobarColor(string color)
        {
            string colorValido = ColorPorDefecto;
            string[] coloresValidos = { "blanco", "negro", "rojo", "azul", "gris" };

            foreach (string colorValidoActual in coloresValidos)
            {
                if (colorValidoActual.Equals(color, StringComparison.OrdinalIgnoreCase))
                {
                    colorValido = colorValidoActual;
                    break;
                }
            }
            return colorValido;
        }

        // Método para comprobar y asignar consumo energético
        private char ComprobarConsumoEnergetico(char consumoEnergetico)
        {
            char consumoValido = ConsumoEnergeticoPorDefecto;
            char[] consumosValidos = { 'A', 'B', 'C', 'D', 'E', 'F' };

            foreach (char consumoValidoActual in consumosValidos)
            {
                if (char.ToUpper(consumoEnergetico) == consumoValidoActual)
                {
                    consumoValido = consumoValidoActual;
                    break;
                }
            }
            return consumoValido;
        }

        // Método para mostrar información del electrodoméstico
        public virtual void MostrarInformacion()
        {
            Console.WriteLine("Información del electrodoméstico:");
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine($"Precio Base: {precioBase} \u20AC");
            Console.WriteLine($"Color: {color}");
            Console.WriteLine($"Consumo Energético: {consumoEnergetico}");
            Console.WriteLine($"Peso: {peso} kg");
        }

        static void Main(string[] args)
        {
            Electrodomestico electrodomestico1 = new Electrodomestico();
            Electrodomestico electrodomestico2 = new Electrodomestico(250.0, 8.0);
            Electrodomestico electrodomestico3 = new Electrodomestico(350.0, "rojo", 'B', 10.0);

            Console.WriteLine("Electrodoméstico 1:");
            electrodomestico1.MostrarInformacion();

            Console.WriteLine("\nElectrodoméstico 2:");
            electrodomestico2.MostrarInformacion();

            Console.WriteLine("\nElectrodoméstico 3:");
            electrodomestico3.MostrarInformacion();
        }
    }
}
