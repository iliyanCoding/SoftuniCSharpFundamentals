using System;
using System.Linq;
using System.Collections.Generic;

namespace _07.VehicleCatalogue
{
    internal class Program
    {
        class Truck
        {

            public Truck(string brand, string model, string weight)
            {
                this.Brand = brand;
                this.Model = model;
                this.Weight = weight;
            }
            public string Brand { get; set; }

            public string Model { get; set; }

            public string Weight { get; set; }
        }

        class Car
        {
            public Car(string brand, string model, string horsepower)
            {
                this.Brand = brand;
                this.Model = model;
                this.HorsePower = horsepower;

            }
            public string Brand { get; set; }

            public string Model { get; set; }

            public string HorsePower { get; set; }
        }

        class Catalog
        {
            public Catalog()
            {
                this.Truck = new List<Truck>();
                this.Cars = new List<Car>();
            }
            public List<Car> Cars { get; set; }

            public List<Truck> Truck { get; set; }
        }

        static void Main(string[] args)
        {
            Catalog catalogObject = new Catalog();
            //List<Car> carList = new List<Cars>();
            //List<Truck> truckList = new List<Truck>();
            string command = Console.ReadLine();
            while (command != "end")
            {

                string[] vehicle = command.Split('/');
                string typeOfVehicle = vehicle[0];
                string brandOfVehicle = vehicle[1];
                string modelOfVehicle = vehicle[2];
                string weightOrHorsePowerOfVehicle = vehicle[3];

                if (typeOfVehicle == "Car")
                {
                    Car car = new Car(brandOfVehicle, modelOfVehicle, weightOrHorsePowerOfVehicle);

                    catalogObject.Cars.Add(car);
                }
                else
                {
                    Truck truck = new Truck(brandOfVehicle, modelOfVehicle, weightOrHorsePowerOfVehicle);

                    catalogObject.Truck.Add(truck);
                }

                command = Console.ReadLine();
            }

            if (catalogObject.Cars.Count > 0)
            {
                Console.WriteLine("Cars:");
                List<Car> orderedCars = catalogObject.Cars.OrderBy(car => car.Brand).ToList();
                foreach (Car car in orderedCars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }

            if (catalogObject.Truck.Count > 0)
            {
                Console.WriteLine("Trucks:");
                List<Truck> orderedTrucks = catalogObject.Truck.OrderBy(truck => truck.Brand).ToList();
                foreach (Truck truck in orderedTrucks)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }

        }
    }
}
