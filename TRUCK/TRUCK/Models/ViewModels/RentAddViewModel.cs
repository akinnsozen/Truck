using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TRUCK.Model.Entities;

namespace TRUCK.Models.ViewModels
{
    public class RentAddViewModel
    {
       
        public string ClientName { get; set; }

        public string ClientSurname { get; set; }
      
        public string ClientMobileNo { get; set; }
    
        public int Day { get; set; }
     
        public int WorkMachineID { get; set; }
        public WorkMachine WorkMachine { get; set; }
        public int TotalPrice { get; set; }
        public int DriverID { get; set; }
        public Driver Driver { get; set; }
        public IList<Driver>  drivers { get; set; }
        public IList<WorkMachine> workMachines { get; set; }
       
    }
}
