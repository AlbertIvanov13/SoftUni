using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehiclesExtension.Models.Interfaces;

namespace VehiclesExtension.Models
{
    public class Bus : Vehicle
    {
        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public override double FuelConsumption => base.FuelConsumption;
        public override bool Drive(double distance)
        {
            double newFuelConsumption = base.FuelConsumption + 1.4;
            return base.DriveFull(distance, newFuelConsumption);
        }

        public override bool DriveEmpty(double distance)
        {
            return base.DriveEmpty(distance);
        }

        public override void Refuel(double amount)
        {
            base.Refuel(amount);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}