using System.Collections.Generic;
using testshop.data.models;

namespace testshop.data.Interfaces
{
    //AllcategoriesGet
    public interface ICarsCategory
    {
        IEnumerable<Category> Allcategories { get; }
    }
}
