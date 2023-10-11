using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{ //Create a separate class file called Car -- DONE
  //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable -- DONE
  //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise() -- DONE 
  //The methods should take one string parameter: the respective noise property -- DONE
    public class Car

    {
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise {  get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; } = true;
        public void MakeEngineNoise(string engineNoise) // calls from string above
        { 

            EngineNoise = engineNoise;
            Console.WriteLine("VROOM");
            
        }
        public void MakeHonkNoise(string honkNoise) //calls from string above
        {
            HonkNoise = honkNoise;
            Console.WriteLine("BEEEEP");
        }

       

        
        public Car(int year, string make, string model, string engineNoise, string honkNoise, bool isDriveable)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;

            if (isDriveable) 
            {
                Console.WriteLine("Yes");
            }
            CarLot._numberOfCars++;

        }

        public Car()
        {
            CarLot._numberOfCars++;
        }
    }

    



}

