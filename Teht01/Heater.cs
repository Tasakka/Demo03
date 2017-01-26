using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht01
{
    class Heater
    {
        // properties
        public bool IsOn { get; set; }
        public double Temperature { get; set; }
        public double Humidity { get; set; }

        // constructor

        // methods
        public void PrintData()
        {
            Console.WriteLine("How warm is it: " + Temperature);
            Console.WriteLine("What is the humidity: " + Humidity);
        }
        public void Power(bool value)
        {
            IsOn = value;
            Console.WriteLine("Is the stove on: " + value);
        }

        // deastructor
        ~Heater()
        {
            Console.WriteLine("Heater object detroyed!");
        }
    }
}
