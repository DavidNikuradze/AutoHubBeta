using System.Collections.Generic;
using testshop.data.models;

namespace testshop.ViewModels
{
    //all FavoritCars Get MinePage
    public class HomeViewModel
    {
        public IEnumerable<Car> FavCars { get; set; }
    }
}
