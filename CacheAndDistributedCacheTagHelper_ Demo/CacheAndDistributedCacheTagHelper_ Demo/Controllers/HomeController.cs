using CacheAndDistributedCacheTagHelper__Demo.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CacheAndDistributedCacheTagHelper__Demo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public HomeController(ApplicationDbContext context)
        {
            dbContext = context;
        }

        public IActionResult Index()
        {
            var employee = dbContext.Employees.ToList();
            return View(employee);
        }
    }
}
