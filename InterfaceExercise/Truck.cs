using System;
namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public Truck()
        {
        }
        public Truck(bool lifted, int bedsize, int numberofwheels, int numberofdoors, string model, int year, bool electric, string name, int established)
        {
            Lifted = lifted;
            BedSize = bedsize;
            NumberOfWheels = numberofwheels;
            NumberOfDoors = numberofdoors;
            Model = model;
            Year = year;
            Electric = electric;
            Name = name;
            Established = established;
        }
        public bool Lifted { get; set; }
        public int BedSize { get; set; }

        public int NumberOfWheels { get; set; }
        public int NumberOfDoors { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public bool Electric { get; set; }

        public string Name { get; set; }
        public int Established { get; set; }
    }
}
