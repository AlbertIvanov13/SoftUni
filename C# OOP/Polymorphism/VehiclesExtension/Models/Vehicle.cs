using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehiclesExtension.Models.Interfaces;

namespace VehiclesExtension.Models
{
    public abstract class Vehicle : IVehicle
    {

        protected Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
            TankCapacity = tankCapacity;
        }

        public double FuelQuantity { get; private set; }

        public virtual double FuelConsumption { get; private set; }
        public double TankCapacity { get; private set; }

        public virtual bool Drive(double distance)
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

        public virtual bool DriveEmpty(double distance)
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

        public virtual bool DriveFull(double distance, double fuelConsumption)
        {
            if (distance < 0)
            {
                throw new ArgumentException("Distance cannot be negative.");
            }

            if (FuelQuantity < distance * fuelConsumption)
            {
                return false;
            }

            FuelQuantity -= distance * fuelConsumption;
            return true;
        }

        public virtual void Refuel(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
            }
            else
            {
                if (FuelQuantity + amount > TankCapacity)
                {
                    Console.WriteLine($"Cannot fit {amount} fuel in the tank");
                }
                else
                {
                    FuelQuantity += amount;
                }
            }
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {FuelQuantity:f2}";
        }
    }
}