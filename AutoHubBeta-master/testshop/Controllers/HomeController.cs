using Microsoft.AspNetCore.Mvc;
using testshop.data.Interfaces;
using testshop.ViewModels;

namespace testshop.Controllers
{
    //HomeController
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
