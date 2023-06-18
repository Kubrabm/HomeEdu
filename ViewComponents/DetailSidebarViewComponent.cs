using HomeEdu.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HomeEdu.ViewComponents
{
    public class DetailSidebarViewComponent : ViewComponent
    {
        public readonly AppDbContext _dbContext;
        public DetailSidebarViewComponent(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }

        public IViewComponentResult Invoke()
        {
            var detailSidebar = _dbContext.DetailSidebar.Include(x => x.Categories).Include(x => x.ThemeBanner).Include(x => x.letstPosts).Include(x => x.Tags).FirstOrDefault();

            return View(detailSidebar);
        }
    }
}
