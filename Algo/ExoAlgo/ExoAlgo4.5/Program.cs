namespace ExoAlgo4._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string texte;
            bool autorisation = false;
            bool estUnPalindrome = true;


            Console.WriteLine("Bienvenue dans ce system de vérification de palindrme ");

            Console.WriteLine(" Veuillez rentrer un mot");

            texte = Console.ReadLine();

            while (!autorisation)
            {
                if (texte.Length == 1 || texte[1] == '.')
                {
                    Console.WriteLine("Mot invalide. Veuillez en saisir un autre");
                    autorisation = false;
                    texte = Console.ReadLine();

                }

                else if (texte[texte.Length - 1] != '.')
                {
                    Console.WriteLine("Il manque un point à la fin. Veuillez recommencer la saisie");
                    autorisation = false;
                    texte = Console.ReadLine();

                }

                else
                {
                    autorisation = true;
                }
            }
            int i = 0;
            int j = texte.Length - 2;

            do
            {
                if (texte[i] == texte[j])
                {
                    i++;
                    j--;
                   
                }
                else
                {
                    estUnPalindrome = false;
                }

            }
            while (estUnPalindrome && i < (texte.Length - 1) / 2) ;
            
            if (estUnPalindrome)
            {
                Console.WriteLine("Le mot " + texte + " est un palindrome");
            }
            else
            {
                Console.WriteLine("Le mot " + texte + " n'est pas un palindromeuuuh");
            }

            /*for(int i = 0; i < texte.Length; i++)
            {
                int index = texte.Length - 1;
                for(int j = index; j >i; j--)
                {
                    if (texte[j] == texte[i])
                    {
                        //Console.WriteLine(texte[j] + " " + texte[i]);
                    }



                }
            }*/

        }
    }
}