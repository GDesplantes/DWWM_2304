namespace ExoAlgo4._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string texte;

            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            //.WriteLine(alphabet.Length);


            Console.WriteLine("Saisissez un texte d'au moins 120 characteres ");
            texte = Console.ReadLine();

            while (texte.Length < 120)
            {
                Console.WriteLine("votre texte fais moins de 120 characteres. Veuillez recommencer la saisie");
                texte = Console.ReadLine();
            }

            for (int indexAlphabet = 0; indexAlphabet < alphabet.Length; indexAlphabet++)
            {
                int nbLettres = 0;

                for (int indexTexte = 0; indexTexte < texte.Length; indexTexte++)
                {
                    if (texte[indexTexte] == alphabet[indexAlphabet])
                    {
                        nbLettres++;
                    }


                }

                Console.WriteLine("La lettre " + alphabet[indexAlphabet] + " est presente " + nbLettres + " fois");
            }



        }
    }
}
