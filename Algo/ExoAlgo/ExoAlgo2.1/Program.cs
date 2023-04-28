namespace ExoAlgo2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenue dans ce programme permettant le tri de nombre entier par ordre croissant");

            int A;

            int B;

            Console.WriteLine(" Veuillez saisir la valeur de A");

            A=int.Parse(Console.ReadLine());

            Console.WriteLine(" Veuillez saisir la valeur de B");

            B=int.Parse(Console.ReadLine());

            Console.WriteLine("Voici les valeurs dans l'ordre croissant " + Math.Min(A,B) + "-" + Math.Max(A,B));

            Console.Read();

        }
    }
}