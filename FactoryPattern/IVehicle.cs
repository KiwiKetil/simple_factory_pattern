using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.FactoryPattern;
internal interface IVehicle
{
    public string Brand { get; }
    public string Model { get; }
    public int Year { get; }
    public string Category { get; }
    public string Description { get; }
    void Start();
    void Stop();
}
