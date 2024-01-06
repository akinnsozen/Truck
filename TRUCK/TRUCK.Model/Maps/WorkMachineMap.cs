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
    public class WorkMachineMap : CoreMap<WorkMachine>
    {
        public override void Configure(EntityTypeBuilder<WorkMachine> builder)
        {
            builder.Property(x => x.WorkMachineName).HasMaxLength(50).IsRequired(true);
            builder.Property(x => x.DailyPrice).HasMaxLength(50).IsRequired(true);
        }
    }
}
