using System;
namespace InterfaceExercise
{
    public interface IVehicle
    {
        public int NumberOfWheels { get; set; }
        public int NumberOfDoors { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public bool Electric { get; set; }
    }
}
