using System;
using System.Collections.Generic;

namespace refueling
{
    public class GasStation : IStation <GasEngine> {
        public int Capacity { get; set; }
        public void Refuel (List <GasEngine> Vehicles) {
            foreach(GasEngine v in Vehicles) {
                Console.WriteLine($"The {v.Name} has been refueled and has {v.WheelCount} wheels");
            }
        }
    }
}