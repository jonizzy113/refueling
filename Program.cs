using System;
using System.Collections.Generic;

namespace refueling
{
    class Program
    {
        static void Main(string[] args)
        {
            GasEngine Civic = new GasEngine () {
                Name = "Ram",
                WheelCount = 6
            };

            GasEngine NotCivic = new GasEngine () {
                Name = "Camaro",
                WheelCount = 4
            };

            List <GasEngine> GasPowerList = new List<GasEngine> () {
                Civic, NotCivic
            };

            BatteryMotor Tesla = new BatteryMotor () {
                Name = "Tesla",
                BatterySize = 10
            };

            BatteryMotor Models = new BatteryMotor () { 
                Name = "models", 
                BatterySize = 0
            };

            List <BatteryMotor> BatteryPowerList = new List<BatteryMotor> () {
                Tesla, Models
            };

            GasStation Shell = new GasStation () {
                Capacity = 2
            };

            Shell.Refuel(GasPowerList);

            BatteryStation ChargeStation = new BatteryStation () ;
            ChargeStation.Capacity = 2 ; 

            ChargeStation.Refuel(BatteryPowerList); 
        }
    }
}
