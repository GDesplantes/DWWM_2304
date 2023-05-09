namespace ExoAlgo3._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nombre;
            int diviseur;
            
            Console.WriteLine("Saisissez un nombre");

            nombre = int.Parse(Console.ReadLine());
            diviseur = nombre - 1;

            int calculPremier = nombre % diviseur;

            do
            {
                Console.WriteLine(calculPremier);
                diviseur--;
            }

            while (nombre % diviseur != 0);


            if (diviseur == 1)
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