using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testshop.data.models;

namespace testshop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Car> FavCars { get; set; }
    }
}
