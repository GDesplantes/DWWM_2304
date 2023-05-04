namespace ExoAlgo3._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nombre;
            int diviseur = 1;

            Console.WriteLine("Saisissez un nombre");
            nombre = int.Parse(Console.ReadLine());

            do
            {
                diviseur++;

            }
            while (nombre % diviseur != 0);

            if (nombre == diviseur)
            {
                Console.WriteLine(nombre + " est un nombre premier");
            }
            else
            {
                Console.WriteLine(nombre + " n'est pas un nombre premier");
            }
        }
    }
}