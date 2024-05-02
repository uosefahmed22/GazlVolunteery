using Account.Core.Models.Content;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account.Reposatory.Data.Config
{
    public class OpportunityConfiguration : IEntityTypeConfiguration<OpportunityModel>
    {
        public void Configure(EntityTypeBuilder<OpportunityModel> builder)
        {

            builder.Property(b => b.Latitude)
                .HasColumnType("decimal(20, 17)");

            builder.Property(b => b.Longitude)
                .HasColumnType("decimal(20, 17)");

        }
    }
}
