using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht05
{
    class Opiskelija
    {
        public string Numero { get; set; }
        public string Nimi { get; set; }
        public string Luokka { get; set; }
        public string Ikä { get; set; }
        public string opiskelija1()
        {
            Nimi = "Juuso";
            Numero = "K3236";
            Luokka = "TTV15S1";
            Ikä = "20";
            return String.Format(Nimi + ", " + Numero + ", " + Ikä + ", " + Luokka);
        }
        public string opiskelija2()
        {
            Nimi = "Pertti";
            Numero = "K3345";
            Luokka = "TTV12S4";
            Ikä = "25";
            return String.Format(Nimi + ", " + Numero + ", " + Ikä + ", " + Luokka);
        }
        public string opiskelija3()
        {
            Nimi = "Isto";
            Numero = "K1234";
            Luokka = "TTV43S1";
            Ikä = "34";
            return String.Format(Nimi + ", " + Numero + ", " + Ikä + ", " + Luokka);
        }
        public string opiskelija4()
        {
            Nimi = "Martti";
            Numero = "S27893";
            Luokka = "ASD123";
            Ikä = "19";
            return String.Format(Nimi + ", " + Numero + ", " + Ikä + ", " + Luokka);
        }
        public string opiskelija5()
        {
            Nimi = "Kaapo";
            Numero = "Y765";
            Luokka = "TTV76S23";
            Ikä = "99";
            return String.Format(Nimi + ", " + Numero + ", " + Ikä + ", " + Luokka);
        }
    }
}
