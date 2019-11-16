using System.Collections.Generic;
namespace testshop.data.models
{
    //  Cars Category
    public class Category
    {
        public  int id { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public List<Car> cars { get; set; }
    }
}
