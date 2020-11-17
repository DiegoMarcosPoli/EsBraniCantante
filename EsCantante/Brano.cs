using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsCantante
{
    class Brano
    {
        public Brano(string titolo, string autore, float durataMinuti)
        {
            Titolo = titolo;
            Autore = autore;
            DurataMinuti = durataMinuti;
        }
        public string Titolo
        {
            get;
            set;
        }
        public string Autore
        {
            get;
            set;
        }

        private float _durataMinuti;
        public float DurataMinuti
        {
            get
            {
                return _durataMinuti;
            }
            set
            {
                if (value > 0.10)
                {
                    _durataMinuti = value;
                }
            }
        }

        public bool shortSong(int durata)
        {
            if (DurataMinuti < durata)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override string ToString()
        {
            return Titolo + " / " + Autore + " / " + DurataMinuti;
        }

    }
}
