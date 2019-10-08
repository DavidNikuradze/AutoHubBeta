using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testshop.data.models
{
    public class ShopCartItem
    {
        public int ID { get; set; }
        public  Car car { get; set; }
        public int price{ get; set; }

        public string ShopCartID { get; set; }

    }
}
