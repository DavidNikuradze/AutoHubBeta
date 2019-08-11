using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testshop.data.Interfaces;
using testshop.data.models;

namespace testshop.data.Repository
{
    public class CarRepository : IAllCars
    {
        private readonly AppDBContent appDBContent;
        public CarRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Car> Cars => appDBContent.cars.Include(c => c.Category);

        public IEnumerable<Car> GetFavCars => appDBContent.cars.Where(d => d.isfavorite).Include(c => c.Category);

        public Car GetObject(int CarID) => appDBContent.cars.FirstOrDefault(p => p.id == CarID);
       
    }
}
