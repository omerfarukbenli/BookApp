using BookApp.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp.DataAccess.Mapping
{
    public class BookMap : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(x => new { x.Id });
           


            //bu kısım hatalı ,    
            //builder.HasOne(x => x.Category).WithMany(x=> x.Books).HasForeignKey(x=>x.CategoryId);
            //kitaba tanımladığımız için, category, kiminle çoklu ilişkisi var, category içindeki books, foreignkey categoryıd
        }
    }
}
