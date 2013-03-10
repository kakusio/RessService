// Type: System.Web.Http.AuthorizeAttribute
// Assembly: System.Web.Http, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// Assembly location: C:\Program Files (x86)\Microsoft ASP.NET\ASP.NET MVC 4\Assemblies\System.Web.Http.dll

using System;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace System.Web.Http
{
	/// <summary>
	/// Specifies the authorization filter that verifies the request's <see cref="T:System.Security.Principal.IPrincipal"/>.
	/// </summary>
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
	public class AuthorizeAttribute : AuthorizationFilterAttribute
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="T:System.Web.Http.AuthorizeAttribute"/> class.
		/// </summary>
		public AuthorizeAttribute();

		/// <summary>
		/// Indicates whether the specified control is authorized.
		/// </summary>
		/// 
		/// <returns>
		/// true if the control is authorized; otherwise, false.
		/// </returns>
		/// <param name="actionContext">The context.</param>
		protected virtual bool IsAuthorized(HttpActionContext actionContext);

		/// <summary>
		/// Calls when an action is being authorized.
		/// </summary>
		/// <param name="actionContext">The context.</param><exception cref="T:System.ArgumentNullException">The context parameter is null.</exception>
		public override void OnAuthorization(HttpActionContext actionContext);

		/// <summary>
		/// Processes requests that fail authorization.
		/// </summary>
		/// <param name="actionContext">The context.</param>
		protected virtual void HandleUnauthorizedRequest(HttpActionContext actionContext);

		/// <summary>
		/// Gets or sets the authorized roles.
		/// </summary>
		/// 
		/// <returns>
		/// The roles string.
		/// </returns>
		public string Roles { get; set; }

		/// <summary>
		/// Gets a unique identifier for this attribute.
		/// </summary>
		/// 
		/// <returns>
		/// A unique identifier for this attribute.
		/// </returns>
		public override object TypeId { get; }

		/// <summary>
		/// Gets or sets the authorized users.
		/// </summary>
		/// 
		/// <returns>
		/// The users string.
		/// </returns>
		public string Users { get; set; }
	}
}
