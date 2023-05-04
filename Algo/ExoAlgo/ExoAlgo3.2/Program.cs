namespace ExoAlgo3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string saisie;
            string MDP = "formation";

            int essaie = 3;



            do
            {

                Console.WriteLine("Saisissez votre Mot De Passe");

                saisie = Console.ReadLine();
                
                if (saisie != MDP)
                {
                    essaie--;
                    if (essaie > 0)
                    {

                        Console.WriteLine("Erreur mot de passe plus que " + essaie + " essaies");
                    }
                    else
                    {
                        Console.WriteLine("Votre compte est bloqué");
                    }

                }
                else
                {
                    Console.WriteLine("Vous êtes connecté");
                }
             
               

            }

            while (saisie != MDP && essaie > 0);
                
            
            

            Console.WriteLine("Fin de programme");
            Console.ReadLine();

            }
        }
}
