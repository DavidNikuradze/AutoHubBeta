namespace testshop.data.models
{
    //ShopCartItemModel Short Description
    public class ShopCartItem
    {
        public int ID { get; set; }
        public  Car car { get; set; }
        public int price{ get; set; }
        public string ShopCartID { get; set; }
    }
}
