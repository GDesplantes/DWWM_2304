namespace ExoAlgo4._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nombre = { 128, 64, 8, 512, 16, 31, 256  };
            for (int i = 0; i < nombre.Length; i++)
            {
                int indexMin = i;
                for(int j = i+1; j < nombre.Length; j++)
                {
                    if (nombre[indexMin]> nombre[j])
                    {
                        indexMin = j;

                    }

                }
                //permutation des nombres
                int temp=nombre[indexMin];
                nombre[indexMin] = nombre[i];
                nombre[i] = temp;

                 //Console.WriteLine(nombre[i]);
               
               
            }
            //parcours du tableau après traitement
            for(int i = 0; i < nombre.Length; i++)
            {
                Console.Write(nombre[i] + " ");
            }
        }
    }
}