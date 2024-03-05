using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toto_2020_okt_
{
    /*7. feladat: Forráskódjába tegye elérhetővé a java.txt vagy a csharp.txt állományból 
    az EredmenyElemzo osztályt definiáló kódrészletet! Az osztály felhasználható arra, 
    hogy megállapítsa egy forduló eredményeiről (pl.: „2X22211X1X11X1”), hogy 
    egyetlen mérkőzés sem végződött döntetlen eredménnyel (NemvoltDontetlenMerkozes).*/
    class EredmenyElemzo
    {
        private string Eredmenyek;

        private int DontetlenekSzama
        {
            get
            {
                return Megszamol('X');
            }
        }

        private int Megszamol(char kimenet)
        {
            int darab = 0;
            foreach (var i in Eredmenyek)
            {
                if (i == kimenet) darab++;
            }
            return darab;
        }

        public bool NemvoltDontetlenMerkozes
        {
            get
            {
                return DontetlenekSzama == 0;
            }
        }

        public EredmenyElemzo(string eredmenyek) // konstruktor
        {
            Eredmenyek = eredmenyek;
        }
    }
}
