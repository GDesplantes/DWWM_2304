using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_JeuDeLaGuerreD2WM
{
    internal class Guerrier
    {

        private string nom;
        private int nombreVies;


        public Guerrier(string _nom, int _nombreVies, int _nombresArmes, double _puissanceUneArme)
        {
            this.nom = _nom;
            this.nombreVies = _nombreVies;
        }

        public Guerrier()
        {
            this.nom = "Celestin";
            this.nombreVies = 10;

        }

        public bool Affronttement(Guerrier autreGuerrier)
        {

        }
    }
}
