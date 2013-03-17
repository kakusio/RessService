using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace mvc4.Account
{
	public class AuthenticateFilterAction : ActionFilterAttribute
	{
		private readonly IEnumerable<string> IgnoreUrls = new List<string> {"/api/user"};

		public override void OnActionExecuting(ActionExecutingContext filterContext)
		{
			var path = filterContext.HttpContext.Request.Path;
			if (IsIgnored(path)) return;

			var collection = filterContext.HttpContext.Request.QueryString;

			if (collection.Count > 0 && collection["Address"] == "token") return;
			filterContext.Result = new RedirectResult(IgnoreUrls.FirstOrDefault());
		}


		private bool IsIgnored(string path)
		{
			return IgnoreUrls.Contains(path.ToLower());
		}
	}
}