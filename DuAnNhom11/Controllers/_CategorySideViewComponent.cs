using DuAnNhom11.Data;
using Microsoft.AspNetCore.Mvc;

namespace DuAnNhom11.Controllers
{
	[ViewComponent(Name = "_CategorySide")]
	public class _CategorySideViewComponent : ViewComponent
	{
		private readonly DuAnNhom11Context _context;
		public _CategorySideViewComponent(DuAnNhom11Context context)
		{
			_context = context;
		}
		public IViewComponentResult Invoke()
		{
			var _category = _context.Category.ToList();
			return View("_CategorySide", _category);
		}
	}
}
