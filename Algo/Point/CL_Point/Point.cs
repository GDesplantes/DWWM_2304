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

        public Point( Point PointCopie)
        {
            this.abscisse_X = PointCopie.abscisse_X;
            this.ordonnee_Y = PointCopie.ordonnee_Y;
        }

        public float IndiquerPosition()
        {
            return abscisse_X;
            return ordonnee_Y;
        }

        public void Deplacer(float newPosition_X, float newPosition_Y)
        {
            abscisse_X = newPosition_X;
            ordonnee_Y= newPosition_Y;
        }

        public void RenvoyerPosition()
        {

        }




    }
}