using DuAnNhom11.Data;
using Microsoft.AspNetCore.Mvc;
namespace DuAnNhom11.Controllers
{
	[ViewComponent(Name = "_Category")]
	public class _CategoryViewComponent : ViewComponent
	{
		private readonly DuAnNhom11Context _context;

		public _CategoryViewComponent(DuAnNhom11Context context)
		{
			_context = context;
		}
		public IViewComponentResult Invoke()
		{
			var _category = _context.Category.ToList();
			return View("_Category", _category);
		}
	}
}
