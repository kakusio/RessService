using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace mvc4.Account
{
	public class AuthenticateFilterAction : ActionFilterAttribute
	{
		private readonly IEnumerable<string> _ignoreUrls = new List<string>
		                                                   	{
		                                                   		"/api/user"
		                                                   	};

		public override void OnActionExecuting(ActionExecutingContext filterContext)
		{
			var path = filterContext.HttpContext.Request.Path;
			if (IsIgnored(path)) return;

			string queryString;
			var collection = filterContext.HttpContext.Request.QueryString;

			if (collection.Count > 0 && collection["Address"] == "token")
			{
				return;
			}
			filterContext.Result = new RedirectResult(_ignoreUrls.FirstOrDefault());
			return;

//			if (collection["Address"] != null) return;
//
//			var realPath = GetRealPath(queryString);
//			filterContext.Result = new RedirectResult(realPath);
		}

		

		private bool IsIgnored(string path)
		{
			return _ignoreUrls.Contains(path.ToLower());
		}
	}
}