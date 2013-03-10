// Type: System.Web.Mvc.AuthorizeAttribute
// Assembly: System.Web.Mvc, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// Assembly location: C:\Working\RessService\packages\Microsoft.AspNet.Mvc.4.0.20710.0\lib\net40\System.Web.Mvc.dll

using System;
using System.Web;

namespace System.Web.Mvc
{
	/// <summary>
	/// Represents an attribute that is used to restrict access by callers to an action method.
	/// </summary>
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
	public class AuthorizeAttribute : FilterAttribute, IAuthorizationFilter
	{
		/// <summary>
		/// When overridden, provides an entry point for custom authorization checks.
		/// </summary>
		/// 
		/// <returns>
		/// true if the user is authorized; otherwise, false.
		/// </returns>
		/// <param name="httpContext">The HTTP context, which encapsulates all HTTP-specific information about an individual HTTP request.</param><exception cref="T:System.ArgumentNullException">The <paramref name="httpContext"/> parameter is null.</exception>
		protected virtual bool AuthorizeCore(HttpContextBase httpContext);

		/// <summary>
		/// Called when a process requests authorization.
		/// </summary>
		/// <param name="filterContext">The filter context, which encapsulates information for using <see cref="T:System.Web.Mvc.AuthorizeAttribute"/>.</param><exception cref="T:System.ArgumentNullException">The <paramref name="filterContext"/> parameter is null.</exception>
		public virtual void OnAuthorization(AuthorizationContext filterContext);

		/// <summary>
		/// Processes HTTP requests that fail authorization.
		/// </summary>
		/// <param name="filterContext">Encapsulates the information for using <see cref="T:System.Web.Mvc.AuthorizeAttribute"/>. The <paramref name="filterContext"/> object contains the controller, HTTP context, request context, action result, and route data.</param>
		protected virtual void HandleUnauthorizedRequest(AuthorizationContext filterContext);

		/// <summary>
		/// Called when the caching module requests authorization.
		/// </summary>
		/// 
		/// <returns>
		/// A reference to the validation status.
		/// </returns>
		/// <param name="httpContext">The HTTP context, which encapsulates all HTTP-specific information about an individual HTTP request.</param><exception cref="T:System.ArgumentNullException">The <paramref name="httpContext"/> parameter is null.</exception>
		protected virtual HttpValidationStatus OnCacheAuthorization(HttpContextBase httpContext);

		/// <summary>
		/// Gets or sets the user roles.
		/// </summary>
		/// 
		/// <returns>
		/// The user roles.
		/// </returns>
		public string Roles { get; set; }

		/// <summary>
		/// Gets the unique identifier for this attribute.
		/// </summary>
		/// 
		/// <returns>
		/// The unique identifier for this attribute.
		/// </returns>
		public override object TypeId { get; }

		/// <summary>
		/// Gets or sets the authorized users.
		/// </summary>
		/// 
		/// <returns>
		/// The authorized users.
		/// </returns>
		public string Users { get; set; }
	}
}
