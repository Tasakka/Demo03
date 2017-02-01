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
        public int Ikä { get; set; }
        public void Name(string name)
        {
            Nimi = name;
        }
        public void Number(string number)
        {
            Numero = number;
        }
        public void Age(string age)
        {
            Ikä = age;
        }
        public void Class(string luokka)
        {
            Luokka = luokka;
        } 

    }
}
