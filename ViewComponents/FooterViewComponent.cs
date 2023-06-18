using HomeEdu.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HomeEdu.ViewComponents
{
    public class FooterViewComponent : ViewComponent
    {
        public readonly AppDbContext _dbContext;
        public FooterViewComponent(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }

        public IViewComponentResult Invoke()
        {
            var footer = _dbContext.Footer.Include(x => x.GetInTouches).Include(x => x.Informations).Include(x => x.SosialMedias).Include(x => x.usefulLinks).FirstOrDefault();

            return View(footer);
        }
    }
}
