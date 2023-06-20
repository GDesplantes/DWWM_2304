using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lepidoptere_OBJ.Stade_Evolution
{
    internal class Papillon : StadeEvolution
    {
        public Papillon() // Constructeur Default
        {

        }
        public override void seDeplacer()
        {
            Console.WriteLine("");
        }

        public override StadeEvolution SeMetamorphoser()
        {
            return this;
        }
    }
}
}
