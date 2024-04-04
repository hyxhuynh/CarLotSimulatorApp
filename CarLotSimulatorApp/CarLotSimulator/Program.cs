using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//
            CarLot parkingLot = new CarLot();
            
            // Set the properties utilizing the 3 different ways we learned about, one way for each car
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
            parkingLot.CarList.Add(car2 );

            Console.WriteLine($"{car2.Make} {car2.Model} {car2.Year}");
            car2.MakeEngineNoise($"Engine Noise: {car2.EngineNoise}");
            car2.MakeHonkNoise($"Honk Noise: {car2.HonkNoise}\n");
            Console.WriteLine("-------------------------------------");

            // 3. Custom constructor
            Car car3 = new Car( 2010, "Honda", "Civic", "Vroom", "Beep", false );
            parkingLot.CarList.Add (car3);

            Console.WriteLine($"{car3.Make} {car3.Model} {car3.Year}");
            car1.MakeEngineNoise($"Engine Noise: {car3.EngineNoise}");
            car1.MakeHonkNoise($"Honk Noise: {car3.HonkNoise}\n");
            Console.WriteLine("-------------------------------------");
            //*************BONUS X 2*************//
            foreach (Car individualCar in parkingLot.CarList)
            {
                Console.WriteLine($"Make: {individualCar.Make}, Model: {individualCar.Model}, Year: {individualCar.Year}");
            }

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
