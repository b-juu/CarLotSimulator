using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            CarLot carLot = new CarLot();
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            Car car1 = new Car();
            car1.Year = 2023;
            car1.Make = "Toyota";
            car1.Model = "Camry";
            car1.EngineNoise = "Vroom!";
            car1.HonkNoise = "Beep Beep";
            car1.IsDriveable = true;

            Car car2 = new Car
            {
                Year = 2022,
                Make = "Honda",
                Model = "Civic",
                EngineNoise = "Rumble",
                HonkNoise = "Honk Honk",
                IsDriveable = true
            };

            Car car3 = new Car
            {
                Year = 2021,
                Make = "Ford",
                Model = "Focus",
                EngineNoise = "Roar",
                HonkNoise = "Horn",
                IsDriveable = true
            };

            carLot.Cars.Add(car1);
            carLot.Cars.Add(car2);
            carLot.Cars.Add(car3);

            foreach (var car in carLot.Cars)
            {
                car.MakeEngineNoise(car.EngineNoise);
                car.MakeHonkNoise(car.HonkNoise);
            }

            Console.WriteLine("\nCars in CarLot:");
            foreach (var car in carLot.Cars)
            {
                Console.WriteLine($"{car.Year} {car.Make} {car.Model}");
            }
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
