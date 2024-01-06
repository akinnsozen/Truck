using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRUCK.Core.Entity;

namespace TRUCK.Model.Entities
{
    public class Driver : CoreEntity
    {
        [Required(ErrorMessage = "Bu alan boş geçilemez")] 
        public string DriverName { get; set; }
        [Required(ErrorMessage = "Bu alan boş geçilemez")] 
        public string DriverSurname { get; set; }
        [Required(ErrorMessage = "Bu alan boş geçilemez")] 
        public string Deneyim { get; set; }

    }
}
