using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TRUCK.Core.Service;
using TRUCK.Model.Entities;

namespace TRUCK.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class DriverController : Controller
    {
        
        private readonly ICoreService<Driver> _dri;

        public DriverController(ICoreService<Driver> dri)
        {
            _dri = dri;
        }

        public IActionResult DriverList()
        {
            return View(_dri.GetAll());
        }

        public IActionResult Update(int id)
        {
            return View(_dri.GetByID(id));
        }
        [HttpPost]
        public IActionResult Update(Driver dri)
        {
            if (dri.DriverName != null && dri.DriverSurname !=null && dri.DriverSurname!=null) 
            {
                return _dri.Update(dri) ? View("DriverList", _dri.GetAll()) : View();

            }
            ViewBag.UpdateError = "Operatör Güncellerken Hata Oluştu";
            return View("DriverList");
        }
        public IActionResult Delete(int id)
        {
            return _dri.Delete(id) ? View("DriverList", _dri.GetAll()) : View();
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Driver dri) 
        {
            if (dri.DriverName != null && dri.DriverSurname != null && dri.DriverSurname != null)
            {
                return _dri.Add(dri) ? View("DriverList", _dri.GetAll()) : View();
            }
            ViewBag.AddError = "Operatör Eklerken Hata Oluştu Tüm Alanları Doldurunuz";
            return View();
        }
    }
}
