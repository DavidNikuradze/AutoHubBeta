using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using testshop.data.models;

namespace testshop.data
{
    public class AppDBContent : DbContext
    {

        public AppDBContent(DbContextOptions<AppDBContent> options) : base (options)
        {

        }

        public DbSet<Car> cars { get; set; }
        public DbSet<Category> categories { get; set; }
    }
}
