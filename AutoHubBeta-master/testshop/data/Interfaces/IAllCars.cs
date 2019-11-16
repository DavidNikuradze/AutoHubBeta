using System.Collections.Generic;
using testshop.data.models;

namespace testshop.data.Interfaces
{
    // CarsID Cart Get
    public interface IAllCars
    {
        IEnumerable<Car> Cars {get;}
        IEnumerable<Car> GetFavCars { get; }
        Car GetObject(int CarID);
    }
}
