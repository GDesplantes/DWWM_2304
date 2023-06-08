namespace ExoAlgo5._3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string unite;

            Console.WriteLine("Bonjour et bienvenue dans ce programme de convertion de temperature");

            Console.WriteLine("Saisssez une température et précisé une unité (C/F)");
            Console.WriteLine("Cette valeur doit être comprise entre -459,67 et 5 000 000");

            do
            {
                Console.WriteLine("Vous n'avez pas saisie la bonne unité. Rappel (C/F)");
                unite = Console.ReadLine();
            }

            while (unite[unite.Length - 1] != 'C' && unite[unite.Length - 1] != 'F');


           //double nbtemp = Convert.ToDouble(unite);
            
          
            for (int index = 0; index < unite.Length - 2; index++)
            {
                Console.WriteLine();

            }
            
            
            Console.WriteLine("Bonne unité");
            





        }
    }
}