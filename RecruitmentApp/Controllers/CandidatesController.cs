using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RecruitmentApp.Data;
using RecruitmentApp.Models;
using RecruitmentApp.Models.Entities;

namespace RecruitmentApp.Controllers
{
    public class CandidatesController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public CandidatesController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task< IActionResult> Add(AddCandidateViewModel viewModel)
        {
            var candidate = new Employee
            {
                Name = viewModel.Name,
                Email = viewModel.Email,
                Phone = viewModel.Phone,
                Position = viewModel.Position,
            };

            await dbContext.Employees.AddAsync(candidate);
            await dbContext.SaveChangesAsync();

            return RedirectToAction("List", "Candidates");
        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            var candidates = await dbContext.Employees.ToListAsync();

            return View(candidates);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var candidate = await dbContext.Employees.FindAsync(id);

            return View(candidate);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Employee viewModel)
        {
            var candidate = await dbContext.Employees.FindAsync(viewModel.Id);

            if (candidate is not null)
            {
                candidate.Name = viewModel.Name;
                candidate.Email = viewModel.Email;
                candidate.Phone = viewModel.Phone;
                candidate.Position = viewModel.Position;

                await dbContext.SaveChangesAsync();
            }
            return RedirectToAction("List", "Candidates");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Employee viewModel)
        {
            var candidate = await dbContext.Employees.AsNoTracking().FirstOrDefaultAsync(x => x.Id == viewModel.Id);

            if (candidate is not null)
            {
                dbContext.Employees.Remove(candidate);
                await dbContext.SaveChangesAsync();
            }

            return RedirectToAction("List", "Candidates");
        }
    }
}
