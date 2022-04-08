using BussinesLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreCampProject.Controllers
{
	public class CommentController : Controller
	{
		CommentManager cm = new CommentManager(new EfCommentRepository());
		public IActionResult Index()
		{
			return View();
		}
		public PartialViewResult PartialViewComment()
		{
			return PartialView();
		}
		public PartialViewResult CommentListByBlog(int id)
		{
			var values = cm.GetList(id);
			return PartialView(values);
		}
	}
}
