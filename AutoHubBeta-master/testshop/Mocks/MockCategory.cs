using System.Collections.Generic;
using testshop.data.Interfaces;
using testshop.data.models;

namespace testshop.Mocks
{
    //მანქანის კატეგორი  Get
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> Allcategories
        {
            get
            {
                return new List<Category>
                {
                    new Category{ CategoryName ="ელექტრომობილი", Description="თანამედროვე ტრანსპორტი"},
                    new Category{ CategoryName ="კლასიკური ავტომობილი", Description="მოტორიზებული მანქანა ბენზინის"}
                };
            }
        }
    }
}
