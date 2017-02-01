using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht03
{
    class Tv
    {
        //properties
        public bool IsOn{get; set; }
        public int Channel { get; set; }
        public string Color { get; set; }
        public int Size { get; set; }
        public int Brightness { get; set; }
        public int Sharpness { get; set; }
        public string Output { get; set; }
        //methods
        public void PrintData()
        {
            Console.WriteLine("Is the tv on: " + IsOn);
            Console.WriteLine("What channel is on: " + Channel);
            Console.WriteLine("What is the color: " + Color);
            Console.WriteLine("How big is the Tv: " + Size);
        }
        public void Settings(int value, int value2, string value3)
        {
            Brightness = value;
            Console.WriteLine("How bright is the picture: " + value);
            Sharpness = value2;
            Console.WriteLine("How sharp is the picture: " + value2);
            Output = value3;
            Console.WriteLine("Which output is used: " + value3);
        }
    }
}
