using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Solution.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solution.Data.Configurations
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Product");
            
            builder.HasKey(x => x.Product_Id);
            
            builder.Property(x => x.Status)
                   .IsRequired()
                   .HasDefaultValue<int>(0);

            builder.HasOne(x => x.Category)
                .WithMany()
                .HasForeignKey("Cate_Id")
                .OnDelete(DeleteBehavior.NoAction)
                .HasConstraintName("fk_Product_Category");
            
            builder.HasOne(x => x.Brand)
                .WithMany()
                .HasForeignKey("Brand_Id")
                .OnDelete(DeleteBehavior.NoAction)
                .HasConstraintName("fk_Product_Brand");

            builder.HasOne(x => x.Prd_Detail)
                .WithOne(c=>c.Product)
                .HasForeignKey<Product>(c=>c.Category_Id)
                .OnDelete(DeleteBehavior.NoAction)
                .HasConstraintName("fk_Product_Detail");



        }
    }
}
