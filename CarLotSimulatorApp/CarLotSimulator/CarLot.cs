using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class CarLot
    {
        public List<Car> CarList { get; set; } = new List<Car>();
        public static int numberOfCars = 0;
    }
}
