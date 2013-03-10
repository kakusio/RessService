// Type: System.Web.Http.FromBodyAttribute
// Assembly: System.Web.Http, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// Assembly location: C:\Program Files (x86)\Microsoft ASP.NET\ASP.NET MVC 4\Assemblies\System.Web.Http.dll

using System;
using System.Web.Http.Controllers;

namespace System.Web.Http
{
	/// <summary>
	/// An attribute that specifies that an action parameter comes only from the entity body of the incoming <see cref="T:System.Net.Http.HttpRequestMessage"/>.
	/// </summary>
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Parameter, AllowMultiple = false, Inherited = true)]
	public sealed class FromBodyAttribute : ParameterBindingAttribute
	{
		/// <summary>
		/// Gets a parameter binding.
		/// </summary>
		/// 
		/// <returns>
		/// The parameter binding.
		/// </returns>
		/// <param name="parameter">The parameter description.</param>
		public override HttpParameterBinding GetBinding(HttpParameterDescriptor parameter);
	}
}
