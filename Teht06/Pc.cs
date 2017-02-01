using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht06
{
    class Pc
    {
        public bool IsOn;
        public string Color;
        public int Cores;
        public string GPU;
        public void PrintData()
        {
            Console.WriteLine("Power: " + IsOn);
            Console.WriteLine("Color :" + Color);
            Console.WriteLine("Cores: " + Cores);
            Console.WriteLine("GPU: " + GPU);
        }
        public void ShutDown()
        {
            IsOn =! true;
            Console.WriteLine("Shutting down, Goodbye!");
        }
    }
}
