using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreCampProject.Controllers
{
	public class CommentController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
		public PartialViewResult PartialViewComment()
		{
			return PartialView();
		}
		public PartialViewResult CommentListByBlog()
		{
			return PartialView();
		}
	}
}
