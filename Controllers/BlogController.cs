using HomeEdu.DAL;
using HomeEdu.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HomeEdu.Controllers
{
    public class BlogController : Controller
    {
        public readonly AppDbContext _dbContext;
        private readonly int _blogCount;

        public BlogController(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
            _blogCount = _dbContext.Blog.Count();
        }


        public IActionResult Index()
        {
            var pageCounts = _dbContext.PageCount.ToList();

            ViewBag.BlogCount = _blogCount;

            var blogs = _dbContext.Blog.Take(9).ToList();

            var blogViewModel = new BlogViewModel
            {
                Blogs = blogs,
                PageCounts = pageCounts
            };

            return View(blogViewModel);
        }
    }
}
