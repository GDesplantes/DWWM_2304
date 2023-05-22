namespace ExoAlgo5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nombre = 0;
            int compteur = 0;
            List<int> tabDiviseur = new List<int>();

            Console.WriteLine("Saissisez un nombre");

            nombre = int.Parse(Console.ReadLine());

            for (int diviseur = 2; diviseur <= (nombre / 2); diviseur++)
            {
                if (nombre % diviseur == 0)
                {
                    tabDiviseur.Add(diviseur);
                }
            }
            int somme=1;
            Console.WriteLine("Les diviseurs autre que 1 sont : ");
            for(int i=0; i<tabDiviseur.Count; i++)
            {
                somme+=tabDiviseur[i];
                Console.Write(tabDiviseur[i] + " ");
            }
            Console.WriteLine();
            if (nombre == somme && somme!=0)
            {
                Console.WriteLine(nombre + " est un nombre parfait");
            }
            else if (somme == 1)
            {
                Console.WriteLine(nombre + "est un nombre premier");

            }
            else
            {
                Console.WriteLine(nombre + " n'est pas un nombre parfait ni un nombre premier");
            }
        }
    }
}