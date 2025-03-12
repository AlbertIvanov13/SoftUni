using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesExtension.Models
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public override double FuelConsumption => base.FuelConsumption + 1.6;

        public override bool Drive(double distance)
        {
            return base.Drive(distance);
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