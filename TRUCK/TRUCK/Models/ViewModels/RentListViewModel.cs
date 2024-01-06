using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using TRUCK.Model.Entities;

namespace TRUCK.Models.ViewModels
{
    public class RentListViewModel
    {
        public int ID { get; set; }
        public string ClientName { get; set; }

        public string ClientSurname { get; set; }

        public string ClientMobileNo { get; set; }

        public int Day { get; set; }

        public int WorkMachineID { get; set; }
        public string WorkMachineName { get; set; }
        public int TotalPrice { get; set; }
        public int DriverID { get; set; }
        public string DriverName { get; set; }
        
        public DateTime SatısTarihi { get; set; }


    }
}
