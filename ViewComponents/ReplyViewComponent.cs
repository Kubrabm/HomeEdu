using HomeEdu.DAL;
using Microsoft.AspNetCore.Mvc;

namespace HomeEdu.ViewComponents
{
    public class ReplyViewComponent : ViewComponent
    {
        public readonly AppDbContext _dbContext;

        public ReplyViewComponent(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }

        public IViewComponentResult Invoke()
        {
            var reply = _dbContext.Reply.FirstOrDefault();

            return View(reply);
        }
    }
}
