// Type: System.Web.HttpContext
// Assembly: System.Web, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// Assembly location: C:\Windows\Microsoft.NET\Framework\v4.0.30319\System.Web.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Runtime;
using System.Security.Permissions;
using System.Security.Principal;
using System.Threading.Tasks;
using System.Web.Caching;
using System.Web.Configuration;
using System.Web.Instrumentation;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.WebSockets;

namespace System.Web
{
	/// <summary>
	/// Encapsulates all HTTP-specific information about an individual HTTP request.
	/// </summary>
	public sealed class HttpContext : IServiceProvider, IPrincipalContainer
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="T:System.Web.HttpContext"/> class by using the specified request and response objects.
		/// </summary>
		/// <param name="request">The <see cref="T:System.Web.HttpRequest"/> object for the current HTTP request.</param><param name="response">The <see cref="T:System.Web.HttpResponse"/> object for the current HTTP request.</param>
		public HttpContext(HttpRequest request, HttpResponse response);

		/// <summary>
		/// Initializes a new instance of the <see cref="T:System.Web.HttpContext"/> class that uses the specified worker-request object.
		/// </summary>
		/// <param name="wr">The <see cref="T:System.Web.HttpWorkerRequest"/> object for the current HTTP request.</param>
		public HttpContext(HttpWorkerRequest wr);

