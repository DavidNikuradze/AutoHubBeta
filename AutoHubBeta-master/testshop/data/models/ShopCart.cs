using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace testshop.data.models
{
    // ბაზაში დამატება  და წამოღება Cart
    public class ShopCart
    {

        private readonly AppDBContent appDBContent;
        public ShopCart(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public  string ShopCartID { get; set; }

        public List<ShopCartItem> listshopitems { get; set; }

        //GetCart
        public static ShopCart GetCart (IServiceProvider service)
        {
          //  ISession session = service.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = service.GetService<AppDBContent>();

            //   string shopcartID = session.GetString("CartID") ?? Guid.NewGuid().ToString();

            //     session.SetString("CartID", shopcartID);

            return new ShopCart(context) { ShopCartID = "klajsdht;k" };

        }

        // SetCart
        public void AddToCart(Car car)
        {
            this.appDBContent.shopCartItems.Add(new ShopCartItem
            {
                ShopCartID = ShopCartID,
                car = car,
                price = car.price
            });
            appDBContent.SaveChanges();
        }

        //GetCartItems
        public List<ShopCartItem> getshopitems()
        {
            return appDBContent.shopCartItems.Where(c => c.ShopCartID == ShopCartID).Include(s => s.car).ToList();
        }
    }
}
