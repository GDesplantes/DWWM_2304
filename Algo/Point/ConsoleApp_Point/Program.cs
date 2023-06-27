using CL_Point;

namespace ConsoleApp_Point
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point( 2, -5);
            point.Deplacer(-2.5f, 5.2f);
            float x= point.Abscisse_X;
            float y = point.Ordonnee_Y;
            string position = point.RenvoyerPosition();
            Point symetrieAbscisse = point.SymetrieAxeAbscisse();
            Point symetrieOrdonne = point.SymetrieAxeOrdonnee();
            Point symetrieOrigine = point.SymetrieOrigine();
            point.PermuterCoordonnee();

            int a = 0;

            
        }
    }
}