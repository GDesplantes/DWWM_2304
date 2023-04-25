namespace ExoAlgo02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nb1;
            int nb2;
            double moyenne;

            Console.WriteLine("Veuillez saisir la premier nombre");
            
            nb1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Veuillez saisir le deuxieme nombre");

            nb2 = int.Parse(Console.ReadLine());


            moyenne= (nb1+nb2)/2.0;


            Console.WriteLine("La moyenne de " + nb1 + " et " + nb2 + " est de : " + moyenne);

        }
    }
}