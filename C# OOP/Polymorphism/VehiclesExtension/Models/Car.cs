using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesExtension.Models
{
    public class Car : Vehicle
    {
        public Car(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public override double FuelConsumption => base.FuelConsumption + 0.9;
        public bool Drive(double distance)
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