using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht04
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle();
            vehicle.PrintData();
            vehicle.Name = "Lada";
            vehicle.Speed = 300;
            vehicle.Tyres = 4;
            vehicle.PrintData();
            vehicle.ToString();
        }
    }
}
