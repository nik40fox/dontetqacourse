using System;
using ConsoleApp1.Transport;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Bicycle bike1 = new Bicycle();
            Bicycle bike2 = new Bicycle("Santa Cruz");

            bike1.Brand = "Merida";
            
            //Console.WriteLine($"{bike1.Brand} has {bike1.GetWheelsize()}wheelsize");
            //Console.WriteLine($"{bike2.Brand} has {bike2.GetWheelsize()}wheelsize");
            
            PrintBike(bike1.Brand, bike1.GetWheelsize());
            PrintBike(bike2.Brand, bike2.GetWheelsize());
        }

        public static void PrintBike(string name, int wheelsize)
        {
            Console.WriteLine($"{name} has {wheelsize} wheelsize");
        }
    }
}