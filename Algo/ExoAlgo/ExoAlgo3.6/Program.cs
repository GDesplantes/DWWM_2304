namespace ExoAlgo3._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Random random=new Random();
            int occurence=0;
          int nbSecret=random.Next(0,100);
            int user;
            Console.WriteLine("Deviné le nombre secret");
            user=int.Parse(Console.ReadLine());
            while (user<0 || user > 100)
            {
                Console.WriteLine("Out of range");
                user = int.Parse(Console.ReadLine());
            }

            while (user != nbSecret)
            {
                if (user<nbSecret)
                {
                    Console.WriteLine("+");
                    user=int.Parse(Console.ReadLine());
                    occurence++;
                }

                if (user > nbSecret)
                {
                    Console.WriteLine("-");
                    user=int.Parse(Console.ReadLine());
                    occurence++;
                }
            }
            Console.WriteLine("Bravo c'était bien " + nbSecret);
            Console.WriteLine("Vous avez trouver en " + occurence + " essaies");
        }
    }
}