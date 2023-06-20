using HomeEdu.DAL;
using HomeEdu.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

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

        public IActionResult Search(string searchedProduct)
        {
            var courses = _dbContext.Course.Where(x => x.Title.Contains(searchedProduct)).ToList();

            return PartialView("_SearchedCoursePartial", courses);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var course = await _dbContext.Course.FirstOrDefaultAsync(x => x.Id == id);
            if (course == null) return NotFound();
            return View(course);
        }
    }
}