		/// <summary>
		/// Accepts an <see cref="T:System.Web.WebSockets.AspNetWebSocket"/> request using the specified user function.
		/// </summary>
		/// <param name="userFunc">The user function.</param><exception cref="T:System.ArgumentNullException">The <paramref name="userFunc"/> parameter is null.</exception><exception cref="T:System.NotSupportedException">The request is not an <see cref="T:System.Web.WebSockets.AspNetWebSocket"/> request.</exception>
		[TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
		public void AcceptWebSocketRequest(Func<AspNetWebSocketContext, Task> userFunc);

		/// <summary>
		/// Accepts an <see cref="T:System.Web.WebSockets.AspNetWebSocket"/> request using the specified user function and options object.
		/// </summary>
		/// <param name="userFunc">The user function.</param><param name="options">The options object.</param><exception cref="T:System.ArgumentNullException">The <paramref name="userFunc"/> parameter is null.</exception><exception cref="T:System.NotSupportedException">The request is not an <see cref="T:System.Web.WebSockets.AspNetWebSocket"/> request.</exception>
		public void AcceptWebSocketRequest(Func<AspNetWebSocketContext, Task> userFunc, AspNetWebSocketOptions options);

		/// <summary>
		/// Raises a virtual event that occurs when the HTTP part of the request is ending.
		/// </summary>
		/// 
		/// <returns>
		/// The subscription token.
		/// </returns>
		/// <param name="callback">The HTTP context object.</param><exception cref="T:System.ArgumentNullException">The <paramref name="callback"/> parameter is null.</exception>
		public ISubscriptionToken AddOnRequestCompleted(Action<HttpContext> callback);

		/// <summary>
		/// Enables an object's <see cref="M:System.IDisposable.Dispose"/> method to be called when the <see cref="T:System.Web.WebSockets.AspNetWebSocket"/> connection part of this request is completed.
		/// </summary>
		/// 
		/// <returns>
		/// The subscription token.
		/// </returns>
		/// <param name="target">The object whose <see cref="M:System.IDisposable.Dispose"/> method must be called when the <see cref="T:System.Web.WebSockets.AspNetWebSocket"/> connection part of the request is completed.</param>
		public ISubscriptionToken DisposeOnPipelineCompleted(IDisposable target);

		/// <summary>
		/// Returns an object for the current service type.
		/// </summary>
		/// 
		/// <returns>
		/// A <see cref="T:System.Web.HttpContext"/>; otherwise, null if no service is found.
		/// </returns>
		/// <param name="service">A type of <see cref="T:System.Web.HttpContext"/> service to set the service provider to.</param>
		object IServiceProvider.GetService(Type service);

		/// <summary>
		/// Enables you to specify a handler for the request.
		/// </summary>
		/// <param name="handler">The object that should process the request.</param><exception cref="T:System.InvalidOperationException">The <see cref="M:System.Web.HttpContext.RemapHandler(System.Web.IHttpHandler)"/> method was called after the <see cref="E:System.Web.HttpApplication.MapRequestHandler"/> event occurred.</exception>
		public void RemapHandler(IHttpHandler handler);

		/// <summary>
		/// Adds an exception to the exception collection for the current HTTP request.
		/// </summary>
		/// <param name="errorInfo">The <see cref="T:System.Exception"/> to add to the exception collection.</param>
		public void AddError(Exception errorInfo);

		/// <summary>
		/// Clears all errors for the current HTTP request.
		/// </summary>
		public void ClearError();

		/// <summary>
		/// Sets the type of session state behavior that is required in order to support an HTTP request.
		/// </summary>
		/// <param name="sessionStateBehavior">One of the enumeration values that specifies what type of session state behavior is required.</param><exception cref="T:System.InvalidOperationException">The method was called after the <see cref="E:System.Web.HttpApplication.AcquireRequestState"/> event was raised. </exception>
		public void SetSessionStateBehavior(SessionStateBehavior sessionStateBehavior);

		/// <summary>
		/// Returns requested configuration information for the current application.
		/// </summary>
		/// 
		/// <returns>
		/// An object containing configuration information. (Cast the returned configuration section to the appropriate configuration type before use.)
		/// </returns>
		/// <param name="name">The application configuration tag for which information is requested.</param>
		[Obsolete("The recommended alternative is System.Web.Configuration.WebConfigurationManager.GetWebApplicationSection in System.Web.dll. http://go.microsoft.com/fwlink/?linkid=14202")]
		public static object GetAppConfig(string name);

		/// <summary>
		/// Returns requested configuration information for the current HTTP request.
		/// </summary>
		/// 
		/// <returns>
		/// The specified <see cref="T:System.Configuration.ConfigurationSection"/>, null if the section does not exist, or an internal object if the section is not accessible at run time. (Cast the returned object to the appropriate configuration type before use.)
		/// </returns>
		/// <param name="name">The configuration tag for which information is requested.</param>
		[Obsolete("The recommended alternative is System.Web.HttpContext.GetSection in System.Web.dll. http://go.microsoft.com/fwlink/?linkid=14202")]
		[TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
		public object GetConfig(string name);

		/// <summary>
		/// Gets a specified configuration section for the current application's default configuration.
		/// </summary>
		/// 
		/// <returns>
		/// The specified <see cref="T:System.Configuration.ConfigurationSection"/>, null if the section does not exist, or an internal object if the section is not accessible at run time.
		/// </returns>
		/// <param name="sectionName">The configuration section path (in XPath format) and the configuration element name.</param>
		public object GetSection(string sectionName);

		/// <summary>
		/// Rewrites the URL using the given path.
		/// </summary>
		/// <param name="path">The internal rewrite path.</param><exception cref="T:System.ArgumentNullException">The <paramref name="path"/> parameter is null.</exception><exception cref="T:System.Web.HttpException">The <paramref name="path"/> parameter is not in the current application's root directory.</exception>
		[TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
		public void RewritePath(string path);

		/// <summary>
		/// Rewrites the URL using the given path and a Boolean value that specifies whether the virtual path for server resources is modified.
		/// </summary>
		/// <param name="path">The internal rewrite path.</param><param name="rebaseClientPath">true to reset the virtual path; false to keep the virtual path unchanged.</param><exception cref="T:System.ArgumentNullException">The <paramref name="path"/> parameter is null.</exception><exception cref="T:System.Web.HttpException">The <paramref name="path"/> parameter is not in the current application's root directory.</exception>
		public void RewritePath(string path, bool rebaseClientPath);

		/// <summary>
		/// Rewrites the URL by using the given path, path information, and query string information.
		/// </summary>
		/// <param name="filePath">The internal rewrite path.</param><param name="pathInfo">Additional path information for a resource. For more information, see <see cref="P:System.Web.HttpRequest.PathInfo"/>.</param><param name="queryString">The request query string.</param><exception cref="T:System.ArgumentNullException">The <paramref name="path"/> parameter is not in the current application's root directory.</exception><exception cref="T:System.Web.HttpException">The <paramref name="filePath"/> parameter is not in the current application's root directory.</exception>
		public void RewritePath(string filePath, string pathInfo, string queryString);

		/// <summary>
		/// Rewrites the URL using the given virtual path, path information, query string information, and a Boolean value that specifies whether the client file path is set to the rewrite path.
		/// </summary>
		/// <param name="filePath">The virtual path to the resource that services the request.</param><param name="pathInfo">Additional path information to use for the URL redirect. For more information, see <see cref="P:System.Web.HttpRequest.PathInfo"/>.</param><param name="queryString">The request query string to use for the URL redirect.</param><param name="setClientFilePath">true to set the file path used for client resources to the value of the <paramref name="filePath"/> parameter; otherwise false.</param><exception cref="T:System.ArgumentNullException">The <paramref name="path"/> parameter is not in the current application's root directory.</exception><exception cref="T:System.Web.HttpException">The <paramref name="filePath"/> parameter is not in the current application's root directory.</exception>
		public void RewritePath(string filePath, string pathInfo, string queryString, bool setClientFilePath);

		/// <summary>
		/// Gets an application-level resource object based on the specified <see cref="P:System.Web.Compilation.ResourceExpressionFields.ClassKey"/> and <see cref="P:System.Web.Compilation.ResourceExpressionFields.ResourceKey"/> properties.
		/// </summary>
		/// 
		/// <returns>
		/// An <see cref="T:System.Object"/> that represents the requested application-level resource object; otherwise, null if a resource object is not found or if a resource object is found but it does not have the requested property.
		/// </returns>
		/// <param name="classKey">A string that represents the <see cref="P:System.Web.Compilation.ResourceExpressionFields.ClassKey"/> property of the requested resource object.</param><param name="resourceKey">A string that represents the <see cref="P:System.Web.Compilation.ResourceExpressionFields.ResourceKey"/>   property of the requested resource object.</param><exception cref="T:System.Resources.MissingManifestResourceException">A resource object with the specified <paramref name="classKey"/> parameter was not found.- or -The main assembly does not contain the resources for the neutral culture, and these resources are required because the appropriate satellite assembly is missing.</exception>
		[TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
		public static object GetGlobalResourceObject(string classKey, string resourceKey);

		/// <summary>
		/// Gets an application-level resource object based on the specified <see cref="P:System.Web.Compilation.ResourceExpressionFields.ClassKey"/> and <see cref="P:System.Web.Compilation.ResourceExpressionFields.ResourceKey"/> properties, and on the <see cref="T:System.Globalization.CultureInfo"/> object.
		/// </summary>
		/// 
		/// <returns>
		/// An <see cref="T:System.Object"/> that represents the requested application-level resource object, which is localized for the specified culture; otherwise, null if a resource object is not found or if a resource object is found but it does not have the requested property.
		/// </returns>
		/// <param name="classKey">A string that represents the <see cref="P:System.Web.Compilation.ResourceExpressionFields.ClassKey"/> property of the requested resource object.</param><param name="resourceKey">A string that represents a <see cref="P:System.Web.Compilation.ResourceExpressionFields.ResourceKey"/>   property of the requested resource object.</param><param name="culture">A string that represents the <see cref="T:System.Globalization.CultureInfo"/> object of the requested resource.</param><exception cref="T:System.Resources.MissingManifestResourceException">A resource object for which the specified <paramref name="classKey"/> parameter was not found.- or -The main assembly does not contain the resources for the neutral culture, and these resources are required because the appropriate satellite assembly is missing.</exception>
		public static object GetGlobalResourceObject(string classKey, string resourceKey, CultureInfo culture);

		/// <summary>
		/// Gets a page-level resource object based on the specified <see cref="P:System.Web.Compilation.ExpressionBuilderContext.VirtualPath"/> and <see cref="P:System.Web.Compilation.ResourceExpressionFields.ResourceKey"/> properties.
		/// </summary>
		/// 
		/// <returns>
		/// An <see cref="T:System.Object"/> that represents the requested page-level resource object; otherwise, null if a matching resource object is found but not a <paramref name="resourceKey"/> parameter.
		/// </returns>
		/// <param name="virtualPath">The <see cref="P:System.Web.Compilation.ExpressionBuilderContext.VirtualPath"/> property for the local resource object.</param><param name="resourceKey">A string that represents a <see cref="P:System.Web.Compilation.ResourceExpressionFields.ResourceKey"/>   property of the requested resource object</param><exception cref="T:System.Resources.MissingManifestResourceException">A resource object was not found for the specified <paramref name="virtualPath"/> parameter.</exception><exception cref="T:System.ArgumentException">The specified <paramref name="virtualPath"/> parameter is not in the current application's root directory.</exception><exception cref="T:System.InvalidOperationException">The resource class for the page was not found.</exception>
		[TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
		public static object GetLocalResourceObject(string virtualPath, string resourceKey);

		/// <summary>
		/// Gets a page-level resource object based on the specified <see cref="P:System.Web.Compilation.ExpressionBuilderContext.VirtualPath"/> and <see cref="P:System.Web.Compilation.ResourceExpressionFields.ResourceKey"/> properties, and on the <see cref="T:System.Globalization.CultureInfo"/> object.
		/// </summary>
		/// 
		/// <returns>
		/// An <see cref="T:System.Object"/> that represents the requested local resource object, which is localized for the specified culture; otherwise null if a matching resource object is found but not a <paramref name="resourceKey"/> parameter.
		/// </returns>
		/// <param name="virtualPath">The <see cref="P:System.Web.Compilation.ExpressionBuilderContext.VirtualPath"/> property for the local resource object.</param><param name="resourceKey">A string that represents a <see cref="P:System.Web.Compilation.ResourceExpressionFields.ResourceKey"/>   property of the requested resource object.</param><param name="culture">A string that represents the <see cref="T:System.Globalization.CultureInfo"/> object of the requested resource object.</param><exception cref="T:System.Resources.MissingManifestResourceException">A resource object was not found for the specified <paramref name="virtualPath"/> Parameter.</exception><exception cref="T:System.ArgumentException">The specified <paramref name="virtualPath"/> parameter is not in the current application's root directory.</exception><exception cref="T:System.InvalidOperationException">The resource class for the page was not found.</exception>
		public static object GetLocalResourceObject(string virtualPath, string resourceKey, CultureInfo culture);

		/// <summary>
		/// Gets a value that indicates whether the request is an <see cref="T:System.Web.WebSockets.AspNetWebSocket"/> request.
		/// </summary>
		/// 
		/// <returns>
		/// true if the request is an <see cref="T:System.Web.WebSockets.AspNetWebSocket"/> request; otherwise, false.
		/// </returns>
		public bool IsWebSocketRequest { get; }

		/// <summary>
		/// Gets a value that indicates whether the connection is upgrading from an HTTP connection to an <see cref="T:System.Web.WebSockets.AspNetWebSocket"/> connection.
		/// </summary>
		/// 
		/// <returns>
		/// true if the connection is upgrading; otherwise, false.
		/// </returns>
		public bool IsWebSocketRequestUpgrading { get; }

		/// <summary>
		/// Gets the ordered list of protocols requested by the client.
		/// </summary>
		/// 
		/// <returns>
		/// The requested protocols, or null if this is not an <see cref="T:System.Web.WebSockets.AspNetWebSocket"/> request or if no list is present.
		/// </returns>
		public IList<string> WebSocketRequestedProtocols { get; }

		/// <summary>
		/// Gets the negotiated protocol that was sent from the server to the client for an <see cref="T:System.Web.WebSockets.AspNetWebSocket"/> connection.
		/// </summary>
		/// 
		/// <returns>
		/// The negotiated protocol.
		/// </returns>
		public string WebSocketNegotiatedProtocol { [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
		get; }

		/// <summary>
		/// Gets or sets the <see cref="T:System.Web.HttpContext"/> object for the current HTTP request.
		/// </summary>
		/// 
		/// <returns>
		/// The <see cref="T:System.Web.HttpContext"/> for the current HTTP request.
		/// </returns>
		public static HttpContext Current { get; set; }

		/// <summary>
		/// Gets or sets an object that contains flags that pertain to asynchronous preload mode.
		/// </summary>
		/// 
		/// <returns>
		/// An object that contains flags that pertain to asynchronous preload mode.
		/// </returns>
		public AsyncPreloadModeFlags AsyncPreloadMode { get; set; }

		/// <summary>
		/// Gets or sets a value that indicates whether asynchronous operations are allowed during parts of ASP.NET request processing when they are not expected.
		/// </summary>
		/// 
		/// <returns>
		/// false if ASP.NET will throw an exception when the asynchronous API is used at a time when it is not expected; otherwise, true. The default value is false.
		/// </returns>
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public bool AllowAsyncDuringSyncStages { get; set; }

		/// <summary>
		/// Gets or sets the <see cref="T:System.Web.HttpApplication"/> object for the current HTTP request.
		/// </summary>
		/// 
		/// <returns>
		/// The <see cref="T:System.Web.HttpApplication"/> for the current HTTP request.ASP.NET uses ApplicationInstance instead of Application as a property name to refer to the current <see cref="T:System.Web.HttpApplication"/> instance in order to avoid confusion between ASP.NET and classic ASP. In classic ASP, Application refers to the global application state dictionary.
		/// </returns>
		/// <exception cref="T:System.InvalidOperationException">The Web application is running under IIS 7.0 in Integrated mode, and an attempt was made to change the property value from a non-null value to null.</exception>
		public HttpApplication ApplicationInstance { [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
		get; set; }

		/// <summary>
		/// Gets the <see cref="T:System.Web.HttpApplicationState"/> object for the current HTTP request.
		/// </summary>
		/// 
		/// <returns>
		/// The <see cref="T:System.Web.HttpApplicationState"/> for the current HTTP request.To get the <see cref="T:System.Web.HttpApplication"/> object for the current HTTP request, use <see cref="P:System.Web.HttpContext.ApplicationInstance"/>. (ASP.NET uses ApplicationInstance instead of Application as a property name to refer to the current <see cref="T:System.Web.HttpApplication"/> instance in order to avoid confusion between ASP.NET and classic ASP. In classic ASP, Application refers to the global application state dictionary.)
		/// </returns>
		public HttpApplicationState Application { get; }

		/// <summary>
		/// Gets or sets the <see cref="T:System.Web.IHttpHandler"/> object responsible for processing the HTTP request.
		/// </summary>
		/// 
		/// <returns>
		/// An <see cref="T:System.Web.IHttpHandler"/> responsible for processing the HTTP request.
		/// </returns>
		public IHttpHandler Handler { [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
		get; set; }

		/// <summary>
		/// Gets the <see cref="T:System.Web.IHttpHandler"/> object for the parent handler.
		/// </summary>
		/// 
		/// <returns>
		/// An <see cref="T:System.Web.IHttpHandler"/> instance, or null if no previous handler was found.
		/// </returns>
		public IHttpHandler PreviousHandler { get; }

		/// <summary>
		/// Gets the <see cref="T:System.Web.IHttpHandler"/> object that represents the currently executing handler.
		/// </summary>
		/// 
		/// <returns>
		/// An <see cref="T:System.Web.IHttpHandler"/> that represents the currently executing handler.
		/// </returns>
		public IHttpHandler CurrentHandler { get; }

		/// <summary>
		/// Gets the <see cref="T:System.Web.HttpRequest"/> object for the current HTTP request.
		/// </summary>
		/// 
		/// <returns>
		/// The <see cref="T:System.Web.HttpRequest"/> for the current HTTP request.
		/// </returns>
		/// <exception cref="T:System.Web.HttpException">The Web application is running under IIS 7 in Integrated mode.</exception>
		public HttpRequest Request { [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
		get; }

		/// <summary>
		/// Gets the <see cref="T:System.Web.HttpResponse"/> object for the current HTTP response.
		/// </summary>
		/// 
		/// <returns>
		/// The <see cref="T:System.Web.HttpResponse"/> for the current HTTP response.
		/// </returns>
		/// <exception cref="T:System.Web.HttpException">The Web application is running under IIS 7 in Integrated mode.</exception>
		public HttpResponse Response { [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
		get; }

		/// <summary>
		/// Gets the <see cref="T:System.Web.TraceContext"/> object for the current HTTP response.
		/// </summary>
		/// 
		/// <returns>
		/// The <see cref="T:System.Web.TraceContext"/> for the current HTTP response.
		/// </returns>
		public TraceContext Trace { get; }

		/// <summary>
		/// Gets a key/value collection that can be used to organize and share data between an <see cref="T:System.Web.IHttpModule"/> interface and an <see cref="T:System.Web.IHttpHandler"/> interface during an HTTP request.
		/// </summary>
		/// 
		/// <returns>
		/// An <see cref="T:System.Collections.IDictionary"/> key/value collection that provides access to an individual value in the collection by a specified key.
		/// </returns>
		public IDictionary Items { get; }

		/// <summary>
		/// Gets the <see cref="T:System.Web.SessionState.HttpSessionState"/> object for the current HTTP request.
		/// </summary>
		/// 
		/// <returns>
		/// The <see cref="T:System.Web.SessionState.HttpSessionState"/> object for the current HTTP request.
		/// </returns>
		public HttpSessionState Session { get; }

		/// <summary>
		/// Gets the <see cref="T:System.Web.HttpServerUtility"/> object that provides methods used in processing Web requests.
		/// </summary>
		/// 
		/// <returns>
		/// The <see cref="T:System.Web.HttpServerUtility"/> for the current HTTP request.
		/// </returns>
		public HttpServerUtility Server { get; }

		/// <summary>
		/// Gets the first error (if any) accumulated during HTTP request processing.
		/// </summary>
		/// 
		/// <returns>
		/// The first <see cref="T:System.Exception"/> for the current HTTP request/response process; otherwise, null if no errors were accumulated during the HTTP request processing. The default is null.
		/// </returns>
		public Exception Error { get; }

		/// <summary>
		/// Gets an array of errors accumulated while processing an HTTP request.
		/// </summary>
		/// 
		/// <returns>
		/// An array of <see cref="T:System.Exception"/> objects for the current HTTP request.
		/// </returns>
		public Exception[] AllErrors { get; }

		/// <summary>
		/// Gets or sets security information for the current HTTP request.
		/// </summary>
		/// 
		/// <returns>
		/// Security information for the current HTTP request.
		/// </returns>
		public IPrincipal User { get; [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries"), SecurityPermission(SecurityAction.Demand, ControlPrincipal = true)]
		set; }

		/// <summary>
		/// Gets the <see cref="T:System.Web.Profile.ProfileBase"/> object for the current user profile.
		/// </summary>
		/// 
		/// <returns>
		/// A <see cref="T:System.Web.Profile.ProfileBase"/> if the application configuration file contains a definition for the profile's properties; otherwise, null.
		/// </returns>
		public ProfileBase Profile { get; }

		/// <summary>
		/// Gets or sets a value that specifies whether the <see cref="T:System.Web.Security.UrlAuthorizationModule"/> object should skip the authorization check for the current request.
		/// </summary>
		/// 
		/// <returns>
		/// true if <see cref="T:System.Web.Security.UrlAuthorizationModule"/> should skip the authorization check; otherwise, false. The default is false.
		/// </returns>
		public bool SkipAuthorization { [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
		get; [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries"), SecurityPermission(SecurityAction.Demand, ControlPrincipal = true)]
		set; }

		/// <summary>
		/// Gets a value indicating whether the current HTTP request is in debug mode.
		/// </summary>
		/// 
		/// <returns>
		/// true if the request is in debug mode; otherwise, false.
		/// </returns>
		public bool IsDebuggingEnabled { get; }

		/// <summary>
		/// Gets a value indicating whether custom errors are enabled for the current HTTP request.
		/// </summary>
		/// 
		/// <returns>
		/// true if custom errors are enabled; otherwise, false.
		/// </returns>
		public bool IsCustomErrorEnabled { get; }

		/// <summary>
		/// Gets the initial timestamp of the current HTTP request.
		/// </summary>
		/// 
		/// <returns>
		/// The timestamp of the current HTTP request.
		/// </returns>
		public DateTime Timestamp { get; }

		/// <summary>
		/// Gets the <see cref="T:System.Web.Caching.Cache"/> object for the current application domain.
		/// </summary>
		/// 
		/// <returns>
		/// The <see cref="T:System.Web.Caching.Cache"/> for the current application domain.
		/// </returns>
		public Cache Cache { get; }

		/// <summary>
		/// Gets a reference to the page-instrumentation service instance for this request.
		/// </summary>
		/// 
		/// <returns>
		/// The page-instrumentation service instance for this request.
		/// </returns>
		public PageInstrumentationService PageInstrumentation { get; }

		/// <summary>
		/// Gets or sets a value that specifies whether the ASP.NET runtime should call <see cref="M:System.Threading.Thread.Abort"/> on the thread that is servicing this request when the request times out.
		/// </summary>
		/// 
		/// <returns>
		/// true if <see cref="M:System.Threading.Thread.Abort"/> will be called when the thread times out; otherwise, false. The default is true.
		/// </returns>
		public bool ThreadAbortOnTimeout { get; set; }

		/// <summary>
		/// Gets a <see cref="T:System.Web.RequestNotification"/> value that indicates the current <see cref="T:System.Web.HttpApplication"/> event that is processing.
		/// </summary>
		/// 
		/// <returns>
		/// One of the <see cref="T:System.Web.RequestNotification"/> values.
		/// </returns>
		/// <exception cref="T:System.PlatformNotSupportedException">The operation requires integrated pipeline mode in IIS 7.0 and at least the .NET Framework version 3.0.</exception>
		public RequestNotification CurrentNotification { get; internal set; }

		/// <summary>
		/// Gets a value that is the current processing point in the ASP.NET pipeline just after an <see cref="T:System.Web.HttpApplication"/> event has finished processing.
		/// </summary>
		/// 
		/// <returns>
		/// true if custom errors are enabled; otherwise, false.
		/// </returns>
		/// <exception cref="T:System.PlatformNotSupportedException">The operation requires the integrated pipeline mode in IIS 7.0 and at least the .NET Framework 3.0.</exception>
		public bool IsPostNotification { get; internal set; }
	}
}
