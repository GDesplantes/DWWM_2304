namespace ExoAlgo2._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Boolean ilFaitBeau;
            Boolean bicycletteEnEtat;
            Boolean reparationImmediate;
            
            
            Boolean livreDansBiblioteque;
            
            Boolean gotABibliotequemunicipal;
            
            Boolean lire;*/

            string saisie;
            do
            {
                Console.WriteLine("Est-ce que il fait beau?  oui/non");

                saisie = Console.ReadLine();
            } while (saisie!="oui" && saisie!="non");

            if (saisie == "oui")
            { 
                Console.WriteLine("Est-ce que ma bicyclette est en état? oui/non");
                    
                saisie = Console.ReadLine();

                if (saisie == "oui")
                {
                    Console.WriteLine("J'irais me balader à vélo");
                }
                else if (saisie == "non") 
                {
                    Console.WriteLine("Je passerai cher le garagiste");

                    Console.WriteLine("Est-ce que la réparation sera rapide? oui/non");

                    saisie = Console.ReadLine();

                    if (saisie == "oui") 
                    {
                        Console.WriteLine("Je pourrais me balader à vélo");
                    }
                    else if (saisie == "non") 
                    {
                        Console.WriteLine("j’irai à pied jusqu’à l’étang pour cueillir les joncs");
                    }

                }
            }                 
            else if (saisie == "non")
            {
                Console.WriteLine("Je vais lire");

                Console.WriteLine("Est ce que j'ai toujours le premier tome de Games Of Thrones dans ma bibliotèques? oui/non");

                saisie=Console.ReadLine();

                if (saisie == "oui") 
                {
                    Console.WriteLine("je m’installerai confortablement dans un fauteuil et je me plongerai dans la lecture.");
                }
                else if (saisie == "non") 
                {
                    Console.WriteLine("j’irai l’emprunter à la bibliothèque municipale");

                    Console.WriteLine("Est-ce que le livre sera disponible? oui/non");

                    saisie = Console.ReadLine();

                    if (saisie == "oui") 
                    {
                        Console.WriteLine("j'achèterai le livre puis je rentrerais cher moi pour le lire");
                    }
                    else if (saisie == "non") 
                    {
                        Console.WriteLine("J'achèterai un roman policier puis je rentrerais cher mois pour le lire");
                    }
                }
            }

        }
    }
}