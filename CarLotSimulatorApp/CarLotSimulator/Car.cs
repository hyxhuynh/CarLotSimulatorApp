using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class Car
    {
        public Car() 
        {
            // Increment number of cars
            CarLot.numberOfCars++;
        }
        public Car(int year, string make, string model, string engineNoise, string honkNoise, bool isDriveable) 

        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDriveable;
            
            // Increment number of cars
            CarLot.numberOfCars++;
        }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }
        public void MakeEngineNoise(string EngineNoise)
        { 
            Console.WriteLine(EngineNoise);
        }
        public void MakeHonkNoise(string HonkNoise)
        {
            Console.Write(HonkNoise);
        }
    }
}
