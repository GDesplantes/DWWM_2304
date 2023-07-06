using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_JeuDeLaGuerreD2WM
{
    internal class Arme
    {
        private double puissanceArme;
        private string nomArme;
        public Arme()
        {
            this.puissanceArme = 55;
            this.nomArme = "Berta";
        }

        public Arme(double _puissanceArme, string _nomArme)
        {
            this.puissanceArme = _puissanceArme;
            this.nomArme = _nomArme;
        }

        
    }
}
