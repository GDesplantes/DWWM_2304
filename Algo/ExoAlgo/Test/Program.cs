namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nombre;

            Console.WriteLine("Hello, World!");

            Console.WriteLine("Saisissez un nombre");

            nombre=int.Parse(Console.ReadLine());

            for (int i = 1; i <8; i++)
            {
                Console.WriteLine(nombre%i);
            }
        }
    }
}