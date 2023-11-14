using BlogEntity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogData.Mappings
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(new Category
            {
                Id = Guid.Parse("696B9001-AAD9-43C1-8286-6CF3495B31F5"),
                Name = "Asp .Net Core",
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                isDeleted = false,
            },
           new Category
           {
               Id = Guid.Parse("1FE393E9-0A0E-413E-96B7-CDE88666BE44"),
               Name = "Visual Studio",
               CreatedBy = "Admin Test",
               CreatedDate = DateTime.Now,
               isDeleted = false,
           });
        }
    }
}
