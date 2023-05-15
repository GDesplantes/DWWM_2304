using System.Text;

namespace ExoAlgo4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mot;
            int compteur = 0;
            char lettreAChercher;
            bool saisieCorrecte = false; ;



            do
            {

                Console.WriteLine("Ecrivez un mot en terminant par un point");

                mot = Console.ReadLine();


                if (mot == "" || mot == ".")
                {
                    saisieCorrecte = false;
                }

                else
                {
                    saisieCorrecte = true;
                }

            }
            while (!saisieCorrecte);








            while (mot.Length < 2 && mot[mot.Length - 1] != '.')
            {
                Console.WriteLine("Tu sais lire? j'ai dis écrivez un mot en terminant par un point");

                mot = Console.ReadLine();
            }

            Console.WriteLine("Ecrivez la lettre à chercher");

            lettreAChercher = char.Parse(Console.ReadLine());





            for (int index = 0; index < mot.Length; index++)
            {



                if (mot[index] == lettreAChercher)
                {
                    compteur++;
                }

                //Console.WriteLine(mot[index]);
                if (compteur > 0)

                {
                    Console.WriteLine("Il y a " + compteur + " fois la lettre " + lettreAChercher + " dans le mot " + mot);
                }
                else
                {
                    Console.WriteLine("Il n'y a pas la lettre " + lettreAChercher + " dans le mot " + mot);
                }



            }



        }
    }
}
