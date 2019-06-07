using System.Collections.Generic;

namespace  refueling
{
    public interface IStation <T>
    {
        int Capacity { get; set; }
        void Refuel (List <T> Vehicles);
    }
}