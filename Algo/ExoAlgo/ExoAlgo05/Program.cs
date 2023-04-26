namespace ExoAlgo05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A;
            int B;
            int C=0;

            Console.WriteLine("Veuillez saisir la valeur de A");

            A=int.Parse(Console.ReadLine());

            Console.WriteLine("Veuillez saisir la valeur de B");

            B=int.Parse(Console.ReadLine());


            Console.WriteLine("La valeur de A est de " + A + " et de B est de " + B);

            C = B;
            B = A;
            A = C;

            Console.WriteLine("Invertion des nombres en cours . . . .");

            Console.WriteLine("Les nouvelles valeurs de A et B sont " + A + " et " +B);

        }
    }
}