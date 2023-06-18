using HomeEdu.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HomeEdu.ViewComponents
{
    public class SubscribeViewComponent : ViewComponent
    {
        public readonly AppDbContext _dbContext;

        public SubscribeViewComponent(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }

        public IViewComponentResult Invoke()
        {
            var subscribe = _dbContext.Subscribe.Include(x => x.Alerts).FirstOrDefault();

            return View(subscribe);
        }
    }
}
