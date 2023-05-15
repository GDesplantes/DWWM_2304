namespace ExoAlgo4._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string texte; 
            int nbCharacteres = 0;
            string[] alphabet = new string["a";] ;
            Console.WriteLine("Saisissez un texte d'au moins 120 characteres ");
            texte=Console.ReadLine();

            while(texte.Length<120)
            {
                Console.WriteLine("votre texte fais moins de 120 characteres. Veuillez recommencer la saisie");
                texte = Console.ReadLine();
            }

            for(int index=0; index < texte.Length; index++)
            {

            }


        }
    }
}