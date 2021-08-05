using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicatieBanking
{
    public abstract class Persoana
    {
        protected int id;
        protected char sex;
        protected DateTime dataNasterii;

        public Persoana()
        {
            id = 0;
            sex = 'F';
            dataNasterii = DateTime.Now;
        }

        public Persoana(int c, char s, DateTime v)
        {
            id = c;
            sex = s;
            dataNasterii = v;
        }

        public override string ToString()
        {
            return "Persoana cu codul " + id + " are sexul " + sex + " varsta " + dataNasterii;
        }
        public abstract int SpuneVarsta();
    }
}
