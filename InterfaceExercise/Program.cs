using System;
using System.Collections.Generic;

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
            var vehicles = new List<IVehicle>();

            var tesla = new Car("sedan", false, 4, 4, "Model 3", 2022, true, "Tesla", 2003);
            var ford = new Truck(true, 300, 4, 2, "F-150", 2015, false, "Ford", 1965);
            var jeep = new SUV(true, false, 4, 4, "Wrangle", 2021, false, "Jeep", 1985);
            vehicles.Add(tesla);
            vehicles.Add(ford);
            vehicles.Add(jeep);

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"Welcome to mystery Vehicle: this vehicle has {vehicle.NumberOfWheels} wheels and {vehicle.NumberOfDoors} doors" +
                    $"\nIt was made in {vehicle.Year} and it is {(vehicle.Electric ? "Electric" : "Not Electric")}\n");
            }
        }
    }
}
