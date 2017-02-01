using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht05
{
    class Program
    {
        static void Main(string[] args)
        {
            Opiskelija opiskelija = new Opiskelija();
            string[] opiskelijat = new string[5];
            opiskelijat[0] = /*opiskelija.Name("moi"); + opiskelija.Number("K3236") + */opiskelija.Age("20")/* + opiskelija.Class("TTV15S1")*/;
            opiskelijat[1] = opiskelija.Name("Maija") + opiskelija.Number("K1144") + opiskelija.Age(25) + opiskelija.Class("TTV16S3");
            opiskelijat[2] = opiskelija.Name("Kaapo") + opiskelija.Number("K9654") + opiskelija.Age(25) + opiskelija.Class("TTV15S3");
            opiskelijat[3] = opiskelija.Name("Mauri") + opiskelija.Number("K1134") + opiskelija.Age(93) + opiskelija.Class("TTV95S3");
            opiskelijat[4] = opiskelija.Name("Pekka") + opiskelija.Number("K3456") + opiskelija.Age(22) + opiskelija.Class("TTV14S3");
            for (int i = 0; i < opiskelijat.Length; i++) Console.Write(opiskelijat[i]);
        }
    }
}
