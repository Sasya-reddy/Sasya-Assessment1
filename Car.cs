using System;
using System.IO;

class Car
{
    public string Model { get; set; }
    public int Year { get; set; }

    public Car(string model, int year)
    {
        Model = model;
        Year = year;
    }

    public override string ToString()
    {
        return $"Model: {Model}, Year: {Year}";
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter car model: ");
        string model = Console.ReadLine();

        Console.Write("Enter the year: ");
        int year = int.Parse(Console.ReadLine());

        Car car = new Car(model, year);

        File.WriteAllText("CarDetails.txt", car.ToString());

        Console.WriteLine("Car details stored into a file");
    }
}