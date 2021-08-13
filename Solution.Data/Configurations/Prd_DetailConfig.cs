using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Solution.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solution.Data.Configurations
{
    class Prd_DetailConfig : IEntityTypeConfiguration<Prd_Detail>
    {
        public void Configure(EntityTypeBuilder<Prd_Detail> builder)
        {
            builder.ToTable("Prd_Detail");

            builder.HasKey(x => x.Prd_Detail_Id);

            builder.Property(x => x.Prd_Detail_Price).IsRequired();

            builder.Property(x => x.Prd_Detail_Descriptions);

            builder.Property(x => x.Prd_Detail_Image)
                                .IsRequired()
                               .HasMaxLength(30)
                               .HasDefaultValue("Image1.jpg");

            builder.Property(x => x.Prd_Detail_Quantity).IsRequired();

            builder.Property(x => x.Prd_Detail_Date).IsRequired();
        }
    }
}
