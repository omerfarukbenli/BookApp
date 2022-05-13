using BookApp.DataAccess.Mapping;
using BookApp.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp.DataAccess
{
    public class DataContext : DbContext
    {
           public DataContext()
           {
           }

            public DataContext(DbContextOptions<DataContext> options) : base(options)
           {

           }


   //     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //    {
     //       optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=book;Trusted_Connection=True;");
      //  }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BookMap());
            modelBuilder.ApplyConfiguration(new CategoryMap());


        }
    }
}
