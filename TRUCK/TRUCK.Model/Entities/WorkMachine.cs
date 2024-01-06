using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRUCK.Core.Entity;

namespace TRUCK.Model.Entities
{
    public class WorkMachine : CoreEntity
    {
        [Required(ErrorMessage ="Bu alan boş geçilemez")]
        public string WorkMachineName { get; set; }
        [Required(ErrorMessage = "Bu alan boş geçilemez")]
        public int DailyPrice { get; set; }
    }
}
