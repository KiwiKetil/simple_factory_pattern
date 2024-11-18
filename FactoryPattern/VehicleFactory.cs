using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.FactoryPattern;
internal static class VehicleFactory
{
    internal static IVehicle CreateVehicle(VehicleTypes type) => type switch
    {
        VehicleTypes.Car => new Car(),
        VehicleTypes.MotorCycle => new Motorcycle(),
        _ => throw new ArgumentException("Invalid vehicle type", nameof(type))
    };
}
