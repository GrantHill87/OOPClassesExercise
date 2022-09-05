using System;
using System.Collections.Generic;
using System.Text;

namespace OOPClassesExercise
{
    public class Cars
    {
        public string Model { get; set; }
        public string Make { get; set; }
        public int Year { get; set; }
        public string WheelDrive { get; set; } //Now, let's add some new aspects to our class of cars.
        public double Price { get; set; }
        public decimal Warranty { get; set; }
        public double MileageEstimation { get; set; }

        public void AutoCar()
        {
            Console.WriteLine($"We're at an auto dealership. The car of most interest is a {Make} {Model}, {Year} and it has a {WheelDrive} drive capacity.");
        }
    }
}
