using BussinesLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreCampProject.ViewComponents.Category
{
    public class CategoryListViewComponent : ViewComponent
    {
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());
        public IViewComponentResult Invoke()
        { 
            var values = cm.GetList();
            return View(values);
        }
    }
}
