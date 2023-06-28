namespace ClassLibraryFraction
{
    public class Fraction
    {
        double numerateur;
        double denominateur;

        public double Numerateur { get => numerateur; private set => numerateur = value; }
        public double Denominateur { get => denominateur; private set => denominateur = value; }

        public Fraction()
        {
            this.numerateur = 8;
            this.denominateur = 2;
        }

        public Fraction(double _numerateur, double _denominatuer)
        {
            this.numerateur = _numerateur;
            this.denominateur = _denominatuer;
        }

        public Fraction(double _numerateur)
        {
            this.numerateur = _numerateur;
        }

        public Fraction(Fraction _fraction)
        {
            this.numerateur = _fraction.numerateur;
            this.denominateur = _fraction.denominateur;
        }


        public string RepresentationTextFraction()
        {
            string resultat = "";
            if (this.denominateur == 1)
            {
                resultat = this.numerateur.ToString();
                return resultat;
            }
            else
            {
                resultat = this.numerateur.ToString() + "/" + this.denominateur;
                return resultat;
            }

        }

        public void Oppose()
        {
            this.numerateur = -numerateur;
        }

        public void Inverse()
        {
            double tmp;
            tmp = this.numerateur;
            this.numerateur = denominateur;
            this.denominateur = tmp;
        }

        public bool SuperieurA(Fraction fractionACompare)
        {
            if (this.numerateur / this.denominateur > fractionACompare.numerateur / fractionACompare.denominateur)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool EgalA(Fraction fractionACompare)
        {
            if (this.numerateur / this.denominateur == fractionACompare.numerateur / fractionACompare.denominateur)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private double GetPgcd()
        {
            double a = this.numerateur;
            double b = this.denominateur;
            double pgcd = 1;
            if (a != 0 && b != 0)
            {
                if (a < 0) a = -a;
                if (b < 0) b = -b;
                while (a != b)
                {
                    if (a < b)
                    {
                        b = b - a;
                    }
                    else
                    {
                        a = a - b;
                    }
                }
                pgcd = a;
            }
            return pgcd;
        }




    }
}