namespace ExoAlgo2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;

            Console.WriteLine("Bienvenue dans ce programme de calcul de la retraite");

            Console.WriteLine("Veuillez rentrer votre age");

            age=int.Parse(Console.ReadLine());

            if (age>0)
            {
                if (age<60)
                {
                    Console.WriteLine("Vous serez à la retraite dans " + (60-age) + " ans");
                }

                else if (age>60)
                {
                    Console.WriteLine("Vous êtes à la retraite depuis " + (age-60) + " ans");
                }
                else
                {
                    Console.WriteLine("C'est le moment de prendre sa retraite");
                }
            
            }

            else
            {
                Console.WriteLine("La valeur fournie n'est pas un âge valide");
            }
        }
    }
}