using System;
using System.Collections.Generic;

namespace OOPClassesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Cars carAuto = new Cars();

            carAuto.Make = "Honda";
            carAuto.Model = "CR-V";
            carAuto.Year = 2021;
            carAuto.WheelDrive = "2-Wheel";

            Console.WriteLine("Welcome to the OOP Classes exercise.");
            Console.WriteLine();
            Console.WriteLine("We'll start with printing some fields and properties of classes to the console.");
            Console.WriteLine();
            carAuto.AutoCar();

            Console.WriteLine();
            Console.WriteLine("Now, let's make a list of different products, similar to the one above. This time, we'll print them to the console via creation of a list (array).");
            Console.WriteLine();
            Console.WriteLine("We'll also add some additional characteristics to each product, that could be considered, assuming we wanted to make a purchase.");
            Console.WriteLine();

            var AutoVehicle1 = new Cars(); //using 'var' to assign a variable is interchangeable with using 'Cars' in performing the same function.
            AutoVehicle1.Make = "Honda";
            AutoVehicle1.Model = "HR-V";
            AutoVehicle1.Year = 2020;
            AutoVehicle1.WheelDrive = "2-Wheel";
            AutoVehicle1.Warranty = 2.5000m;
            AutoVehicle1.Price = 21767.99;
            AutoVehicle1.MileageEstimation = 32.10;

            Cars AutoVehicle2 = new Cars();
            AutoVehicle2.Make = "Honda";
            AutoVehicle2.Model = "Pilot";
            AutoVehicle2.Year = 2021;
            AutoVehicle2.WheelDrive = "4-Wheel";
            AutoVehicle2.Warranty = 3.0m;
            AutoVehicle2.Price = 31297.99;
            AutoVehicle2.MileageEstimation = 22.75;

            Cars AutoVehicle3 = new Cars();
            AutoVehicle3.Make = "Honda";
            AutoVehicle3.Model = "Accord";
            AutoVehicle3.Year = 2021;
            AutoVehicle3.WheelDrive = "2-Wheel";
            AutoVehicle3.Warranty = 1.58m;
            AutoVehicle3.Price = 25987.99;
            AutoVehicle3.MileageEstimation = 28.92;

            carAuto.Warranty = 2.82m; //added some new features to the first car I assigned and initated properties to what was already written way above.
            carAuto.Price = 27301.99;
            carAuto.MileageEstimation = 30.70;

            var carList = new List<Cars>();
            carList.Add(carAuto);
            carList.Add(AutoVehicle1);
            carList.Add(AutoVehicle2);
            carList.Add(AutoVehicle3);

            foreach (var car in carList)
            {
                Console.WriteLine($"Make: {car.Make}. Model: {car.Model}. Year: {car.Year}. {car.WheelDrive}. ${car.Price}. {car.Warranty} Year Warranty. {car.MileageEstimation} Estimated miles per gallon of gasoline.");
            }
            Console.WriteLine();
            Console.WriteLine("Do we have any takers?");
            Console.WriteLine();
        }
    }
}
