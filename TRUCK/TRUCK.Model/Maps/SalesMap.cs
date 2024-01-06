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
    public class SalesMap : CoreMap<Sales>
    {
        public override void Configure(EntityTypeBuilder<Sales> builder)
        {
            builder.Property(x => x.Day).HasMaxLength(50).IsRequired(true);
            builder.Property(x => x.TotalPrice).HasMaxLength(50).IsRequired(true);
            builder.Property(x => x.ClientName).HasMaxLength(50).IsRequired(true);
            builder.Property(x => x.ClientSurname).HasMaxLength(50).IsRequired(true);
            builder.Property(x => x.ClientMobileNo).HasMaxLength(50).IsRequired(true);
            builder.Property(x => x.RentDate).HasMaxLength(50).IsRequired(true);
        }
    }
}
