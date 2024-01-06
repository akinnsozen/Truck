using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TRUCK.Core.Service;
using TRUCK.Model.Entities;
using TRUCK.Models.ViewModels;

namespace TRUCK.Controllers
{
    public class RentController : Controller
    {
        private readonly ICoreService<WorkMachine> _work;
        private readonly ICoreService<Driver> _dri;
        private readonly ICoreService<Sales> _sa;
        private readonly IMapper _mapper;

        public RentController(ICoreService<WorkMachine> work, ICoreService<Driver> dri, ICoreService<Sales> sa,IMapper mapper)
        {
            _work = work;
            _dri = dri;
            _sa = sa;
            _mapper = mapper;
        }


        public IActionResult Index()
        {
            var workMachines = _work.GetAll();
            var drivers = _dri.GetAll();

            
            return View(new RentAddViewModel { drivers = drivers, workMachines = workMachines });
        }
        [HttpPost]
        public IActionResult Index(RentAddViewModel s)
        {


           

            






            if (s.ClientMobileNo != null && s.ClientName != null && s.ClientSurname != null && s.ClientMobileNo.Length==10  )
            {
                var work = _work.GetByID(s.WorkMachineID);
                //  var map= _mapper.Map<Sales>(s);

                var rent = new Sales
                {
                    ClientSurname = s.ClientSurname,
                    ClientMobileNo = s.ClientMobileNo,
                    ClientName = s.ClientName,
                    WorkMachineID = s.WorkMachineID,
                    DriverID = s.DriverID,
                    TotalPrice = work.DailyPrice * s.Day,
                    Day = s.Day,






                };
                _sa.Add(rent);
                ViewBag.AddMessage = "Kiralama işlemi tamamlanmıştır. Sizinle en kısa sürede iletişime geçeceğiz !! || TOPLAM ÖDEME TUTARI = " + rent.TotalPrice.ToString() + " TRUCK ile her zaman güvendesiniz ^_^";
                var workMachines = _work.GetAll();
                var drivers = _dri.GetAll();


                return View(new RentAddViewModel { drivers = drivers, workMachines = workMachines });
            }
            else if (s.ClientMobileNo != null && s.ClientMobileNo.Length != 10)
            {
                ViewBag.TelError = "Girdiğiniz telefon numarası hatalıdır 10 haneli telefon numaranızı giriniz";
                var workMachines = _work.GetAll();
                var drivers = _dri.GetAll();


                return View(new RentAddViewModel { drivers = drivers, workMachines = workMachines });
            }
            else
            {
                ViewBag.Error = "Lütfen soruları boş bırakmayınız";
                var workMachines = _work.GetAll();
                var drivers = _dri.GetAll();


                return View(new RentAddViewModel { drivers = drivers, workMachines = workMachines });
            }


            
        }
    }
}
