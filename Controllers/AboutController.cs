using HomeEdu.DAL;
using HomeEdu.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HomeEdu.Controllers
{
    public class AboutController : Controller
    {
        public readonly AppDbContext _dbContext;

        public AboutController(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }

        public IActionResult Index()
        {
            var aboutbanners = _dbContext.AboutBanner.ToList();
            var teachers = _dbContext.Teacher.Take(4).ToList();
            var testimonial = _dbContext.Testimonial.ToList();
            var videos = _dbContext.Video.ToList();
            var noticeLeft = _dbContext.NoticeLeft.ToList();

            var aboutViewModel = new AboutViewModel
            {
                AboutBanners = aboutbanners,
                Teachers = teachers,
                Testimonials = testimonial,
                Videos = videos,
                NoticeLefts = noticeLeft
            };

            return View(aboutViewModel);
        }
    }
}
