using HomeEdu.DAL;
using HomeEdu.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        public IActionResult Search(string searchedTeacherFullName)
        {
            var searchedTeacher = _dbContext.Teacher.
                Where(x => x.FullName.ToLower().Contains(searchedTeacherFullName.ToLower()))
                .ToList();

            return PartialView("_SearchedTeacherPartial", searchedTeacher);
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var teacher = await _dbContext.Teacher.FirstOrDefaultAsync(x => x.Id == id);
            if (teacher == null) return NotFound();
            return View(teacher);
        }

    }
}
