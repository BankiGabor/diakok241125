using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diakok241125
{
    internal class Iskola
    {
        public List<Diakok> Diakok { get; private set; }

        public Iskola()
        {
            Diakok = new List<Diakok>();
        }

        public void AddDiak(Diakok diak)
        {
            if (diak != null && !Diakok.Contains(diak))
            {
                Diakok.Add(diak);
            }
        }

        public void RemoveDiak(Diakok diak)
        {
            if (diak != null)
            {
                Diakok.Remove(diak);
            }
        }

        public int Letszam
        {
            get { return Diakok.Count; }
        }


        public double AtlagEletkor
        {
            get
            {
                return Diakok.Count > 0 ? Diakok.Average(d => d.Kor) : 0;
            }
        }
    }
}
