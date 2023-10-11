using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class CarLot
    {
        //Create a CarLot class
        //It should have at least one property: a List of cars
        //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
        //At the end iterate through the list printing each of car's Year, Make, and Model to the console

        public static int _numberOfCars = 0;




        //property (LIST)

        public List<Car> ParkingLot {  get; set; } = new List<Car>();


        public void CheckCars()
         
        {
            //for each (TYPE "Car" VARIABLE "car" in LIST "ParkingLot")
            foreach (Car car in ParkingLot)

            //what you want it to do
            {

                Console.WriteLine($"This is a {car.Year} {car.Make} {car.Model}");
                car.MakeEngineNoise(car.EngineNoise);
                car.MakeHonkNoise(car.HonkNoise);
            }

            
        }
    }
}
