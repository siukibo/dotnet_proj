using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Solution.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solution.Data.Configurations
{
    class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Category");

            builder.HasKey(x => x.Category_Id);

            builder.Property(x => x.Category_Name).IsRequired().HasMaxLength(30);

            builder.Property(x => x.Category_Descriptions);

            builder.Property(x => x.Category_Image)
                                .IsRequired()
                               .HasMaxLength(30)
                               .HasDefaultValue("Image1.jpg");
        }
    }
}
