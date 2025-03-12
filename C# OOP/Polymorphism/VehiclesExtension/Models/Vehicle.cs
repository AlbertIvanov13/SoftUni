using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using VehiclesExtension.Models.Interfaces;

namespace VehiclesExtension.Models
{
    public abstract class Vehicle : IVehicle
    {
        private double fuelQuantity;
        private double fuelConsumption;
        private double tankCapacity;
        protected Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            TankCapacity = tankCapacity;
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
        }

        public virtual double FuelQuantity 
        { 
            get 
            { 
                return fuelQuantity; 
            }
            private set 
            {
                if (value > TankCapacity)
                {
                    value = 0;
                }
                fuelQuantity = value;
            } 
        }


        public virtual double FuelConsumption
        {
            get { return fuelConsumption; }
            set { fuelConsumption = value; }
        }


        public double TankCapacity
        {
            get { return tankCapacity; }
            set { tankCapacity = value; }
        }



        public virtual bool Drive(double distance)
        {
            if (FuelQuantity < distance * FuelConsumption)
            {
                return false;
            }

            FuelQuantity -= distance * FuelConsumption;
            return true;
        }

        public virtual bool DriveEmpty(double distance)
        {

            if (FuelQuantity < distance * FuelConsumption)
            {
                return false;
            }

            FuelQuantity -= distance * FuelConsumption;
            return true;
        }

        public virtual bool DriveFull(double distance, double fuelConsumption)
        {

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
                if (this.GetType().Name == "Truck")
                {
                    if (FuelQuantity + amount > TankCapacity)
                    {
                        Console.WriteLine($"Cannot fit {amount} fuel in the tank");
                    }
                    else
                    {
                        FuelQuantity += amount * 0.95;
                    }
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
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {FuelQuantity:f2}";
        }
    }
}