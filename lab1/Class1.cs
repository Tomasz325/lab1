using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Ulamek
    {
        private int licznik;
        private int mianownik;
        public Ulamek()
        {
            int licznik = 0;
            int mianownik = 1;
        }
        public Ulamek(int licznik, int mianownik)
        {
            this.licznik = licznik;
            this.mianownik = mianownik;
        }
        public Ulamek(Ulamek perviousUlamek)
        {
            licznik = perviousUlamek.licznik;
            mianownik = perviousUlamek.mianownik;
        }
        override public object ToString(int licznik, int mianowink)
        {
            return mianownik. + licznik.ToString();
        }
    }

}
