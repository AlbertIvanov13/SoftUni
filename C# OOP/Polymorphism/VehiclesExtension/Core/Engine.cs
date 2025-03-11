using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehiclesExtension.Core.Interfaces;
using VehiclesExtension.IO.Interfaces;
using VehiclesExtension.Models;
using VehiclesExtension.Models.Interfaces;

namespace VehiclesExtension.Core
{
    public class Engine : IEngine
    {
        private IReader reader;
        private IWriter writer;
        private ICollection<IVehicle> vehicles;
        public Engine(IReader reader, IWriter writer)
        {
            this.reader = reader;
            this.writer = writer;
            vehicles = new List<IVehicle>();
        }

        public void Run()
        {
            string[] carInfo = reader.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            double carFuelQuantity = double.Parse(carInfo[1]); 
            double carLitersPerKm = double.Parse(carInfo[2]); 
            double carTankCapacity = double.Parse(carInfo[3]);

            IVehicle car = null;
            if (carFuelQuantity > carTankCapacity)
            {
                car = new Car(carFuelQuantity, carLitersPerKm, 0);
            }
            else
            {
                car = new Car(carFuelQuantity, carLitersPerKm, carTankCapacity);
            }

            string[] truckInfo = reader.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            double truckFuelQuantity = double.Parse(truckInfo[1]);
            double truckLitersPerKm = double.Parse(truckInfo[2]);
            double truckTankCapacity = double.Parse(truckInfo[3]);

            IVehicle truck = null;
            if (truckFuelQuantity > truckTankCapacity)
            {
                truck = new Truck(truckFuelQuantity, truckLitersPerKm, 0);
            }
            else
            {
                truck = new Truck(truckFuelQuantity, truckLitersPerKm, truckTankCapacity);
            }

            string[] busInfo = reader.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            double busFuelQuantity = double.Parse(busInfo[1]);
            double busLitersPerKm = double.Parse(busInfo[2]);
            double busTankCapacity = double.Parse(busInfo[3]);

            IVehicle bus = null;
            if (busFuelQuantity > busTankCapacity)
            {
                bus = new Bus(busFuelQuantity, busLitersPerKm, 0);
            }
            else
            {
                bus = new Bus(busFuelQuantity, busLitersPerKm, busTankCapacity);
            }

            vehicles.Add(car);
            vehicles.Add(truck);
            vehicles.Add(bus);

            int number = int.Parse(reader.ReadLine());

            for (int i = 0; i < number; i++)
            {
                string[] tokens = reader.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (tokens[1] == "Car")
                {
                    if (tokens[0] == "Drive")
                    {
                        if (car.Drive(double.Parse(tokens[2])))
                        {
                            if (double.Parse(tokens[2]) == 0.0)
                            {
                                writer.WriteLine($"{tokens[1]} travelled 0 km");
                            }
                            else
                            {
                                writer.WriteLine($"{tokens[1]} travelled {tokens[2]} km");
                            }
                        }
                        else
                        {
                            writer.WriteLine($"{tokens[1]} needs refueling");
                        }
                    }
                    else if (tokens[0] == "Refuel")
                    {
                        car.Refuel(double.Parse(tokens[2]));
                    }
                }
                else if (tokens[1] == "Truck")
                {
                    if (tokens[0] == "Drive")
                    {
                        if (truck.Drive(double.Parse(tokens[2])))
                        {
                            if (double.Parse(tokens[2]) == 0.0)
                            {
                                writer.WriteLine($"{tokens[1]} travelled 0 km");
                            }
                            else
                            {
                                writer.WriteLine($"{tokens[1]} travelled {tokens[2]} km");
                            }
                        }
                        else
                        {
                            writer.WriteLine($"{tokens[1]} needs refueling");
                        }
                    }
                    else if(tokens[0] == "Refuel")
                    {
                        truck.Refuel(double.Parse(tokens[2]));
                    }
                }
                else if (tokens[1] == "Bus")
                {
                    if (tokens[0] == "Drive")
                    {
                        if (bus.Drive(double.Parse(tokens[2])))
                        {
                            if (double.Parse(tokens[2]) == 0.0)
                            {
                                writer.WriteLine($"{tokens[1]} travelled 0 km");
                            }
                            else
                            {
                                writer.WriteLine($"{tokens[1]} travelled {tokens[2]} km");
                            }
                        }
                        else
                        {
                            writer.WriteLine($"{tokens[1]} needs refueling");
                        }
                    }
                    else if (tokens[0] == "DriveEmpty")
                    {
                        if (bus.DriveEmpty(double.Parse(tokens[2])))
                        {
                            if (double.Parse(tokens[2]) == 0.0)
                            {
                                writer.WriteLine($"{tokens[1]} travelled 0 km");
                            }
                            else
                            {
                                writer.WriteLine($"{tokens[1]} travelled {tokens[2]} km");
                            }
                        }
                        else
                        {
                            writer.WriteLine($"{tokens[1]} needs refueling");
                        }
                    }
                    else if (tokens[0] == "Refuel")
                    {
                        bus.Refuel(double.Parse(tokens[2]));
                    }
                }
            }

            foreach (var vehicle in vehicles)
            {
                writer.WriteLine(vehicle.ToString());
            }
        }
    }
}