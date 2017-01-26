using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht01
{
    class Program
    {
        static void Main(string[] args)
        {
            // create one instance of heater class
            Heater heater = new Teht01.Heater();
            heater.PrintData();
            heater.Power(true);
            heater.Temperature = 80.6;
            heater.Humidity = 98.2;
            heater.PrintData();
            // testing...
        }
    }
}
