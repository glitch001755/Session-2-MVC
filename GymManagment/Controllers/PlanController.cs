using GymManagment.Contexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GymManagment.Controllers
{
    public class PlanController : Controller
    {
        private GymDbContext dbContext = new GymDbContext();
        public async Task<IActionResult> Index()
        {
            var plans = await dbContext.Plans.ToListAsync();
            return View(plans);
        }

    }
}
