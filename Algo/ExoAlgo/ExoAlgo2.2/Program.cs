namespace ExoAlgo2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;

            Console.WriteLine("Bienvenue dans ce programme de vérification de la majorité");

            Console.WriteLine("Veuillez saisir votre âge");

            age=int.Parse(Console.ReadLine());

            Console.WriteLine("Votre âge est donc de " + age + " ans");

            if (age<0)
            {
                Console.WriteLine("Vous n'êtes pas encore né");
            }

            else if (age>=18)
            {
                Console.WriteLine("Vous êtes majeur");
            }

            else
            {
                Console.WriteLine("Vous êtes mineur");
            }
        }
    }
}