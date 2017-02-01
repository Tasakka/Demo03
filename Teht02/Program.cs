using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht02
{
    class Program
    {
        static void Main(string[] args)
        {
            //create the instance of Washing_machine class
            Washing_machine machine = new Washing_machine();
            machine.PrintData();
            machine.Temperature = 30;
            machine.IsOn = true;
            machine.Sling = false;
            machine.Mode = "Cotton";
            machine.PrintData();
        }
    }
}
