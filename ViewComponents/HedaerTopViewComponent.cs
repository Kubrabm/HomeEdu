using HomeEdu.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HomeEdu.ViewComponents
{
    public class HedaerTopViewComponent : ViewComponent
    {
        public readonly AppDbContext _dbContext;

        public HedaerTopViewComponent(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }

        public IViewComponentResult Invoke()
        {
            var headerup = _dbContext.HeaderTop.Include(x => x.TopNavigation).FirstOrDefault();

            return View(headerup);
        }
    }
}
