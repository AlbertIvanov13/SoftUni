using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles.Models.Interfaces;

namespace Vehicles.Models
{
    public abstract class Vehicle : IVehicle
    {
        protected Vehicle(double fuelQuantity, double fuelConsumption)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
        }

        public double FuelQuantity { get; private set; }

        public virtual double FuelConsumption { get; private set; }

        public bool Drive(double distance)
        {
            if (distance < 0)
            {
                throw new ArgumentException("Distance cannot be negative.");
            }

            if (FuelQuantity < distance * FuelConsumption)
            {
                return false;
            }

            FuelQuantity -= distance * FuelConsumption;
            return true;
        }

        public virtual void Refuel(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Fuel cannot be negative.");
            }

            FuelQuantity += amount;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {FuelQuantity:f2}";
        }
    }
}