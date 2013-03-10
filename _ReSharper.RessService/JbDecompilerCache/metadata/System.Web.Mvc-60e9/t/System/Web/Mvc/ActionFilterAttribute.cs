// Type: System.Web.Mvc.ActionFilterAttribute
// Assembly: System.Web.Mvc, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// Assembly location: C:\Working\RessService\packages\Microsoft.AspNet.Mvc.4.0.20710.0\lib\net40\System.Web.Mvc.dll

using System;

namespace System.Web.Mvc
{
	/// <summary>
	/// Represents the base class for filter attributes.
	/// </summary>
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
	public abstract class ActionFilterAttribute : FilterAttribute, IActionFilter, IResultFilter
	{
		/// <summary>
		/// Called by the ASP.NET MVC framework before the action method executes.
		/// </summary>
		/// <param name="filterContext">The filter context.</param>
		public virtual void OnActionExecuting(ActionExecutingContext filterContext);

		/// <summary>
		/// Called by the ASP.NET MVC framework after the action method executes.
		/// </summary>
		/// <param name="filterContext">The filter context.</param>
		public virtual void OnActionExecuted(ActionExecutedContext filterContext);

		/// <summary>
		/// Called by the ASP.NET MVC framework before the action result executes.
		/// </summary>
		/// <param name="filterContext">The filter context.</param>
		public virtual void OnResultExecuting(ResultExecutingContext filterContext);

		/// <summary>
		/// Called by the ASP.NET MVC framework after the action result executes.
		/// </summary>
		/// <param name="filterContext">The filter context.</param>
		public virtual void OnResultExecuted(ResultExecutedContext filterContext);
	}
}
