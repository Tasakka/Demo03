using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht06
{
    class Program
    {
        static void Main(string[] args)
        {
            Pc pc = new Teht06.Pc();
            pc.IsOn = true;
            pc.Color = "Black";
            pc.GPU = "Intel";
            pc.Cores = 8;
            pc.PrintData();
            pc.ShutDown();
        }
    }
}
