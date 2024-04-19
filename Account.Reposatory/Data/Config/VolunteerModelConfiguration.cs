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
    public class VolunteerModelConfiguration : IEntityTypeConfiguration<Volunteer>
    {
        public void Configure(EntityTypeBuilder<Volunteer> builder)
        {
            builder.Property(b => b.Latitude)
                .HasColumnType("decimal(20, 17)");
            builder.Property(b => b.Longitude)
                .HasColumnType("decimal(20, 17)");

        }
    }
}
