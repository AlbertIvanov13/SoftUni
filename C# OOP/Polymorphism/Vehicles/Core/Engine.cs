using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles.Core.Interfaces;
using Vehicles.IO.Interfaces;
using Vehicles.Models;
using Vehicles.Models.Interfaces;

namespace Vehicles.Core
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
            IVehicle car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]));
            string[] truckInfo = reader.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            IVehicle truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]));

            vehicles.Add(car);
            vehicles.Add(truck);

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
            }

            foreach (var vehicle in vehicles)
            {
                writer.WriteLine(vehicle.ToString());
            }
        }
    }
}