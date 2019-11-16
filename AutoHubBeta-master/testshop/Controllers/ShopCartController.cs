using Microsoft.AspNetCore.Mvc;
using System.Linq;
using testshop.data.Interfaces;
using testshop.data.models;
using testshop.ViewModels;

namespace testshop.Controllers
{
    //ShopCartController
    public class ShopCartController : Controller
    {
        private readonly IAllCars _CarRep;

        private readonly ShopCart _shopCart;

        public ShopCartController(IAllCars carRepository, ShopCart shopCart)
        {
            _CarRep = carRepository;
            _shopCart = shopCart;
        }
        public ViewResult Index()
        {
            var items = _shopCart.getshopitems();
            _shopCart.listshopitems = items;

            var obj = new ShopCartViewModel
            {
                shopCart= _shopCart               
            };
            return View(obj);
        }

        public RedirectToActionResult addtocart(int id)
        {
            var items = _CarRep.Cars.FirstOrDefault(i => i.id == id);

            if (items != null)
            {
                _shopCart.AddToCart(items);
            }
            return RedirectToAction("Index");
        }
    }
}
