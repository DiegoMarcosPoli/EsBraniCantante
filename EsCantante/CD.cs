using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsCantante
{
    class CD
    {
        private List<Brano> _brani;

        public CD(string titolo, string autore, List<Brano> brani)
        {

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
        public List<Brano> Brani
        {
            get;
            set;
        }
        public override string ToString()
        {
            string stringa = "";
            foreach (Brano b in _brani)
            {
                stringa = b.ToString() + ' ';
            }
            return stringa;
        }
        public float GetDurata()
        {
            float durataCD = 0;
            foreach (Brano b in _brani)
            {
                durataCD += b.DurataMinuti;
            }
            return durataCD;
        }

    }
}
