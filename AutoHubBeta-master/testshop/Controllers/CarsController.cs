using Microsoft.AspNetCore.Mvc;
using testshop.data.Interfaces;
using testshop.ViewModels;

namespace testshop.Controllers
{ //CarsController
    public class CarsController : Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _carsCategory;

        public CarsController(IAllCars iallcars, ICarsCategory icarsCat)
        {
            _allCars = iallcars;
            _carsCategory = icarsCat;

        }
            public IActionResult List()
            {
            ViewBag.Title = "Page For Cars";
            CarsListViewModel obj = new CarsListViewModel();
            obj.AllCars = _allCars.Cars;
            obj.CarCategory = "All Cars";

                return View(obj);
            }       
    }
}
