using Account.Core.Models.Content;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account.Reposatory.Data.Config
{
    public class GoverrateAgencyMissionConfiguration : IEntityTypeConfiguration<GoverrateAgencyMission>
    {
        public void Configure(EntityTypeBuilder<GoverrateAgencyMission> builder)
        {
            builder.Property(m => m.CaseType)
                .IsRequired();
            builder.Property(b => b.Latitude)
                .HasColumnType("decimal(20, 17)");

            builder.Property(b => b.Longitude)
                .HasColumnType("decimal(20, 17)");

        }
    }

}
