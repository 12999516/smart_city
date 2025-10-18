using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es
{
    internal class Monopattino: Veicolo,Icondivisibile
    {
        public bool disponibile { get; set; } = true;
        public int id { get; set; }
        public Monopattino(int id)
        {
            this.id = id;
        }
        public override void accendi()
        {
            disponibile = true;
        }
        public override void spegni()
        {
            disponibile = false;
        }

        public override string mostraInfo()
        {
            string ac;
            if (disponibile)
            {
                ac = "disponibile";
            }
            else
            {
                ac = "non disponibile";
            }
            return $"Monopattino ID: {id}, Disponibilità: {disponibile}";
        }
    }
}
