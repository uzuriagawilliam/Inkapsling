using Inkapsling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inkapsling._3_1
{
    class Wolfman : Wolf, IPerson
    {
        public void Talk()
        {
            Console.WriteLine("Wolfman say Grrrrrr aaaauuuuuuuuuu ");
        }

        public override string Stats()
        {
            return $" {base.Stats()} From wolfman";
        }
    }
}
