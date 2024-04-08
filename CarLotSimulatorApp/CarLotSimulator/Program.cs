using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            CarLot parkingLot = new CarLot();

            // 1. Dot notation
            Car car1 = new Car();
            parkingLot.CarList.Add(car1);

            car1.Year = 2025;
            car1.Make = "Lamborghini";
            car1.Model = "Huracan";
            car1.EngineNoise = "Zoom zoom";
            car1.HonkNoise = "Beep beep beep";
            car1.IsDriveable = true;

            Console.WriteLine($"{car1.Make} {car1.Model} {car1.Year}");
            car1.MakeEngineNoise($"Engine Noise: {car1.EngineNoise}");
            car1.MakeHonkNoise($"Honk Noise: {car1.HonkNoise}\n");

            // Update number of cars
            Console.WriteLine($"Number of cars: {CarLot.numberOfCars}");

            Console.WriteLine("-------------------------------------");

            // 2. Object initializer syntax
            Car car2 = new Car()
            {
                Year = 2024,
                Make = "Tesla",
                Model = "Cybertruck",
                EngineNoise = "Vroom vroom",
                HonkNoise = "Beep beep",
                IsDriveable = true
            };
            parkingLot.CarList.Add(car2);

            Console.WriteLine($"{car2.Make} {car2.Model} {car2.Year}");
            car2.MakeEngineNoise($"Engine Noise: {car2.EngineNoise}");
            car2.MakeHonkNoise($"Honk Noise: {car2.HonkNoise}\n");

            // Update number of cars
            Console.WriteLine($"Number of cars: {CarLot.numberOfCars}");

            Console.WriteLine("-------------------------------------");

            // 3. Custom constructor
            Car car3 = new Car( 2010, "Honda", "Civic", "Vroom", "Beep", false );
            parkingLot.CarList.Add(car3);

            Console.WriteLine($"{car3.Make} {car3.Model} {car3.Year}");
            car1.MakeEngineNoise($"Engine Noise: {car3.EngineNoise}");
            car1.MakeHonkNoise($"Honk Noise: {car3.HonkNoise}\n");

            // Update number of cars
            Console.WriteLine($"Number of cars: {CarLot.numberOfCars}");

            Console.WriteLine("-------------------------------------");
            
            // Print cars to the console
            foreach (Car individualCar in parkingLot.CarList)
            {
                Console.WriteLine($"Make: {individualCar.Make}, Model: {individualCar.Model}, Year: {individualCar.Year}");
            }


        }
    }
}
