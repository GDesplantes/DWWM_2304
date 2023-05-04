namespace ExoAlgo3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string saisie;

            

            


            do
            {
                Console.WriteLine("Saisissez votre prénom");
                saisie = Console.ReadLine();
            }

            while (saisie.Length < 2); 

            Console.WriteLine("Bonjour " + saisie);

            

        }
    }
}