using Microsoft.AspNetCore.Mvc;
using TRUCK.Core.Service;
using TRUCK.Model.Context;
using TRUCK.Model.Entities;

namespace TRUCK.Controllers
{
    public class WorkMachineController : Controller
    {
        private readonly ICoreService<WorkMachine> _db;
        private readonly ICoreService<Driver> _dri;

        public WorkMachineController(ICoreService<WorkMachine> db, ICoreService<Driver> dri)
        {
            _db = db;
            _dri = dri;
        }

        public IActionResult WorkMachineList()
        {
            return View(_db.GetAll());
        }

        public IActionResult DriverList()
        {
            return View(_dri.GetAll());
        }
        public IActionResult About()
        {
            return View();
        }
    }
}
