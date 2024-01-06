using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRUCK.Core.Map;
using TRUCK.Model.Entities;

namespace TRUCK.Model.Maps
{
    public class DriverMap:CoreMap<Driver>
    {
        public override void Configure(EntityTypeBuilder<Driver> builder)
        {
            builder.Property(x => x.DriverName).IsRequired(true).HasMaxLength(50);
            builder.Property(x => x.DriverSurname).IsRequired(true).HasMaxLength(50);
            builder.Property(x => x.Deneyim).IsRequired(true).HasMaxLength(3);
        }
    }
}
