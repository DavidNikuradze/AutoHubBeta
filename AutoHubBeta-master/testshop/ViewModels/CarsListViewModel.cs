﻿using System.Collections.Generic;
using testshop.data.models;

namespace testshop.ViewModels
{
    //მეინფეიჯზე მოაქვს მანქნების ლისტი
    public class CarsListViewModel
    {
        public IEnumerable<Car> AllCars { get; set; }
        public  string CarCategory { get; set; }
    }
}
