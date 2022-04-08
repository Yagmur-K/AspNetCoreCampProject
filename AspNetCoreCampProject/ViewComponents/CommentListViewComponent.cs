using AspNetCoreCampProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AspNetCoreCampProject.ViewComponents
{
    public class CommentListViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentvalues = new List<UserComment>
            {
              new UserComment
              {
                ID = 1,
                UserName = "Yağmur"
              },
              new UserComment
              {
                ID=2,
                UserName="Uzay"
              },
              new UserComment
              {
              ID=3,
              UserName="Barış"
              }
            };
            return View(commentvalues);
        }
    }
}
