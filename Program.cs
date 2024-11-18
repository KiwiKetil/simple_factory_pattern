
using SimpleFactory.FactoryPattern;

IVehicle car = VehicleFactory.CreateVehicle(VehicleTypes.Car);
Console.WriteLine(car);
car.Start();
car.Stop();