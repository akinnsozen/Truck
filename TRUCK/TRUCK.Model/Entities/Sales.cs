using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRUCK.Core.Entity;

namespace TRUCK.Model.Entities
{
    public class Sales : CoreEntity
    {
        [Required(ErrorMessage = "Bu alan boş geçilemez")]
        public string ClientName { get; set; }

        [Required(ErrorMessage = "Bu alan boş geçilemez")] 
        public string ClientSurname { get; set; }
        [StringLength(10,MinimumLength =10,ErrorMessage ="10 Haneli telefon numaranızı giriniz")]
        [Required(ErrorMessage = "Bu alan boş geçilemez")] 
        public string ClientMobileNo { get; set; }
        [Required(ErrorMessage = "Bu alan boş geçilemez")] 
        public int Day { get; set; }
        [Required(ErrorMessage = "Bu alan boş geçilemez")] 
        public int WorkMachineID { get; set; }
        public WorkMachine WorkMachine { get; set; }
        public int TotalPrice { get; set; }
        public int DriverID { get; set; }
        public Driver Driver { get; set; }
        public DateTime RentDate { get; set; } = DateTime.Now;
    }
}
