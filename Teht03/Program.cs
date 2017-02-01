using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht03
{
    class Program
    {
        static void Main(string[] args)
        {
            Tv tv = new Tv();
            tv.IsOn = true;
            tv.Channel = 3;
            tv.Settings(50, 70, "HMD1");
            tv.Size = 42;
            tv.Color = "Black";
            tv.PrintData();
        }
    }
}
