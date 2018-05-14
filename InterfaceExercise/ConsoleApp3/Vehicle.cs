using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Vehicle
    {
    }
    //composition
    class Car
    {
        public string Color { get; set; }
    }
    class Engine
    {
        public int MaxSpeed { get; set; }
        public bool IsTurbo { get; set; }
    }
    class Ford : Car 
    {
        public Engine EngineType { get; set; }
    }

}
