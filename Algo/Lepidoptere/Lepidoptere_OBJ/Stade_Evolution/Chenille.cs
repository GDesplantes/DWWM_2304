using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lepidoptere_OBJ.Stade_Evolution
{
    internal class Chenille : StadeEvolution
    {
        public Chenille() // Constructeur Default
        {

        }
        public override void seDeplacer()
        {
            Console.WriteLine("");
        }

        public override StadeEvolution SeMetamorphoser()
        {
            return new Chenille();
        }
    }
}
