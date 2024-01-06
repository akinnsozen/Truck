using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRUCK.Core.Entity;

namespace TRUCK.Model.Entities
{
    public class AdminUser : CoreEntity
    {
        public string AdminUsername { get; set; }
        public string AdminPassword { get; set; }
    }
}
