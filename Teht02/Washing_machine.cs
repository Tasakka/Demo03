using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht02
{
    class Washing_machine
    {

        //properties
        public bool IsOn { get; set; }
        public bool Sling { get; set; }
        public int Temperature { get; set; }
        public string Mode { get; set; }

        //constructor

        //methods
        public void PrintData()
        {
            Console.WriteLine("Is the machine on: " + IsOn);
            Console.WriteLine("Is the slinging used: " + Sling);
            Console.WriteLine("What is temperature: " + Temperature);
            Console.WriteLine("What mode is the machine running on: " + Mode);
            Console.WriteLine("How bright is the picture: " + value)
        }
    }
}
