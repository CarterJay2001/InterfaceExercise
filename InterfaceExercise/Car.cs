using System;
namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public Car()
        {
        }
        public Car(string type, bool convertable, int numberofwheels, int numberofdoors, string model, int year, bool electric, string name, int established)
        {
            Type = type;
            Convertable = convertable;
            NumberOfWheels = numberofwheels;
            NumberOfDoors = numberofdoors;
            Model = model;
            Year = year;
            Electric = electric;
            Name = name;
            Established = established;
        }
        public string Type { get; set; }
        public bool Convertable { get; set; }

        public int NumberOfWheels { get; set; }
        public int NumberOfDoors { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public bool Electric { get; set; }

        public string Name { get; set; }
        public int Established { get; set; }
    }
}
