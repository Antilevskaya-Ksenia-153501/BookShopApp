using BookShopWeb.Data;
using Microsoft.AspNetCore.Mvc;

namespace BookShopWeb.Controllers
{
    public class CategoryController : Controller
    {
        private readonly AppDbContext _dbContext;
        public CategoryController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            var categoriesList = _dbContext.Categories.ToList();
            return View(categoriesList);
        }
    }
}
