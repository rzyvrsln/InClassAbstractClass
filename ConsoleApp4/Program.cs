using ConsoleApp4.Models;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Plane plane = new Plane(22);
            Bicycle bicycle = new Bicycle(13);
            Car car = new Car(15,2,3);

            Console.WriteLine($"{plane.AverageSpeed()}");
            Console.WriteLine($"Bicycle Pedal Count: {bicycle.AverageSpeed()}");
            Console.WriteLine($"Car Door Count: {car.AverageSpeed()}");

        }
    }
}