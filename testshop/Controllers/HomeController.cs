using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testshop.data.Interfaces;
using testshop.ViewModels;

namespace testshop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAllCars _CarRep;

        

        public HomeController(IAllCars carRepository)
        {
            _CarRep = carRepository;
            
        }

        public ViewResult Index()
        {
            var HomeCars = new HomeViewModel()
            {
                FavCars = _CarRep.GetFavCars
            };
            return View(HomeCars);
        }
    }
}
