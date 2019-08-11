using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testshop.data.models
{
    public class Category
    {
        public  int id { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }

        public List<Car> cars { get; set; }
    }
}
