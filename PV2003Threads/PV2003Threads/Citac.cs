using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV2003Threads
{
    internal class Citac
    {
        private int hodnota;

        public Citac(int hodnota)
        {
            Hodnota = hodnota;
        }

        public int Hodnota { get => hodnota; set => hodnota = value; }


        public void Zvys()
        {
            hodnota += 1;
        }
        public void Sniz()
        {
           hodnota -= 1;
        }
    }
}
