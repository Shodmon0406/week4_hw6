using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle.Classes
{
    internal class Car : IVehicle
    {
        public bool IsRunning { get; set; }
        public int Speed { get; set; }
        public void Start(int speed)
        {
            Speed = speed;
            IsRunning = true;
            Console.WriteLine("Starting car engine.");
        }
        public void Stop()
        {
            IsRunning &= false;
            Console.WriteLine("Stopping car engine.");
        }
        public void Drive()
        {
            // Console.WriteLine("Driving down the road.");
            Console.WriteLine($"Driving at {Speed}mph");
        }
    }
}
