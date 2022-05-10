using System;
using System.Collections.Generic;
using InterfaceExercise;


namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            
            
            
            Car car1 = new Car()
            {
                HasWheels = 4,
                Engine = "Does not have working engine",
                HornSound = "Beep",
                NumberOfWindows = 4,
                Name = "Toyota",
                Logo = "Toyota Logo",
                HasTrunk = "This car has a trunk.",
                BetterMilage = "This care will get 40 MPG."
            };

            SUV suv1 = new SUV()
            {
                HasWheels = 4,
                Engine = "Has working engine",
                HornSound = "Beep",
                NumberOfWindows= 4,
                Name = "Chevy",
                Logo = "Chevy Logo",
                HasThirdRow = "This vehicle is equipped with third row seating.",
                CargoHoldSize = "This vehicle has a folding third row that allows for extra cargo space if needed.",
            };           

            Truck truck1 = new Truck()
            {
                HasWheels = 4,
                Engine = "Has working engine",
                HornSound = "Beep",
                NumberOfWindows = 4,
                Name = "Ford",
                Logo = "Ford Logo",
                HasExtendedCab = true,
                BedSize = "This truck is equipped with an extended bed size to allow more room for storage",
            };

            List<IVehicle> vehicles = new List<IVehicle>()     
            {
                car1,
                suv1,
                truck1
            };

            foreach (IVehicle vehicle in vehicles)
            {
                Console.WriteLine((vehicle.GetType()));
                Console.WriteLine();

                Console.WriteLine($"Company name of vehicle: {vehicle.Name}");
                Console.WriteLine($"Company Logo: {vehicle.Logo}");
                Console.WriteLine();

                Console.WriteLine($"The status of this vehicles engine is: {vehicle.Engine}");
                Console.WriteLine($"Number of wheels vehicle has: {vehicle.HasWheels}");
                Console.WriteLine($"Number of windows vehicle has: {vehicle.NumberOfWindows}");
                Console.WriteLine($"The sound of this vehicles horn is: {vehicle.HornSound}");
            }
        }
    }
}
