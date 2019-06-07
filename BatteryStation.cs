using System;
using System.Collections.Generic;

namespace refueling
{
    public class BatteryStation : IStation <BatteryMotor> {
        public int Capacity { get; set; }
        public void Refuel (List <BatteryMotor> Vehicles) {
            foreach(BatteryMotor v in Vehicles) {
                Console.WriteLine($"The {v.Name} has been refueled");
            }
        }
    }
}