using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lepidoptere_OBJ.Stade_Evolution
{
    internal class Oeuf : StadeEvolution
    {
        public Oeuf() // Constructeur par default
        {
            
        }

        public override void seDeplacer()
        {
            Console.WriteLine("Je ne peux pas me déplacer, je suis un oeuf");
        }

        public override StadeEvolution SeMetamorphoser()
        {
            return new Chenille();
        }


    }
}
