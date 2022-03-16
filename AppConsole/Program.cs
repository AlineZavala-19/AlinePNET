// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
namespace AppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a la Ruleta");
            int saldo = 300;
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Tu saldo es de "+saldo);
                if (saldo == 0)
                {
                Console.WriteLine();
                Console.WriteLine("No tienes dinero, gracias por jugar.");
                break;
                }
                Console.WriteLine();
                Console.WriteLine("Introduce cuanto quieres apostar, -1 para salir:");
                Console.WriteLine();
                int apuesta = int.Parse(Console.ReadLine());
                if (apuesta == -1)
                {
                break;
                }
                if(apuesta > saldo)
                {
                Console.WriteLine("No tienes dinero");
                continue;
                }
                Console.WriteLine();
                Console.WriteLine("Introduce el numero por el que quieres apostar:");
                Console.WriteLine();
                int numeroApostado = int.Parse(Console.ReadLine());
                Random Generar = new Random();
                int aleatorio = Generar. Next(0, 37);
                if(numeroApostado == aleatorio)
                {
                Console.WriteLine();
                Console.WriteLine("¡Enhorabuena, ha caído tu número!");
                saldo = +apuesta * 10;
                }
                else
                {
                Console.WriteLine();
                Console.WriteLine("Lo siento a caido el número "+ aleatorio);
                //saldo -= apuesta;
                }
            }
            Console.ReadKey();
        }
    }
}