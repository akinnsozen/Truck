using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TRUCK.Core.Service;
using TRUCK.Model.Entities;

namespace TRUCK.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class WorkMachineController : Controller
    {



        private readonly ICoreService<WorkMachine> _workm;

        public WorkMachineController(ICoreService<WorkMachine> workm)
        {
            _workm = workm;
        }

        public IActionResult WorkMachineList()
        {
            return View(_workm.GetAll());
        }

        public IActionResult Update(int id)
        {
            return View(_workm.GetByID(id));
        }
        [HttpPost]
        public IActionResult Update(WorkMachine w)
        {
           if(w.WorkMachineName!=null)
            {
             return _workm.Update(w) ? View("WorkMachineList", _workm.GetAll()) : View();
              
            }
            ViewBag.UpdateError = "İş Makinesi Güncellerken Hata Oluştu";
            return View();

        }

        public IActionResult Delete(int id)
        {
            return _workm.Delete(id) ? View("WorkMachineList",_workm.GetAll()):View();
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(WorkMachine w)
        {
            if (w.WorkMachineName != null && ModelState.IsValid)
            {
                return _workm.Add(w) ? View("WorkMachineList", _workm.GetAll()) : View();
            }
            ViewBag.AddError = "İş Makinesi Eklerken Hata Oluştu Tüm Alanları Doldurunuz";
            return View();
        }
    }
}
