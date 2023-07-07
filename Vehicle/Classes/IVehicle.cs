using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle.Classes
{
    public interface IVehicle
    {
        void Start(int speed);
        void Stop();
        bool IsRunning { get; set; }
        void Drive();
        int Speed { get; set; }
    }
}
