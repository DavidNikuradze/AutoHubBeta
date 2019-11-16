namespace testshop.data.models
{
 // Cars Model
    public class Car
    {
        public  int id { get; set; }
        public string name { get; set; }
        public string shortdescription { get; set; }
        public string longdescription { get; set; }
        public string img { get; set; }
        public ushort price { get; set; }
        public bool isfavorite { get; set; }
        public bool avalable { get; set; }
        public int categoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}
