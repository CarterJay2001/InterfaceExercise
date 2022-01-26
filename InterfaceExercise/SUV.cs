using System;
namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public SUV()
        {
        }
        public SUV(bool offroad, bool thirdrow, int numberofwheels, int numberofdoors, string model, int year, bool electric, string name, int established)
        {
            OffRoad = offroad;
            ThirdRow = thirdrow;
            NumberOfWheels = numberofwheels;
            NumberOfDoors = numberofdoors;
            Model = model;
            Year = year;
            Electric = electric;
            Name = name;
            Established = established;
        }

        public bool OffRoad { get; set; }
        public bool ThirdRow { get; set; }

        public int NumberOfWheels { get; set; }
        public int NumberOfDoors { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public bool Electric { get; set; }

        public string Name { get; set; }
        public int Established { get; set; }
    }
}
