using HomeEdu.DAL;
using HomeEdu.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var blog = await _dbContext.Course.FirstOrDefaultAsync(x => x.Id == id);
            if (blog == null) return NotFound();
            return View(blog);
        }
    }
}
