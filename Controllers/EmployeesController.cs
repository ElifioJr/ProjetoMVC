using Microsoft.AspNetCore.Mvc;
using ProjetoMVC.Data;
using ProjetoMVC.Models;
using ProjetoMVC.Models.Domain;

namespace ProjetoMVC.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly MVCDbContext mvcDbContext;

        public EmployeesController(MVCDbContext mvcDbContext)
        {
            this.mvcDbContext = mvcDbContext;
        }

        [HttpGet]
        public IActionResult Add()
        {
           return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddEmployeeViewModel addEmployeeRequest)
        {
            var employee = new Employee()
            {
                Id = Guid.NewGuid(),
                Name = addEmployeeRequest.Name,
                Email = addEmployeeRequest.Email,
                Salary = addEmployeeRequest.Salary,
                DateOfBirth = addEmployeeRequest.DateOfBirth,
                Department = addEmployeeRequest.Department,
            };

            await mvcDbContext.Employees.AddAsync(employee);
            await mvcDbContext.SaveChangesAsync();

            return RedirectToAction("Add");
        }
    }
}
