using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BookStoreSolution.Data.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStoreSolution.Data.Configurations
{
    public class AppConfigurations : IEntityTypeConfiguration<AppConfig>

    {
        public void Configure(EntityTypeBuilder<AppConfig> builder)
        {
            builder.ToTable("AppConfigs");
            builder.HasKey(x => x.Key);
            builder.Property(x => x.Value).IsRequired(true);
        }
    }
}
