// Type: System.Web.Mvc.RouteCollectionExtensions
// Assembly: System.Web.Mvc, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// Assembly location: C:\Working\RessService\packages\Microsoft.AspNet.Mvc.4.0.20710.0\lib\net40\System.Web.Mvc.dll

using System.Web.Routing;

namespace System.Web.Mvc
{
	/// <summary>
	/// Extends a <see cref="T:System.Web.Routing.RouteCollection"/> object for MVC routing.
	/// </summary>
	public static class RouteCollectionExtensions
	{
		/// <summary>
		/// Returns an object that contains information about the route and virtual path that are the result of generating a URL in the current area.
		/// </summary>
		/// 
		/// <returns>
		/// An object that contains information about the route and virtual path that are the result of generating a URL in the current area.
		/// </returns>
		/// <param name="routes">An object that contains the routes for the applications.</param><param name="requestContext">An object that encapsulates information about the requested route.</param><param name="values">An object that contains the parameters for a route.</param>
		public static VirtualPathData GetVirtualPathForArea(this RouteCollection routes, RequestContext requestContext, RouteValueDictionary values);

		/// <summary>
		/// Returns an object that contains information about the route and virtual path that are the result of generating a URL in the current area.
		/// </summary>
		/// 
		/// <returns>
		/// An object that contains information about the route and virtual path that are the result of generating a URL in the current area.
		/// </returns>
		/// <param name="routes">An object that contains the routes for the applications.</param><param name="requestContext">An object that encapsulates information about the requested route.</param><param name="name">The name of the route to use when information about the URL path is retrieved.</param><param name="values">An object that contains the parameters for a route.</param>
		public static VirtualPathData GetVirtualPathForArea(this RouteCollection routes, RequestContext requestContext, string name, RouteValueDictionary values);

		/// <summary>
		/// Ignores the specified URL route for the given list of available routes.
		/// </summary>
		/// <param name="routes">A collection of routes for the application.</param><param name="url">The URL pattern for the route to ignore.</param><exception cref="T:System.ArgumentNullException">The <paramref name="routes"/> or <paramref name="url"/> parameter is null.</exception>
		public static void IgnoreRoute(this RouteCollection routes, string url);

		/// <summary>
		/// Ignores the specified URL route for the given list of the available routes and a list of constraints.
		/// </summary>
		/// <param name="routes">A collection of routes for the application.</param><param name="url">The URL pattern for the route to ignore.</param><param name="constraints">A set of expressions that specify values for the <paramref name="url"/> parameter.</param><exception cref="T:System.ArgumentNullException">The <paramref name="routes"/> or <paramref name="url"/> parameter is null.</exception>
		public static void IgnoreRoute(this RouteCollection routes, string url, object constraints);

		/// <summary>
		/// Maps the specified URL route.
		/// </summary>
		/// 
		/// <returns>
		/// A reference to the mapped route.
		/// </returns>
		/// <param name="routes">A collection of routes for the application.</param><param name="name">The name of the route to map.</param><param name="url">The URL pattern for the route.</param><exception cref="T:System.ArgumentNullException">The <paramref name="routes"/> or <paramref name="url"/> parameter is null.</exception>
		public static Route MapRoute(this RouteCollection routes, string name, string url);

		/// <summary>
		/// Maps the specified URL route and sets default route values.
		/// </summary>
		/// 
		/// <returns>
		/// A reference to the mapped route.
		/// </returns>
		/// <param name="routes">A collection of routes for the application.</param><param name="name">The name of the route to map.</param><param name="url">The URL pattern for the route.</param><param name="defaults">An object that contains default route values.</param><exception cref="T:System.ArgumentNullException">The <paramref name="routes"/> or <paramref name="url"/> parameter is null.</exception>
		public static Route MapRoute(this RouteCollection routes, string name, string url, object defaults);

		/// <summary>
		/// Maps the specified URL route and sets default route values and constraints.
		/// </summary>
		/// 
		/// <returns>
		/// A reference to the mapped route.
		/// </returns>
		/// <param name="routes">A collection of routes for the application.</param><param name="name">The name of the route to map.</param><param name="url">The URL pattern for the route.</param><param name="defaults">An object that contains default route values.</param><param name="constraints">A set of expressions that specify values for the <paramref name="url"/> parameter.</param><exception cref="T:System.ArgumentNullException">The <paramref name="routes"/> or <paramref name="url"/> parameter is null.</exception>
		public static Route MapRoute(this RouteCollection routes, string name, string url, object defaults, object constraints);

		/// <summary>
		/// Maps the specified URL route and sets the namespaces.
		/// </summary>
		/// 
		/// <returns>
		/// A reference to the mapped route.
		/// </returns>
		/// <param name="routes">A collection of routes for the application.</param><param name="name">The name of the route to map.</param><param name="url">The URL pattern for the route.</param><param name="namespaces">A set of namespaces for the application.</param><exception cref="T:System.ArgumentNullException">The <paramref name="routes"/> or <paramref name="url"/> parameter is null.</exception>
		public static Route MapRoute(this RouteCollection routes, string name, string url, string[] namespaces);

		/// <summary>
		/// Maps the specified URL route and sets default route values and namespaces.
		/// </summary>
		/// 
		/// <returns>
		/// A reference to the mapped route.
		/// </returns>
		/// <param name="routes">A collection of routes for the application.</param><param name="name">The name of the route to map.</param><param name="url">The URL pattern for the route.</param><param name="defaults">An object that contains default route values.</param><param name="namespaces">A set of namespaces for the application.</param><exception cref="T:System.ArgumentNullException">The <paramref name="routes"/> or <paramref name="url"/> parameter is null.</exception>
		public static Route MapRoute(this RouteCollection routes, string name, string url, object defaults, string[] namespaces);

		/// <summary>
		/// Maps the specified URL route and sets default route values, constraints, and namespaces.
		/// </summary>
		/// 
		/// <returns>
		/// A reference to the mapped route.
		/// </returns>
		/// <param name="routes">A collection of routes for the application.</param><param name="name">The name of the route to map.</param><param name="url">The URL pattern for the route.</param><param name="defaults">An object that contains default route values.</param><param name="constraints">A set of expressions that specify values for the <paramref name="url"/> parameter.</param><param name="namespaces">A set of namespaces for the application.</param><exception cref="T:System.ArgumentNullException">The <paramref name="routes"/> or <paramref name="url"/> parameter is null.</exception>
		public static Route MapRoute(this RouteCollection routes, string name, string url, object defaults, object constraints, string[] namespaces);
	}
}
