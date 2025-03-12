using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesExtension.Models.Interfaces
{
    public interface IVehicle
    {
        double FuelQuantity { get; }
        double FuelConsumption { get; }

        double TankCapacity { get; }

        bool Drive(double distance);
        void Refuel(double amount);

        bool DriveEmpty(double distance);
        bool DriveFull(double distance, double fuelConsumption);
    }
}