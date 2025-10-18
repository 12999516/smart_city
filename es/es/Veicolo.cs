using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es
{
    abstract class Veicolo
    {
        abstract public void accendi();
        abstract public void spegni();

        abstract public string mostraInfo();
    }
}
