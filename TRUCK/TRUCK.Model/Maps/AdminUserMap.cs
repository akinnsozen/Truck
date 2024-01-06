using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using TRUCK.Core.Map;
using TRUCK.Model.Entities;

namespace TRUCK.Model.Maps
{
    public class AdminUserMap: CoreMap<AdminUser>
    {
        public override void Configure(EntityTypeBuilder<AdminUser> builder)
        {
            builder.Property(x => x.AdminUsername).HasMaxLength(50).IsRequired(true);
            builder.Property(x => x.AdminPassword).HasMaxLength(50).IsRequired(true);
         
           
        }
    }
}
