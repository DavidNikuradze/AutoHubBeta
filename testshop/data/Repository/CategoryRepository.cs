using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testshop.data.Interfaces;
using testshop.data.models;

namespace testshop.data.Repository
{
    public class CategoryRepository : ICarsCategory
    {
        private readonly AppDBContent appDBContent;
        public CategoryRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Category> Allcategories => appDBContent.categories;
    }
}
