using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testshop.data.models;

namespace testshop.ViewModels
{
    public class CarsListViewModel
    {
        public IEnumerable<Car> AllCars { get; set; }

        public  string CarCategory { get; set; }
    }
}
