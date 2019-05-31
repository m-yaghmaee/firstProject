using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using SampleProject.Models;

namespace SampleProject.DAL
{
    public class ApplicationDbContext:DbContext
    {

        public ApplicationDbContext()
            :base("ConnectionContext")
        {

        }

        public DbSet<Country> Countrys { get; set; }
        public DbSet<Company> Companys { get; set; }
        public DbSet<Category> categorys { get; set; }
        public DbSet<Product> Products { get; set; }



    }
}