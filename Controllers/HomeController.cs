using HomeEdu.DAL;
using HomeEdu.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HomeEdu.Controllers
{
    public class HomeController:Controller
    {
        public readonly AppDbContext _dbContext;

        public HomeController(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }
        public IActionResult Index()
        {
            var sliders = _dbContext.Slider.ToList();
            var noticeLefts = _dbContext.NoticeLeft.ToList();
            var noticeRights = _dbContext.NoticeRight.ToList();
            var banners = _dbContext.Banner.ToList();
            var courses = _dbContext.Course.Take(3).ToList();
            var events = _dbContext.Event.Take(8).ToList();
            var testimonials = _dbContext.Testimonial.ToList();
            var blogs = _dbContext.Blog.Take(3).ToList();

            var homeViewModel = new HomeViewModel
            {
                Sliders = sliders,
                NoticeLefts = noticeLefts,
                NoticeRights = noticeRights,
                Banners = banners,
                Courses = courses,
                Events = events,
                Testimonials = testimonials,
                Blogs = blogs,
            };

            return View(homeViewModel);
        }
    }
}

