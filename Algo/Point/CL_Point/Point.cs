namespace CL_Point
{
    public class Point
    {
        private float abscisse_X;
        private float ordonnee_Y;

        public float Abscisse_X { get => abscisse_X; private set => abscisse_X = value; }
        public float Ordonnee_Y { get => ordonnee_Y; private set => ordonnee_Y = value; }

        public Point()
        {
            this.abscisse_X = 0;
            this.ordonnee_Y = 0;
        }

        public Point(float _abscisse_X, float _ordonnee_Y)
        {
            this.abscisse_X = _abscisse_X;
            this.ordonnee_Y = _ordonnee_Y;
        }

        public Point(Point pointCopie)
        {
            this.abscisse_X = pointCopie.abscisse_X;
            this.ordonnee_Y = pointCopie.ordonnee_Y;
        }


        public void Deplacer(float newPosition_X, float newPosition_Y)
        {
            this.abscisse_X = newPosition_X;
            this.ordonnee_Y = newPosition_Y;
            

        }

        public string RenvoyerPosition()
        {
            string coordonnee;
            coordonnee = abscisse_X.ToString() + " / " + ordonnee_Y.ToString();
            return coordonnee;
        }

        public Point SymetrieAxeAbscisse()
        {
            return new Point(abscisse_X, -ordonnee_Y);

        }

        public Point SymetrieAxeOrdonnee()
        {
            return new Point( -abscisse_X,ordonnee_Y);

        }

        public Point SymetrieOrigine()
        {
            return new Point(-abscisse_X, -ordonnee_Y);

        }

        public void PermuterCoordonnee()
        {
            float temp;
            temp = abscisse_X;
            abscisse_X = ordonnee_Y;
            ordonnee_Y = temp;

            
        }






    }
}

