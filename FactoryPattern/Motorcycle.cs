using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.FactoryPattern;
internal class Motorcycle : IVehicle
{
    public string Brand => "Suzuki";
    public string Model => "Hayabusa Gen 1.";
    public int Year => 2009;
    public string Category => "Motorcycle";
    public string Description => "as fast as it gets";

    public void Start()
    {
        Console.WriteLine($"The {Category.ToLower()} {Brand} {Model} starts it engine by the press of a button");
    }

    public void Stop()
    {
        Console.WriteLine($"The {Category.ToLower()} {Brand} {Model} turns off ");
    }

    public override string ToString()
    {
        return $"The {Category.ToLower()} {Brand} {Model} from {Year} is {Description}";
    }
}
