using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es
{
    interface Ivolante
    {
        int quotamassima { get; }
        void decolla();
        void atterra();
    }
}
