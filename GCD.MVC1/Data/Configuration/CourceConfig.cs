using GCD.MVC1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GCD.MVC1.Data.Configuration
{
    public class CourceConfig : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
    {
            builder.HasOne(x => x.Category)
                   .WithMany(x => x.Courses)
                   .HasForeignKey(x => x.categoryid);
    }
}
}
