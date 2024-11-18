using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.FactoryPattern;
internal class Car : IVehicle
{
    public string Brand => "BMW";
    public string Model => "X5";
    public int Year => 2005;
    public string Category => "Car";
    public string Description => "a nice 4WD family car";

    public void Start()
    {
        Console.WriteLine($"The {Category.ToLower()} {Brand} {Model} starts it engine by turning a key");
    }

    public void Stop()
    {
        Console.WriteLine($"The {Category.ToLower()} {Brand} {Model} turns off its igniton");
    }

    public override string ToString()
    {
        return $"The {Category.ToLower()} {Brand} {Model} from {Year} is {Description}";
    }
}
