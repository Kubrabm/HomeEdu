using HomeEdu.DAL;
using HomeEdu.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HomeEdu.Controllers
{
    public class CourseController : Controller
    {
        public readonly AppDbContext _dbContext;
        private readonly int _courseCount;

        public CourseController(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
            _courseCount = _dbContext.Course.Count();
        }

        public IActionResult Index()
        {
            ViewBag.CourseCount = _courseCount;

            var courses = _dbContext.Course.Take(3).ToList();

            var courseViewModel = new CourseViewModel
            {
                Courses = courses,
            };

            return View(courseViewModel);
        }
        public IActionResult LoadCourses(int skipCourse)
        {
            var courses = _dbContext.Course.Skip(skipCourse).Take(3).ToList();

            return PartialView("_CoursePartial", courses);
        }
    }
}
