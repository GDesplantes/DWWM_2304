namespace ExoAlgo3._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nombre;

            Console.WriteLine("Saisissez un nombre");

            nombre=int.Parse(Console.ReadLine());

            Console.WriteLine("Voici ces diviseurs");

            for(int diviseur=1;diviseur<nombre;diviseur++)
            {
                if(nombre%diviseur==0)
                {
                    Console.WriteLine(diviseur);
                }

            }

        }
    }
}