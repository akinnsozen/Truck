using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TRUCK.Core.Service;
using TRUCK.Model.Entities;
using TRUCK.Models.ViewModels;

namespace TRUCK.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class RentController : Controller
    {
        private readonly ICoreService<Sales> s;

        public RentController(ICoreService<Sales> s)
        {
            this.s = s;
        }

     

        public IActionResult RentList()
        {


           var sales=  s.GetAllAsync(x => x.Driver , y=>y.WorkMachine);

            return View(sales);
        }

        public IActionResult Delete(int id)
        {
            s.Delete(id);
            return RedirectToAction("RentList");
        }
    }
}
