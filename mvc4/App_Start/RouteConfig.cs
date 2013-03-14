using System.Web.Mvc;
using System.Web.Routing;

namespace mvc4 {
	public class RouteConfig {
		public static void RegisterRoutes( RouteCollection routes ) {
			routes.IgnoreRoute( "{resource}.axd/{*pathInfo}" );
			
			routes.MapRoute(
                name: "GoToAction",
                url : "{controller}/{action}",
                defaults: new {},
                constraints: new { action = @"[a-zA-Z]+" }
            );

            routes.MapRoute( 
                name : "Deleting", 
                url : "{controller}/{id}", 
                defaults : new { action = "DELETE", id = UrlParameter.Optional }, 
                constraints : new { httpMethod = new HttpMethodConstraint( "DELETE" ) }
			);

            routes.MapRoute( 
                name : "Putting", 
                url : "{controller}/{id}", 
                defaults : new { action = "PUT", id = UrlParameter.Optional }, 
                constraints : new { httpMethod = new HttpMethodConstraint( "PUT" ) }
			);
			
			routes.MapRoute( 
                name : "Posting", 
                url : "{controller}/{id}", 
                defaults : new { action = "POST", id = UrlParameter.Optional }, 
                constraints : new { httpMethod = new HttpMethodConstraint( "POST" ) }
			);

            routes.MapRoute( 
                name : "Details", 
                url : "{controller}/{id}", 
                defaults : new { action = "GetDetails" }, 
                constraints : new { httpMethod = new HttpMethodConstraint( "GET" ) }
			);
			
            routes.MapRoute( 
                name : "Getting", 
                url : "{controller}", 
                defaults : new { action = "Get", code = UrlParameter.Optional }, 
                constraints : new { httpMethod = new HttpMethodConstraint( "GET" ) }
			);

            routes.MapRoute( 
                name : "Default", 
                url : "{controller}/{action}/{id}", 
                defaults : new { action = "Get", id = UrlParameter.Optional }
			);
		}
	}
}