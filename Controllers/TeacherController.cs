using HomeEdu.DAL;
using HomeEdu.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HomeEdu.Controllers
{
    public class TeacherController : Controller
    {
        public readonly AppDbContext _dbContext;
        private readonly int _teacherCount;

        public TeacherController(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
            _teacherCount = _dbContext.Teacher.Count();
        }

        public IActionResult Index()
        {
            ViewBag.TeacherCount = _teacherCount;

            var teachers = _dbContext.Teacher.Take(12).ToList();

            var teacherViewModel = new TeacherViewModel
            {
                Teachers = teachers,
            };

            return View(teacherViewModel);
        }

    }
}
