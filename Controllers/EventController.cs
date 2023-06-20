using HomeEdu.DAL;
using HomeEdu.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HomeEdu.Controllers
{
    public class EventController : Controller
    {
        public readonly AppDbContext _dbContext;
        private readonly int _eventCount;


        public EventController(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
            _eventCount = _dbContext.Event.Count();

        }

        public IActionResult Index()
        {
            ViewBag.EventCount = _eventCount;

            var events = _dbContext.Event.Take(9).ToList();

            var eventViewModel = new EventViewModel
            {
                Events = events,
            };

            return View(eventViewModel);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();
            
            var events= await _dbContext.Event.FirstOrDefaultAsync(x => x.Id == id);
            if (events == null) return NotFound();
            return View(events);

        }

    }
}
