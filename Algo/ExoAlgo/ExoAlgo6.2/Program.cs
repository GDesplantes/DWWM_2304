using System.Security.Cryptography;

namespace ExoAlgo6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int nombreOrdi = random.Next(0, 3);
            int nombreJoueur;
            int pointOrdi = 0;
            int pointJoueur = 0;

            Console.WriteLine("Bienvenue dans le jeu du 0-2");


            do
            {
                Console.WriteLine("l'ordinateur choisit une valeur entre 0 et 2");

                nombreOrdi = random.Next(0, 3);
                do
                {
                    Console.WriteLine("Veuillez choisir un nombre entre 0 et 2");

                    nombreJoueur = int.Parse(Console.ReadLine());

                }
                while (nombreJoueur > 2);

                if (nombreJoueur >= 0)
                {

                    int difference = Math.Abs(nombreJoueur - nombreOrdi);

                    switch (difference)
                    {
                        case 0:
                            Console.WriteLine("Nombre joueur = " + nombreJoueur + " Nombre ordi = " + nombreOrdi);
                            Console.WriteLine("les deux nombres sont identiques il n'y a donc aucun point de distribué\n");
                            Console.WriteLine("Compteur joueur = " + pointJoueur + " Compteur ordi = " + pointOrdi);
                            break;

                        case 1:
                            if (nombreOrdi < nombreJoueur)
                            {
                                Console.WriteLine("Nombre joueur = " + nombreJoueur + " Nombre ordi = " + nombreOrdi);
                                Console.WriteLine("Un point pour le Joueur Ordi\n");
                                pointOrdi++;
                                Console.WriteLine("Compteur joueur = " + pointJoueur + " Compteur ordi = " + pointOrdi);
                            }
                            else
                            {
                                Console.WriteLine("Nombre joueur = " + nombreJoueur + " Nombre ordi = " + nombreOrdi);
                                Console.WriteLine("Un point pour le Joueur humain\n");
                                pointJoueur++;
                                Console.WriteLine("Compteur joueur = " + pointJoueur + " Compteur ordi = " + pointOrdi + "\n");
                            }
                            break;

                        case 2:
                            if (nombreOrdi > nombreJoueur)
                            {
                                Console.WriteLine("Nombre joueur = " + nombreJoueur + " Nombre ordi = " + nombreOrdi);
                                Console.WriteLine("Un point pour le Joueur Ordi\n");
                                pointOrdi++;
                                Console.WriteLine("Compteur joueur = " + pointJoueur + " Compteur ordi = " + pointOrdi + "\n");
                            }
                            else
                            {
                                Console.WriteLine("Nombre joueur = " + nombreJoueur + " Nombre ordi = " + nombreOrdi);
                                Console.WriteLine("Un point pour le Joueur Ordi\n");
                                pointJoueur++;
                                Console.WriteLine("Compteur joueur = " + pointJoueur + " Compteur ordi = " + pointOrdi + "\n" );
                            }
                            break;
                        default:
                            break;
                    }
                }


            }
                
            while (!(pointJoueur >= 10 || pointOrdi >= 10));
           
            if (pointOrdi >= 10)
            {
                Console.WriteLine("Un joueur est arrivé à 10 points ");
                Console.WriteLine("Victoire pour le joueur ORDI");
            }
            else
            {
                Console.WriteLine(" Un joueur est arrivé à 10 points");
                Console.WriteLine("Victoire pour le joueur humain");
            }

        }
    }
}