﻿using System;
using System.Collections.Generic;
using System.Linq;
using testshop.data.Interfaces;
using testshop.data.models;

namespace testshop.Mocks
{

    // ლოკალური ბაზა Carts მგონი წასაშლელი 
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory carsCategory = new MockCategory();
        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>
                {
                    new Car
                    {
                        name ="Tesla Model S",
                        img ="https://st.motortrend.com/uploads/sites/10/2015/11/2013-tesla-model-s-sedan-angular-front.png",
                        isfavorite =true,
                        longdescription ="Thish is The Electro Car",
                        shortdescription ="Electro Car",
                        price =40000,
                        avalable =true,
                        Category = carsCategory.Allcategories.First()
                    },
                    new Car
                    {
                        name ="Nissan Leaf",
                        img ="https://cars.usnews.com/static/images/Auto/izmo/i77884793/2018_nissan_leaf_angularfront.jpg",
                        isfavorite =true,
                        longdescription ="Thish is The Electro Car",
                        shortdescription ="Electro Car",
                        price =15000,
                        avalable =false,
                        Category = carsCategory.Allcategories.First()
                    },
                    new Car
                    {
                        name ="Mitsubishi EVO X",
                        img ="https://www.google.com/search?q=mitsubishi+lancer+evo&sxsrf=ACYBGNRalsfdnOoS9NzuNWzEoRnaJKp6XA:1570551315232&source=lnms&tbm=isch&sa=X&ved=0ahUKEwjwuPvJh43lAhUyxaYKHayYC4cQ_AUIEigB&biw=1536&bih=722#imgrc=lZ82hVqLORDBgM:",
                        isfavorite =true,
                        longdescription ="Thish is The oil Car",
                        shortdescription ="Lancer Evolution",
                        price =50000,
                        avalable =true,
                        Category = carsCategory.Allcategories.Last()
                    },
                    new Car
                    {
                        name ="Nissan Skyline GTR-R34",
                        img ="https://the-drive-2.imgix.net/https%3A%2F%2Fapi.thedrive.com%2Fwp-content%2Fuploads%2F2017%2F04%2Fd5db501f-5b0b-4e93-bfdd-d954edefe143-large.jpg%3Fquality%3D85?w=1440&auto=compress%2Cformat&ixlib=js-1.2.1&s=03e51712acb8b91c447b304e6d0fc984",
                        isfavorite =false,
                        longdescription ="Thish is The oil Car",
                        shortdescription ="Old but Legend",
                        price =60000,
                        avalable =true,
                        Category = carsCategory.Allcategories.Last()
                    },
                    new Car
                    {
                        name ="Nissan Skyline GTR-R35",
                        img ="https://www.vividracing.com/images/waldr35front.jpg",
                        isfavorite =true,
                        longdescription ="Thish is The oil Car",
                        shortdescription ="Legend Car",
                        price =20000,
                        avalable =true,
                        Category = carsCategory.Allcategories.Last()
                    },

                    new Car
                    {
                        name ="Mitsubishi EVO X",
                        img ="https://cdn1.evo.co.uk/sites/evo/files/styles/gallery_adv/public/images/dir_674/car_photo_337048.jpg?itok=QXLpVvz0",
                        isfavorite =true,
                        longdescription ="Thish is The oil Car",
                        shortdescription ="Lancer Evolution",
                        price =20000,
                        avalable =true,
                        Category = carsCategory.Allcategories.Last()
                    }
                };
            }
        }
        //ფავორიტი მანქანების წამოღება 
        public IEnumerable<Car> GetFavCars { get; set; }
        public Car GetObject(int CarID)
        {
            throw new NotImplementedException();
        }
    }
}
