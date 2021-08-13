using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Solution.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solution.Data.Configurations
{
    class BrandConfig : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.ToTable("Brand");

            builder.HasKey(x => x.Brand_Id);

            builder.Property(x => x.Brand_Name).IsRequired().HasMaxLength(30);

            builder.Property(x => x.Brand_Descriptions);

            builder.Property(x => x.Brand_Image)
                                .IsRequired()
                               .HasMaxLength(30)
                               .HasDefaultValue("Image1.jpg");
        }
    }
}
