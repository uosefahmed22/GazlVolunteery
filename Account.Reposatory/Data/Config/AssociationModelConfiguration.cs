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
    public class AssociationModelConfiguration : IEntityTypeConfiguration<AssociationModel>
    {
        public void Configure(EntityTypeBuilder<AssociationModel> builder)
        {
            
            builder.Property(b => b.Latitude)
                .HasColumnType("decimal(20, 17)");

            builder.Property(b => b.Longitude)
                .HasColumnType("decimal(20, 17)");

        }
    }
}
