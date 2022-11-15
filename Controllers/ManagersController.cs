using Microsoft.AspNetCore.Mvc;
using ProjetoMVC.Data;
using ProjetoMVC.Models;
using ProjetoMVC.Models.Domain;

namespace ProjetoMVC.Controllers
{
    public class ManagersController : Controller
    {
        private readonly MVCDbContext mvcDbContext;

        public ManagersController(MVCDbContext mvcDbContext)
        {
            this.mvcDbContext = mvcDbContext;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddManagerViewModel addManagerRequest)
        {
            var managers = new Manager()
            {
                Name = addManagerRequest.Name,
                Email = addManagerRequest.Email,
                Salary = addManagerRequest.Salary,
                DateOfBirth = addManagerRequest.DateOfBirth,
                Department = addManagerRequest.Department,
            };

            await mvcDbContext.Manager.AddAsync(managers);
            await mvcDbContext.SaveChangesAsync();

            return RedirectToAction("Add");
        }
    }
}
