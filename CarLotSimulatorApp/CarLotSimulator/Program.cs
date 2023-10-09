using System;
using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a separate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            var uno = new Car();

            
                uno.Year = 2021;
                uno.Make = "Ford";
                uno.Model = "Mustang";
                uno.EngineNoise = "vroom";
                uno.HonkNoise = "beeeeeep";
                uno.IsDriveable = true;
            

            var carTwo = new Car();
            carTwo.Year = 2000;
            carTwo.Make = "Lamborgini";
            carTwo.Model = "Urus";
            carTwo.EngineNoise = "vroom";
            carTwo.HonkNoise = "beep";
            carTwo.IsDriveable = true;  

            var carThree = new Car();
            carThree.Year = 2012;
            carThree.Make = "Nissan";
            carThree.EngineNoise = "vroom";
            carThree.HonkNoise = "beep";
            carThree.IsDriveable = true;






            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
