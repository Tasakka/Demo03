using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht04
{
    class Vehicle
    {
        //properties
        public string Name { get; set; }
        public int Speed { get; set; }
        public int Tyres { get; set; }

        //methods
        public void PrintData()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Speed: " + Speed);
            Console.WriteLine("Tyres: " + Tyres);
        }
        public void ToString(string value)
        {
            value = Name + Speed + Tyres;
            string str = Convert.ToString(value);
            Console.WriteLine(str);
        }
    }
}
