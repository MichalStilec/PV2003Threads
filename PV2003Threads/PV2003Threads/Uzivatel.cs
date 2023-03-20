using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV2003Threads
{
    internal class Uzivatel
    {
        private string jmeno;
        private string heslo;
        public enum Prihl
        {
            admin,
            user
        }


        public Uzivatel(string jmeno, string heslo, Prihl prihlas)
        {
            Jmeno = jmeno;
            Heslo = heslo;
            Prihlas = prihlas;
        }

        public string Jmeno { get => jmeno; set => jmeno = value; }
        public string Heslo { get => heslo; set => heslo = value; }
        public Prihl Prihlas { get; set; }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
